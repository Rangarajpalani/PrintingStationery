using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrintingStationeryApp.Data;
using PrintingStationeryApp.Models;

namespace PrintingStationeryApp.Pages.StationeryOrderCompletions
{
    public class IndexModel : PageModel
    {
        private readonly PrintingStationeryApp.Data.PrintingStationeryAppContext _context;

        public IndexModel(PrintingStationeryApp.Data.PrintingStationeryAppContext context)
        {
            _context = context;
        }

        public IList<StationeryOrderCompletion> StationeryOrderCompletion { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.StationeryOrderCompletion != null)
            {
                StationeryOrderCompletion = await _context.StationeryOrderCompletion
                .Include(s => s.Branch)
                .Include(s => s.PrintingStationery)
                .Include(s => s.RecievedBy)
                .Include(s => s.StationeryOrder)
                .Include(s => s.StationeryOrderItem).ToListAsync();
            }
        }
    }
}
