using Microsoft.EntityFrameworkCore;
using PrintingStationeryApp.Data;
using PrintingStationeryApp.Models;

namespace PrintingStationeryApp
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PrintingStationeryAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PrintingStationeryAppContext>>()))
            {
                if (context == null || context.Branches == null)
                {
                    context.Branches.AddRange(new Branch { BranchName = "madhurai" });

                }
                
            }
        }
    }
}
