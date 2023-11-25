using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PrintingStationeryApp.Data;
using PrintingStationeryApp.Models;

namespace PrintingStationeryApp.Pages.StationeryOrders
{
    public class CreateModel : PageModel
    {
        private readonly PrintingStationeryApp.Data.PrintingStationeryAppContext _context;

        public CreateModel(PrintingStationeryApp.Data.PrintingStationeryAppContext context)
        {
            _context = context;
            StationeryOrderItems = new List<StationeryOrderItem> { new StationeryOrderItem() };

        }

        [BindProperty]
        public StationeryOrder StationeryOrder { get; set; } = default!;

        [BindProperty]
        public List<StationeryOrderItem> StationeryOrderItems { get; set; }


        public IActionResult OnGet()
        {
        ViewData["ApprovedById"] = new SelectList(_context.Set<Employee>(), "EmployeeId", "EmployeeName");
        ViewData["BranchId"] = new SelectList(_context.Set<Branch>(), "BranchId", "BranchName");
        ViewData["OrderById"] = new SelectList(_context.Set<Employee>(), "EmployeeId", "EmployeeName");
        ViewData["PrintingCompanyId"] = new SelectList(_context.Set<Company>(), "CompanyId", "CompanyName");


            StationeryOrderItems = new List<StationeryOrderItem>{ new StationeryOrderItem() };
            


            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.StationeryOrder == null || StationeryOrder == null)
            {
                return Page();
            }

            _context.StationeryOrder.Add(StationeryOrder);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
