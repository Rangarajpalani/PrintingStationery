using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrintingStationeryApp.Models
{
    public class StationeryOrder
    {
        [Key]
        public int StationeryOrderId { get; set; }

        [Display(Name = "Order No")]
        public int OrderNo { get; set; }

        [Display(Name = "Order No")]
        public string? OrderNoInString { get; set; } //BranchCode/OrderNo/Year

        [ForeignKey("BranchId")]
        public int? BranchId { get; set; }
        public Branch? Branch { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Completion Date")]
        public DateTime? CompletionDate { get; set; }

        [ForeignKey(" PrintingCompanyId")]
        public int? PrintingCompanyId { get; set; }
        public Company? PrintingCompany { get; set; }

        [ForeignKey("OrderById")]
        [Display(Name = "Order By")]
        public int? OrderById { get; set; }
        [Display(Name = "Order By")]
        public Employee? OrderBy { get; set; }
        
        [Display(Name = "Approval State")]
        public ApprovalState OrderStatus { get; set; }

        [Display(Name = "Is Completed")]
        public bool IsCompleted { get; set; }   // To state whether the order has been completed and all the stationeries are delivered to Vikas

        [ForeignKey("ApprovedById")]
        [Display(Name = "Approved By")]
        public int? ApprovedById { get; set; }
        [Display(Name = "Approved By")]
        public Employee? ApprovedBy { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Approved On")]
        public DateTime? ApprovedOn { get; set; }

        public string? TenantId { get; set; }

        [Display(Name = "Is Deleted")]
        public bool IsDeleted { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Comments { get; set; }

        public List<StationeryOrderItem>? StationeryOrderItems { get; set; } =new List<StationeryOrderItem>();

        //public List<StationeryOrderCompletion>? StationeryOrderCompletions { get; set; }
        //public List<StationeryPrinterInvoice>? StationeryPrinterInvoices { get; set; }
        //public List<StationeryOrderCompletion>? StationeryOrderCompletions { get; set; }
        //public List<StationeryOrderWithCompletion>? StationeryOrderWithCompletions { get; set; }
        //public List<StationeryOrderWithInvoice>? StationeryOrderWithInvoices { get; set; }

    }
}
