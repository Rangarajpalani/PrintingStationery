using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrintingStationeryApp.Data;
using PrintingStationeryApp.Models;

namespace PrintingStationeryApp.Pages.StationeryOrderCompletions
{
    public class EditModel : PageModel
    {
        private readonly PrintingStationeryApp.Data.PrintingStationeryAppContext _context;

        public EditModel(PrintingStationeryApp.Data.PrintingStationeryAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public StationeryOrderCompletion StationeryOrderCompletion { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.StationeryOrderCompletion == null)
            {
                return NotFound();
            }

            var stationeryordercompletion =  await _context.StationeryOrderCompletion
                .Include(s => s.Branch)
                .Include(s => s.PrintingStationery)
                .Include(s => s.RecievedBy)
                .Include(s => s.StationeryOrder)
                .Include(s => s.StationeryOrderItem).FirstOrDefaultAsync(m => m.StationeryOrderCompletionId == id);
            if (stationeryordercompletion == null)
            {
                return NotFound();
            }
            StationeryOrderCompletion = stationeryordercompletion;
           ViewData["BranchId"] = new SelectList(_context.Set<Branch>(), "BranchId", "BranchName");
           ViewData["PrintingStationeryId"] = new SelectList(_context.Set<PrintingStationery>(), "PrintingStationeryId", "Name");
           ViewData["RecievedById"] = new SelectList(_context.Set<Employee>(), "EmployeeId", "EmployeeName");
           ViewData["StationeryOrderId"] = new SelectList(_context.StationeryOrder, "StationeryOrderId", "OrderNo");
           ViewData["StationeryOrderItemId"] = new SelectList(_context.Set<StationeryOrderItem>(), "StationeryOrderItemId", "CompletionDate");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(StationeryOrderCompletion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StationeryOrderCompletionExists(StationeryOrderCompletion.StationeryOrderCompletionId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StationeryOrderCompletionExists(int id)
        {
          return (_context.StationeryOrderCompletion?.Any(e => e.StationeryOrderCompletionId == id)).GetValueOrDefault();
        }
    }
}
