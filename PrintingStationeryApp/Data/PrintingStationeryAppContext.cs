using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrintingStationeryApp.Models;

namespace PrintingStationeryApp.Data
{
    public class PrintingStationeryAppContext : DbContext
    {
        public PrintingStationeryAppContext (DbContextOptions<PrintingStationeryAppContext> options)
            : base(options)
        {
        }

        public DbSet<PrintingStationeryApp.Models.StationeryOrder> StationeryOrder { get; set; } = default!;

        public DbSet<PrintingStationeryApp.Models.StationeryOrderCompletion> StationeryOrderCompletion { get; set; } = default!;

        public DbSet<PrintingStationeryApp.Models.ApplicationUser> ApplicationUsers { get; set; } = default!;

        public DbSet<PrintingStationeryApp.Models.Branch> Branches { get; set; } = default!;

        public DbSet<PrintingStationeryApp.Models.Company> Companies { get; set; } = default!;

        public DbSet<PrintingStationeryApp.Models.Employee> Employees { get; set; } = default!;

        public DbSet<PrintingStationeryApp.Models.PrintingStationery> PrintingStationeries { get; set; } = default!;

        public DbSet<PrintingStationeryApp.Models.StationeryInvoice> StationeryInvoices { get; set; } = default!;

        public DbSet<PrintingStationeryApp.Models.StationeryInvoiceFile> StationeryInvoiceFiles { get; set; } = default!;

        public DbSet<PrintingStationeryApp.Models.StationeryInvoiceItem> StationeryInvoiceItems { get; set; } = default!;

        public DbSet<PrintingStationeryApp.Models.StationeryOrderCompletionFile> StationeryOrderCompletionFiles { get; set; } = default!;

        public DbSet<PrintingStationeryApp.Models.StationeryOrderItem> StationeryOrderItems { get; set; } = default!;

        public DbSet<PrintingStationeryApp.Models.StationeryQuote> StationeryQuotes { get; set; } = default!;

        public DbSet<PrintingStationeryApp.Models.VoucherData> VoucherDatas { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StationeryOrder>()
                .HasMany(s => s.StationeryOrderItems)
                .WithOne(s => s.StationeryOrder);
            modelBuilder.Entity<StationeryOrderCompletion>()
                        .Property(x => x.StationeryOrderCompletionId)
                        .ValueGeneratedOnAdd();
            modelBuilder.Entity<StationeryOrder>()
                       .Property(x => x.StationeryOrderId)
                       .ValueGeneratedOnAdd();

            modelBuilder.Entity<Branch>().HasData(
            new Branch { BranchId= 1 ,BranchName = "Salem" },
            new Branch { BranchId = 2 , BranchName = "Madhurai" });

            modelBuilder.Entity<Company>().HasData(
            new Company { CompanyId= 1, CompanyName = "companyName1" });

            

            base.OnModelCreating(modelBuilder);
        }


    }
}
