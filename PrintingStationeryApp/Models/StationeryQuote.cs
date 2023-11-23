using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrintingStationeryApp.Models
{
    public class StationeryQuote
    {
        [Key]
        public int StationeryQuoteId { get; set; }

        [ForeignKey("PrintingStationeryId")]
        public int PrintingStationeryId { get; set; }
        public PrintingStationery? PrintingStationery { get; set; }

        public string? QuoteNo { get; set; }
        public string? ReferenceNo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Quoted On")]
        public DateTime QuotedOn { get; set; } = DateTime.UtcNow;

        [Column(TypeName = "decimal(18,4)")]
        public decimal? QuotePerCopyPrice { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? QuotePerBookPrice { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? ApprovedPerCopyPrice { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? ApprovedPerBookPrice { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? MinmumOrderQuantity { get; set; }

        [ForeignKey("BranchId ")]
        [Display(Name = "Branch")]
        public int? BranchId { get; set; }
        public Branch? Branch { get; set; }

        [Display(Name = "Tenant")]
        public string? TenantId { get; set; }

        [Display(Name = "Approval State")]
        public ApprovalState ApprovalState { get; set; }

        [ForeignKey("ApprovedById")]
        [Display(Name = "Approved By")]
        public int? ApprovedById { get; set; }
        [Display(Name = "Approved By")]
        public ApplicationUser? ApprovedBy { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Approved On")]
        public DateTime? ApprovedOn { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Comments { get; set; }

        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }

}

