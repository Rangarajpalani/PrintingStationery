using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrintingStationeryApp.Models
{
    public class StationeryOrderCompletion
    {
        [Key]
        public int StationeryOrderCompletionId { get; set; }

        [ForeignKey("StationeryOrderItemId")]
        public int? StationeryOrderItemId { get; set; }
        public StationeryOrderItem? StationeryOrderItem { get; set; }

        [ForeignKey("StationeryOrderId")]
        public int? StationeryOrderId { get; set; }
        public StationeryOrder? StationeryOrder { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Recieved On")]
        public DateTime RecievedOn { get; set; } = DateTime.UtcNow;

        [ForeignKey("BranchId")]
        public int? BranchId { get; set; }
        public Branch? Branch { get; set; }

        [ForeignKey("PrintingStationeryId")]
        public int? PrintingStationeryId { get; set; }
        public PrintingStationery? PrintingStationery { get; set; }

        [Display(Name = "From Stationery No")]
        public int? FromStationeryNo { get; set; }

        [Display(Name = "To Stationery No")]
        public int? ToStationeryNo { get; set; }

        public int? NoOfBooks { get; set; }

        [ForeignKey("RecievedById ")]
        [Display(Name = "Recieved By")]
        public int? RecievedById { get; set; }
        [Display(Name = "Recieved By")]
        public Employee? RecievedBy { get; set; }

        [Display(Name = "Is Deleted")]
        public bool IsDeleted { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Comments { get; set; }

        public string? TenantId { get; set; }

        public List<StationeryOrderCompletionFile>? Files { get; set; }

        [NotMapped]
        public string FilePath { get; set; }
        [NotMapped]
        public IFormFile? File { get; set; }
        //public List<StationeryOrderWithCompletion>? StationeryOrderWithCompletions { get; set; }
    }

}

