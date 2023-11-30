using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrintingStationeryApp.Data;
using PrintingStationeryApp.Models;

namespace PrintingStationeryApp.Pages.StationeryOrders
{
    public class DeleteModel : PageModel
    {
        private readonly PrintingStationeryApp.Data.PrintingStationeryAppContext _context;

        public DeleteModel(PrintingStationeryApp.Data.PrintingStationeryAppContext context)
        {
            _context = context;
        }

        [BindProperty]
      public StationeryOrder StationeryOrder { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.StationeryOrder == null)
            {
                return NotFound();
            }

            var stationeryorder = await _context.StationeryOrder.Include(s => s.ApprovedBy)
                .Include(s => s.Branch)
                .Include(s => s.OrderBy)
                .Include(s => s.PrintingCompany)
                .FirstOrDefaultAsync(m => m.StationeryOrderId == id);

            if (stationeryorder == null)
            {
                return NotFound();
            }
            else 
            {
                StationeryOrder = stationeryorder;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.StationeryOrder == null)
            {
                return NotFound();
            }
            var stationeryorder = await _context.StationeryOrder.FindAsync(id);

            if (stationeryorder != null)
            {
                StationeryOrder = stationeryorder;
                _context.StationeryOrder.Remove(StationeryOrder);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
