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
    public class IndexModel : PageModel
    {
        private readonly PrintingStationeryApp.Data.PrintingStationeryAppContext _context;

        public IndexModel(PrintingStationeryApp.Data.PrintingStationeryAppContext context)
        {
            _context = context;
        }

        public IList<StationeryOrder> StationeryOrder { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.StationeryOrder != null)
            {
                StationeryOrder = await _context.StationeryOrder
                .Include(s => s.ApprovedBy)
                .Include(s => s.Branch)
                .Include(s => s.OrderBy)
                .Include(s => s.PrintingCompany).ToListAsync();
            }
        }
    }
}
