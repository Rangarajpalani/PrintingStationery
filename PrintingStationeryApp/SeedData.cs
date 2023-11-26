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
                if (context == null || context.Employees == null)
                {
                    context.Employees.AddRange(
                new Employee
                {
                    EmployeeName = "Person1",

                });

                    context.SaveChanges();
                }
                if (context.PrintingStationeries == null)
                {
                    context.PrintingStationeries.AddRange(new PrintingStationery
                    {  
                       Name="Company1",Description="something",IsNumbered=true,IsDeleted=true,
                       IsContinuos=true,NoOfPagesInOneBook=364,NoOfCopies=4,TenantId="2",Comments="text",IsActive=true,IsWithCarbon=true
                    });
                    context.SaveChanges();

                }
             }
                
        }
    }
}
