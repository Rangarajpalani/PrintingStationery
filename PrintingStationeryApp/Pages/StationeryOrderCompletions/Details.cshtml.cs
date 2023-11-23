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
    public class DetailsModel : PageModel
    {
        private readonly PrintingStationeryApp.Data.PrintingStationeryAppContext _context;

        public DetailsModel(PrintingStationeryApp.Data.PrintingStationeryAppContext context)
        {
            _context = context;
        }

      public StationeryOrderCompletion StationeryOrderCompletion { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.StationeryOrderCompletion == null)
            {
                return NotFound();
            }

            var stationeryordercompletion = await _context.StationeryOrderCompletion.FirstOrDefaultAsync(m => m.StationeryOrderCompletionId == id);
            if (stationeryordercompletion == null)
            {
                return NotFound();
            }
            else 
            {
                StationeryOrderCompletion = stationeryordercompletion;
            }
            return Page();
        }
    }
}
