using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrintingStationeryApp.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    ApplicationUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.ApplicationUserId);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "PrintingStationeries",
                columns: table => new
                {
                    PrintingStationeryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsNumbered = table.Column<bool>(type: "bit", nullable: false),
                    IsWithCarbon = table.Column<bool>(type: "bit", nullable: false),
                    IsContinuos = table.Column<bool>(type: "bit", nullable: false),
                    NoOfPagesInOneBook = table.Column<int>(type: "int", nullable: true),
                    NoOfCopies = table.Column<int>(type: "int", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrintingStationeries", x => x.PrintingStationeryId);
                });

            migrationBuilder.CreateTable(
                name: "VoucherDatas",
                columns: table => new
                {
                    VoucherDataId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoucherDatas = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoucherDatas", x => x.VoucherDataId);
                });

            migrationBuilder.CreateTable(
                name: "StationeryOrder",
                columns: table => new
                {
                    StationeryOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNo = table.Column<int>(type: "int", nullable: false),
                    OrderNoInString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PrintingCompanyId = table.Column<int>(type: "int", nullable: true),
                    OrderById = table.Column<int>(type: "int", nullable: true),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedById = table.Column<int>(type: "int", nullable: true),
                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationeryOrder", x => x.StationeryOrderId);
                    table.ForeignKey(
                        name: "FK_StationeryOrder_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_StationeryOrder_Companies_PrintingCompanyId",
                        column: x => x.PrintingCompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_StationeryOrder_Employees_ApprovedById",
                        column: x => x.ApprovedById,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_StationeryOrder_Employees_OrderById",
                        column: x => x.OrderById,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.CreateTable(
                name: "StationeryQuotes",
                columns: table => new
                {
                    StationeryQuoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrintingStationeryId = table.Column<int>(type: "int", nullable: false),
                    QuoteNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuotedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuotePerCopyPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    QuotePerBookPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    ApprovedPerCopyPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    ApprovedPerBookPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    MinmumOrderQuantity = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalState = table.Column<int>(type: "int", nullable: false),
                    ApprovedById = table.Column<int>(type: "int", nullable: true),
                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationeryQuotes", x => x.StationeryQuoteId);
                    table.ForeignKey(
                        name: "FK_StationeryQuotes_ApplicationUsers_ApprovedById",
                        column: x => x.ApprovedById,
                        principalTable: "ApplicationUsers",
                        principalColumn: "ApplicationUserId");
                    table.ForeignKey(
                        name: "FK_StationeryQuotes_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_StationeryQuotes_PrintingStationeries_PrintingStationeryId",
                        column: x => x.PrintingStationeryId,
                        principalTable: "PrintingStationeries",
                        principalColumn: "PrintingStationeryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StationeryInvoices",
                columns: table => new
                {
                    StationeryInvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrinterInvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoicedById = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    IGSTAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CGSTAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    SGSTAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    OtherCharges = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    RoundOff = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    GrandTotal = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    IsFullyPaid = table.Column<bool>(type: "bit", nullable: false),
                    PreparedById = table.Column<int>(type: "int", nullable: true),
                    ApprovalState = table.Column<int>(type: "int", nullable: true),
                    ApprovedById = table.Column<int>(type: "int", nullable: true),
                    VoucherDataId = table.Column<int>(type: "int", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationeryInvoices", x => x.StationeryInvoiceId);
                    table.ForeignKey(
                        name: "FK_StationeryInvoices_ApplicationUsers_ApprovedById",
                        column: x => x.ApprovedById,
                        principalTable: "ApplicationUsers",
                        principalColumn: "ApplicationUserId");
                    table.ForeignKey(
                        name: "FK_StationeryInvoices_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StationeryInvoices_Companies_InvoicedById",
                        column: x => x.InvoicedById,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StationeryInvoices_Employees_PreparedById",
                        column: x => x.PreparedById,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_StationeryInvoices_VoucherDatas_VoucherDataId",
                        column: x => x.VoucherDataId,
                        principalTable: "VoucherDatas",
                        principalColumn: "VoucherDataId");
                });

            migrationBuilder.CreateTable(
                name: "StationeryOrderItems",
                columns: table => new
                {
                    StationeryOrderItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StationeryOrderId = table.Column<int>(type: "int", nullable: true),
                    PrintingStationeryId = table.Column<int>(type: "int", nullable: true),
                    FromStationeryNo = table.Column<int>(type: "int", nullable: true),
                    ToStationeryNo = table.Column<int>(type: "int", nullable: true),
                    NoOfBooks = table.Column<int>(type: "int", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationeryOrderItems", x => x.StationeryOrderItemId);
                    table.ForeignKey(
                        name: "FK_StationeryOrderItems_PrintingStationeries_PrintingStationeryId",
                        column: x => x.PrintingStationeryId,
                        principalTable: "PrintingStationeries",
                        principalColumn: "PrintingStationeryId");
                    table.ForeignKey(
                        name: "FK_StationeryOrderItems_StationeryOrder_StationeryOrderId",
                        column: x => x.StationeryOrderId,
                        principalTable: "StationeryOrder",
                        principalColumn: "StationeryOrderId");
                });

            migrationBuilder.CreateTable(
                name: "StationeryInvoiceFiles",
                columns: table => new
                {
                    StationeryInvoiceFileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StationeryInvoiceId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlobName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentType = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationeryInvoiceFiles", x => x.StationeryInvoiceFileId);
                    table.ForeignKey(
                        name: "FK_StationeryInvoiceFiles_StationeryInvoices_StationeryInvoiceId",
                        column: x => x.StationeryInvoiceId,
                        principalTable: "StationeryInvoices",
                        principalColumn: "StationeryInvoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StationeryInvoiceItems",
                columns: table => new
                {
                    StationeryInvoiceItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StationeryInvoiceId = table.Column<int>(type: "int", nullable: true),
                    StationeryOrderItemId = table.Column<int>(type: "int", nullable: true),
                    StationeryOrderId = table.Column<int>(type: "int", nullable: true),
                    PrintingStationeryId = table.Column<int>(type: "int", nullable: true),
                    FromStationeryNo = table.Column<int>(type: "int", nullable: true),
                    ToStationeryNo = table.Column<int>(type: "int", nullable: true),
                    NoOfBooks = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    IGSTAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CGSTAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    SGSTAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    OtherCharges = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    GrandTotal = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationeryInvoiceItems", x => x.StationeryInvoiceItemId);
                    table.ForeignKey(
                        name: "FK_StationeryInvoiceItems_PrintingStationeries_PrintingStationeryId",
                        column: x => x.PrintingStationeryId,
                        principalTable: "PrintingStationeries",
                        principalColumn: "PrintingStationeryId");
                    table.ForeignKey(
                        name: "FK_StationeryInvoiceItems_StationeryInvoices_StationeryInvoiceId",
                        column: x => x.StationeryInvoiceId,
                        principalTable: "StationeryInvoices",
                        principalColumn: "StationeryInvoiceId");
                    table.ForeignKey(
                        name: "FK_StationeryInvoiceItems_StationeryOrderItems_StationeryOrderItemId",
                        column: x => x.StationeryOrderItemId,
                        principalTable: "StationeryOrderItems",
                        principalColumn: "StationeryOrderItemId");
                    table.ForeignKey(
                        name: "FK_StationeryInvoiceItems_StationeryOrder_StationeryOrderId",
                        column: x => x.StationeryOrderId,
                        principalTable: "StationeryOrder",
                        principalColumn: "StationeryOrderId");
                });

            migrationBuilder.CreateTable(
                name: "StationeryOrderCompletion",
                columns: table => new
                {
                    StationeryOrderCompletionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StationeryOrderItemId = table.Column<int>(type: "int", nullable: true),
                    StationeryOrderId = table.Column<int>(type: "int", nullable: true),
                    RecievedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    PrintingStationeryId = table.Column<int>(type: "int", nullable: true),
                    FromStationeryNo = table.Column<int>(type: "int", nullable: true),
                    ToStationeryNo = table.Column<int>(type: "int", nullable: true),
                    NoOfBooks = table.Column<int>(type: "int", nullable: true),
                    RecievedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationeryOrderCompletion", x => x.StationeryOrderCompletionId);
                    table.ForeignKey(
                        name: "FK_StationeryOrderCompletion_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_StationeryOrderCompletion_Employees_RecievedById",
                        column: x => x.RecievedById,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_StationeryOrderCompletion_PrintingStationeries_PrintingStationeryId",
                        column: x => x.PrintingStationeryId,
                        principalTable: "PrintingStationeries",
                        principalColumn: "PrintingStationeryId");
                    table.ForeignKey(
                        name: "FK_StationeryOrderCompletion_StationeryOrderItems_StationeryOrderItemId",
                        column: x => x.StationeryOrderItemId,
                        principalTable: "StationeryOrderItems",
                        principalColumn: "StationeryOrderItemId");
                    table.ForeignKey(
                        name: "FK_StationeryOrderCompletion_StationeryOrder_StationeryOrderId",
                        column: x => x.StationeryOrderId,
                        principalTable: "StationeryOrder",
                        principalColumn: "StationeryOrderId");
                });

            migrationBuilder.CreateTable(
                name: "StationeryOrderCompletionFiles",
                columns: table => new
                {
                    StationeryOrderCompletionFileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StationeryOrderCompletionId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlobName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentType = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationeryOrderCompletionFiles", x => x.StationeryOrderCompletionFileId);
                    table.ForeignKey(
                        name: "FK_StationeryOrderCompletionFiles_StationeryOrderCompletion_StationeryOrderCompletionId",
                        column: x => x.StationeryOrderCompletionId,
                        principalTable: "StationeryOrderCompletion",
                        principalColumn: "StationeryOrderCompletionId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_StationeryInvoiceFiles_StationeryInvoiceId",
                table: "StationeryInvoiceFiles",
                column: "StationeryInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryInvoiceItems_PrintingStationeryId",
                table: "StationeryInvoiceItems",
                column: "PrintingStationeryId");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryInvoiceItems_StationeryInvoiceId",
                table: "StationeryInvoiceItems",
                column: "StationeryInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryInvoiceItems_StationeryOrderId",
                table: "StationeryInvoiceItems",
                column: "StationeryOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryInvoiceItems_StationeryOrderItemId",
                table: "StationeryInvoiceItems",
                column: "StationeryOrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryInvoices_ApprovedById",
                table: "StationeryInvoices",
                column: "ApprovedById");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryInvoices_BranchId",
                table: "StationeryInvoices",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryInvoices_InvoicedById",
                table: "StationeryInvoices",
                column: "InvoicedById");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryInvoices_PreparedById",
                table: "StationeryInvoices",
                column: "PreparedById");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryInvoices_VoucherDataId",
                table: "StationeryInvoices",
                column: "VoucherDataId");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryOrder_ApprovedById",
                table: "StationeryOrder",
                column: "ApprovedById");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryOrder_BranchId",
                table: "StationeryOrder",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryOrder_OrderById",
                table: "StationeryOrder",
                column: "OrderById");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryOrder_PrintingCompanyId",
                table: "StationeryOrder",
                column: "PrintingCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryOrderCompletion_BranchId",
                table: "StationeryOrderCompletion",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryOrderCompletion_PrintingStationeryId",
                table: "StationeryOrderCompletion",
                column: "PrintingStationeryId");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryOrderCompletion_RecievedById",
                table: "StationeryOrderCompletion",
                column: "RecievedById");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryOrderCompletion_StationeryOrderId",
                table: "StationeryOrderCompletion",
                column: "StationeryOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryOrderCompletion_StationeryOrderItemId",
                table: "StationeryOrderCompletion",
                column: "StationeryOrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryOrderCompletionFiles_StationeryOrderCompletionId",
                table: "StationeryOrderCompletionFiles",
                column: "StationeryOrderCompletionId");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryOrderItems_PrintingStationeryId",
                table: "StationeryOrderItems",
                column: "PrintingStationeryId");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryOrderItems_StationeryOrderId",
                table: "StationeryOrderItems",
                column: "StationeryOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryQuotes_ApprovedById",
                table: "StationeryQuotes",
                column: "ApprovedById");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryQuotes_BranchId",
                table: "StationeryQuotes",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_StationeryQuotes_PrintingStationeryId",
                table: "StationeryQuotes",
                column: "PrintingStationeryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StationeryInvoiceFiles");

            migrationBuilder.DropTable(
                name: "StationeryInvoiceItems");

            migrationBuilder.DropTable(
                name: "StationeryOrderCompletionFiles");

            migrationBuilder.DropTable(
                name: "StationeryQuotes");

            migrationBuilder.DropTable(
                name: "StationeryInvoices");

            migrationBuilder.DropTable(
                name: "StationeryOrderCompletion");

            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "VoucherDatas");

            migrationBuilder.DropTable(
                name: "StationeryOrderItems");

            migrationBuilder.DropTable(
                name: "PrintingStationeries");

            migrationBuilder.DropTable(
                name: "StationeryOrder");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
