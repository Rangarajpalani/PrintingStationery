using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PrintingStationeryApp.Data;
using PrintingStationeryApp.Models;

namespace PrintingStationeryApp.Pages.StationeryOrderCompletions
{
    public class CreateModel : PageModel
    {
        private readonly PrintingStationeryApp.Data.PrintingStationeryAppContext _context;
        private readonly IWebHostEnvironment _environment;

        public CreateModel(PrintingStationeryApp.Data.PrintingStationeryAppContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public IActionResult OnGet()
        {
        ViewData["BranchId"] = new SelectList(_context.Set<Branch>(), "BranchId", "BranchName");
        ViewData["PrintingStationeryId"] = new SelectList(_context.Set<PrintingStationery>(), "PrintingStationeryId", "Name");
        ViewData["RecievedById"] = new SelectList(_context.Set<Employee>(), "EmployeeId", "EmployeeName");
        ViewData["StationeryOrderId"] = new SelectList(_context.StationeryOrder, "StationeryOrderId", "OrderNo");
        ViewData["StationeryOrderItemId"] = new SelectList(_context.Set<StationeryOrderItem>(), "StationeryOrderItemId", "StationeryOrderItemId");
            return Page();
        }

        [BindProperty]
        public StationeryOrderCompletion StationeryOrderCompletion { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.StationeryOrderCompletion == null || StationeryOrderCompletion == null)
            {
                return Page();
            }
            if (StationeryOrderCompletion.File != null && (StationeryOrderCompletion.File.Length > 0))
            {
                var uploads = Path.Combine(_environment.WebRootPath, "wwwroot/Files");
                var filePath = Path.Combine(uploads, (StationeryOrderCompletion.File.FileName));

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await (StationeryOrderCompletion.File.CopyToAsync(fileStream));
                }

                StationeryOrderCompletion.FilePath = "/uploads/" + StationeryOrderCompletion.File.FileName;
            }

            _context.StationeryOrderCompletion.Add(StationeryOrderCompletion);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
