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

namespace PrintingStationeryApp.Pages.StationeryOrders
{
    public class EditModel : PageModel
    {
        private readonly PrintingStationeryApp.Data.PrintingStationeryAppContext _context;

        public EditModel(PrintingStationeryApp.Data.PrintingStationeryAppContext context)
        {
            _context = context;
            StationeryOrderItems = new List<StationeryOrderItem> { 
            new StationeryOrderItem() };
        }

        [BindProperty]
        public StationeryOrder StationeryOrder { get; set; } = default!;
        [BindProperty]
        public List<StationeryOrderItem> StationeryOrderItems { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.StationeryOrder == null)
            {
                return NotFound();
            }

            var stationeryorder =  await _context.StationeryOrder
                .Include(s => s.ApprovedBy)
                .Include(s => s.Branch)
                .Include(s => s.OrderBy)
                .Include(s => s.PrintingCompany)
                .Include(s => s.StationeryOrderItems).FirstOrDefaultAsync(m => m.StationeryOrderId == id);
            if (stationeryorder == null)
            {
                return NotFound();
            }
            StationeryOrder = stationeryorder;
           ViewData["ApprovedById"] = new SelectList(_context.Set<Employee>(), "EmployeeId", "EmployeeName");
           ViewData["BranchId"] = new SelectList(_context.Set<Branch>(), "BranchId", "BranchName");
           ViewData["OrderById"] = new SelectList(_context.Set<Employee>(), "EmployeeId", "EmployeeName");
           ViewData["PrintingCompanyId"] = new SelectList(_context.Set<Company>(), "CompanyId", "CompanyName");
           ViewData["PrintingStationeryId"] = new SelectList(_context.Set<PrintingStationery>(), "PrintingStationeryId", "Name");

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

            _context.Attach(StationeryOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StationeryOrderExists(StationeryOrder.StationeryOrderId))
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

        private bool StationeryOrderExists(int id)
        {
          return (_context.StationeryOrder?.Any(e => e.StationeryOrderId == id)).GetValueOrDefault();
        }
    }
}
