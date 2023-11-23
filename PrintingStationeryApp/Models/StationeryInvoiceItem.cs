using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrintingStationeryApp.Models
{
    public class StationeryInvoiceItem
    {
        [Key]
        public int StationeryInvoiceItemId { get; set; }
        public StationeryInvoice? StationeryInvoice { get; set; }        
        public StationeryOrderItem? StationeryOrderItem { get; set; }
        public StationeryOrder? StationeryOrder { get; set; }
        public PrintingStationery? PrintingStationery { get; set; }

        [Display(Name = "From Stationery No")]
        public int? FromStationeryNo { get; set; }
        [Display(Name = "To Stationery No")]
        public int? ToStationeryNo { get; set; }

        public int? NoOfBooks { get; set; }

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
        [Display(Name = "Grand Total")]
        public decimal GrandTotal { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Comments { get; set; }

        [Display(Name = "Is Deleted")]
        public bool IsDeleted { get; set; }

        public string? TenantId { get; set; }

    }

}
