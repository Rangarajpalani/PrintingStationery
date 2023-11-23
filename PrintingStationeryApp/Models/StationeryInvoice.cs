using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrintingStationeryApp.Models
{
    public class StationeryInvoice
    {
        [Key]
        public int StationeryInvoiceId { get; set; }

        public string? InvoiceNo { get; set; }
        public string? PrinterInvoiceNo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Invoice Date")]
        public DateTime InvoiceDate { get; set; } = DateTime.UtcNow;

        [Display(Name = "Branch")]
        public int BranchId { get; set; }
        public Branch? Branch { get; set; }

        [Display(Name = "Tenant")]
        public string? TenantId { get; set; }

        [Display(Name = "Invoiced By")]
        public int InvoicedById { get; set; }
        [Display(Name = "Invoiced By")]
        public Company? InvoicedBy { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        [Display(Name = "Amount")]
        public decimal Amount { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        [Display(Name = "Discount")]
        public decimal Discount { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        [Display(Name = "Sub Total")]
        public decimal SubTotal { get; set; }     // Just for report purpose

        [Column(TypeName = "decimal(18,4)")]
        [Display(Name = "IGST Amount")]
        public decimal IGSTAmount { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        [Display(Name = "CGST Amount")]
        public decimal CGSTAmount { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        [Display(Name = "SGST Amount")]
        public decimal SGSTAmount { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        [Display(Name = "Total")]
        public decimal Total { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        [Display(Name = "Other Charges")]
        public decimal OtherCharges { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        [Display(Name = "Round Off")]
        public decimal RoundOff { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        [Display(Name = "Grand Total")]
        public decimal GrandTotal { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        [Display(Name = "Paid Amount")]
        public decimal PaidAmount { get; set; }

        public bool IsFullyPaid { get; set; }

        //[Display(Name = "Package Charge")]
        //public decimal PerPackageCharge { get; set; }
        //[Display(Name = "Weight Charge")]
        //public decimal PerWeightCharge { get; set; }

        [Display(Name = "Prepared By")]
        public int? PreparedById { get; set; }
        [Display(Name = "Prepared By")]
        public Employee? PreparedBy { get; set; }

        [Display(Name = "Approval State")]
        public ApprovalState? ApprovalState { get; set; }

        [Display(Name = "Approved By")]
        public int? ApprovedById { get; set; }
        [Display(Name = "Approved By")]
        public ApplicationUser? ApprovedBy { get; set; }

        [ForeignKey("VoucherDataId")]
        public int? VoucherDataId { get; set; }        
        public VoucherData? VoucherData { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Comments { get; set; }

        public bool IsDeleted { get; set; }

        public List<StationeryInvoiceItem>? StationeryInvoiceItems { get; set; }
        public List<StationeryInvoiceFile>? StationeryInvoiceFiles { get; set; }
        //public List<StationeryOrderWithInvoice>? StationeryOrderWithInvoices { get; set; }

    }
}

