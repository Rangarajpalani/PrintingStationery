﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrintingStationeryApp.Data;

#nullable disable

namespace PrintingStationeryApp.Migrations
{
    [DbContext(typeof(PrintingStationeryAppContext))]
    partial class PrintingStationeryAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PrintingStationeryApp.Models.ApplicationUser", b =>
                {
                    b.Property<int>("ApplicationUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationUserId"));

                    b.Property<string>("ApplicationUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApplicationUserId");

                    b.ToTable("ApplicationUsers");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.Branch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BranchId"));

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BranchId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyId"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.PrintingStationery", b =>
                {
                    b.Property<int>("PrintingStationeryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrintingStationeryId"));

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsContinuos")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNumbered")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWithCarbon")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NoOfCopies")
                        .HasColumnType("int");

                    b.Property<int?>("NoOfPagesInOneBook")
                        .HasColumnType("int");

                    b.Property<string>("TenantId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrintingStationeryId");

                    b.ToTable("PrintingStationeries");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.StationeryInvoice", b =>
                {
                    b.Property<int>("StationeryInvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StationeryInvoiceId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int?>("ApprovalState")
                        .HasColumnType("int");

                    b.Property<int?>("ApprovedById")
                        .HasColumnType("int");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<decimal>("CGSTAmount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("GrandTotal")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("IGSTAmount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InvoicedById")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFullyPaid")
                        .HasColumnType("bit");

                    b.Property<decimal>("OtherCharges")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("PaidAmount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int?>("PreparedById")
                        .HasColumnType("int");

                    b.Property<string>("PrinterInvoiceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("RoundOff")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("SGSTAmount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("TenantId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int?>("VoucherDataId")
                        .HasColumnType("int");

                    b.HasKey("StationeryInvoiceId");

                    b.HasIndex("ApprovedById");

                    b.HasIndex("BranchId");

                    b.HasIndex("InvoicedById");

                    b.HasIndex("PreparedById");

                    b.HasIndex("VoucherDataId");

                    b.ToTable("StationeryInvoices");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.StationeryInvoiceFile", b =>
                {
                    b.Property<int>("StationeryInvoiceFileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StationeryInvoiceFileId"));

                    b.Property<string>("BlobName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("DocumentType")
                        .HasColumnType("int");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("StationeryInvoiceId")
                        .HasColumnType("int");

                    b.Property<string>("TenantId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StationeryInvoiceFileId");

                    b.HasIndex("StationeryInvoiceId");

                    b.ToTable("StationeryInvoiceFiles");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.StationeryInvoiceItem", b =>
                {
                    b.Property<int>("StationeryInvoiceItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StationeryInvoiceItemId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("CGSTAmount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int?>("FromStationeryNo")
                        .HasColumnType("int");

                    b.Property<decimal>("GrandTotal")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("IGSTAmount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("NoOfBooks")
                        .HasColumnType("int");

                    b.Property<decimal>("OtherCharges")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int?>("PrintingStationeryId")
                        .HasColumnType("int");

                    b.Property<decimal>("SGSTAmount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int?>("StationeryInvoiceId")
                        .HasColumnType("int");

                    b.Property<int?>("StationeryOrderId")
                        .HasColumnType("int");

                    b.Property<int?>("StationeryOrderItemId")
                        .HasColumnType("int");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("TenantId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ToStationeryNo")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("StationeryInvoiceItemId");

                    b.HasIndex("PrintingStationeryId");

                    b.HasIndex("StationeryInvoiceId");

                    b.HasIndex("StationeryOrderId");

                    b.HasIndex("StationeryOrderItemId");

                    b.ToTable("StationeryInvoiceItems");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.StationeryOrder", b =>
                {
                    b.Property<int>("StationeryOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StationeryOrderId"));

                    b.Property<int?>("ApprovedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ApprovedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CompletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("OrderById")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderNo")
                        .HasColumnType("int");

                    b.Property<string>("OrderNoInString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<int?>("PrintingCompanyId")
                        .HasColumnType("int");

                    b.Property<string>("TenantId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StationeryOrderId");

                    b.HasIndex("ApprovedById");

                    b.HasIndex("BranchId");

                    b.HasIndex("OrderById");

                    b.HasIndex("PrintingCompanyId");

                    b.ToTable("StationeryOrder");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.StationeryOrderCompletion", b =>
                {
                    b.Property<int>("StationeryOrderCompletionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StationeryOrderCompletionId"));

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FromStationeryNo")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("NoOfBooks")
                        .HasColumnType("int");

                    b.Property<int?>("PrintingStationeryId")
                        .HasColumnType("int");

                    b.Property<int?>("RecievedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("RecievedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StationeryOrderId")
                        .HasColumnType("int");

                    b.Property<int?>("StationeryOrderItemId")
                        .HasColumnType("int");

                    b.Property<string>("TenantId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ToStationeryNo")
                        .HasColumnType("int");

                    b.HasKey("StationeryOrderCompletionId");

                    b.HasIndex("BranchId");

                    b.HasIndex("PrintingStationeryId");

                    b.HasIndex("RecievedById");

                    b.HasIndex("StationeryOrderId");

                    b.HasIndex("StationeryOrderItemId");

                    b.ToTable("StationeryOrderCompletion");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.StationeryOrderCompletionFile", b =>
                {
                    b.Property<int>("StationeryOrderCompletionFileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StationeryOrderCompletionFileId"));

                    b.Property<string>("BlobName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("DocumentType")
                        .HasColumnType("int");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("StationeryOrderCompletionId")
                        .HasColumnType("int");

                    b.Property<string>("TenantId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StationeryOrderCompletionFileId");

                    b.HasIndex("StationeryOrderCompletionId");

                    b.ToTable("StationeryOrderCompletionFiles");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.StationeryOrderItem", b =>
                {
                    b.Property<int>("StationeryOrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StationeryOrderItemId"));

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CompletionDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FromStationeryNo")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("NoOfBooks")
                        .HasColumnType("int");

                    b.Property<int?>("PrintingStationeryId")
                        .HasColumnType("int");

                    b.Property<int?>("StationeryOrderId")
                        .HasColumnType("int");

                    b.Property<string>("TenantId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ToStationeryNo")
                        .HasColumnType("int");

                    b.HasKey("StationeryOrderItemId");

                    b.HasIndex("PrintingStationeryId");

                    b.HasIndex("StationeryOrderId");

                    b.ToTable("StationeryOrderItems");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.StationeryQuote", b =>
                {
                    b.Property<int>("StationeryQuoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StationeryQuoteId"));

                    b.Property<int>("ApprovalState")
                        .HasColumnType("int");

                    b.Property<int?>("ApprovedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ApprovedOn")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("ApprovedPerBookPrice")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal?>("ApprovedPerCopyPrice")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal?>("MinmumOrderQuantity")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("PrintingStationeryId")
                        .HasColumnType("int");

                    b.Property<string>("QuoteNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("QuotePerBookPrice")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal?>("QuotePerCopyPrice")
                        .HasColumnType("decimal(18,4)");

                    b.Property<DateTime>("QuotedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReferenceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenantId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StationeryQuoteId");

                    b.HasIndex("ApprovedById");

                    b.HasIndex("BranchId");

                    b.HasIndex("PrintingStationeryId");

                    b.ToTable("StationeryQuotes");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.VoucherData", b =>
                {
                    b.Property<int>("VoucherDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VoucherDataId"));

                    b.Property<string>("VoucherDatas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VoucherDataId");

                    b.ToTable("VoucherDatas");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.StationeryInvoice", b =>
                {
                    b.HasOne("PrintingStationeryApp.Models.ApplicationUser", "ApprovedBy")
                        .WithMany()
                        .HasForeignKey("ApprovedById");

                    b.HasOne("PrintingStationeryApp.Models.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrintingStationeryApp.Models.Company", "InvoicedBy")
                        .WithMany()
                        .HasForeignKey("InvoicedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrintingStationeryApp.Models.Employee", "PreparedBy")
                        .WithMany()
                        .HasForeignKey("PreparedById");

                    b.HasOne("PrintingStationeryApp.Models.VoucherData", "VoucherData")
                        .WithMany()
                        .HasForeignKey("VoucherDataId");

                    b.Navigation("ApprovedBy");

                    b.Navigation("Branch");

                    b.Navigation("InvoicedBy");

                    b.Navigation("PreparedBy");

                    b.Navigation("VoucherData");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.StationeryInvoiceFile", b =>
                {
                    b.HasOne("PrintingStationeryApp.Models.StationeryInvoice", "StationeryInvoice")
                        .WithMany("StationeryInvoiceFiles")
                        .HasForeignKey("StationeryInvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StationeryInvoice");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.StationeryInvoiceItem", b =>
                {
                    b.HasOne("PrintingStationeryApp.Models.PrintingStationery", "PrintingStationery")
                        .WithMany()
                        .HasForeignKey("PrintingStationeryId");

                    b.HasOne("PrintingStationeryApp.Models.StationeryInvoice", "StationeryInvoice")
                        .WithMany("StationeryInvoiceItems")
                        .HasForeignKey("StationeryInvoiceId");

                    b.HasOne("PrintingStationeryApp.Models.StationeryOrder", "StationeryOrder")
                        .WithMany()
                        .HasForeignKey("StationeryOrderId");

                    b.HasOne("PrintingStationeryApp.Models.StationeryOrderItem", "StationeryOrderItem")
                        .WithMany()
                        .HasForeignKey("StationeryOrderItemId");

                    b.Navigation("PrintingStationery");

                    b.Navigation("StationeryInvoice");

                    b.Navigation("StationeryOrder");

                    b.Navigation("StationeryOrderItem");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.StationeryOrder", b =>
                {
                    b.HasOne("PrintingStationeryApp.Models.Employee", "ApprovedBy")
                        .WithMany()
                        .HasForeignKey("ApprovedById");

                    b.HasOne("PrintingStationeryApp.Models.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.HasOne("PrintingStationeryApp.Models.Employee", "OrderBy")
                        .WithMany()
                        .HasForeignKey("OrderById");

                    b.HasOne("PrintingStationeryApp.Models.Company", "PrintingCompany")
                        .WithMany()
                        .HasForeignKey("PrintingCompanyId");

                    b.Navigation("ApprovedBy");

                    b.Navigation("Branch");

                    b.Navigation("OrderBy");

                    b.Navigation("PrintingCompany");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.StationeryOrderCompletion", b =>
                {
                    b.HasOne("PrintingStationeryApp.Models.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.HasOne("PrintingStationeryApp.Models.PrintingStationery", "PrintingStationery")
                        .WithMany()
                        .HasForeignKey("PrintingStationeryId");

                    b.HasOne("PrintingStationeryApp.Models.Employee", "RecievedBy")
                        .WithMany()
                        .HasForeignKey("RecievedById");

                    b.HasOne("PrintingStationeryApp.Models.StationeryOrder", "StationeryOrder")
                        .WithMany("StationeryOrderCompletions")
                        .HasForeignKey("StationeryOrderId");

                    b.HasOne("PrintingStationeryApp.Models.StationeryOrderItem", "StationeryOrderItem")
                        .WithMany("StationeryOrderCompletions")
                        .HasForeignKey("StationeryOrderItemId");

                    b.Navigation("Branch");

                    b.Navigation("PrintingStationery");

                    b.Navigation("RecievedBy");

                    b.Navigation("StationeryOrder");

                    b.Navigation("StationeryOrderItem");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.StationeryOrderCompletionFile", b =>
                {
                    b.HasOne("PrintingStationeryApp.Models.StationeryOrderCompletion", "StationeryOrderCompletion")
                        .WithMany("Files")
                        .HasForeignKey("StationeryOrderCompletionId");

                    b.Navigation("StationeryOrderCompletion");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.StationeryOrderItem", b =>
                {
                    b.HasOne("PrintingStationeryApp.Models.PrintingStationery", "PrintingStationery")
                        .WithMany()
                        .HasForeignKey("PrintingStationeryId");

                    b.HasOne("PrintingStationeryApp.Models.StationeryOrder", "StationeryOrder")
                        .WithMany("StationeryOrderItems")
                        .HasForeignKey("StationeryOrderId");

                    b.Navigation("PrintingStationery");

                    b.Navigation("StationeryOrder");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.StationeryQuote", b =>
                {
                    b.HasOne("PrintingStationeryApp.Models.ApplicationUser", "ApprovedBy")
                        .WithMany()
                        .HasForeignKey("ApprovedById");

                    b.HasOne("PrintingStationeryApp.Models.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.HasOne("PrintingStationeryApp.Models.PrintingStationery", "PrintingStationery")
                        .WithMany()
                        .HasForeignKey("PrintingStationeryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApprovedBy");

                    b.Navigation("Branch");

                    b.Navigation("PrintingStationery");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.StationeryInvoice", b =>
                {
                    b.Navigation("StationeryInvoiceFiles");

                    b.Navigation("StationeryInvoiceItems");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.StationeryOrder", b =>
                {
                    b.Navigation("StationeryOrderCompletions");

                    b.Navigation("StationeryOrderItems");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.StationeryOrderCompletion", b =>
                {
                    b.Navigation("Files");
                });

            modelBuilder.Entity("PrintingStationeryApp.Models.StationeryOrderItem", b =>
                {
                    b.Navigation("StationeryOrderCompletions");
                });
#pragma warning restore 612, 618
        }
    }
}