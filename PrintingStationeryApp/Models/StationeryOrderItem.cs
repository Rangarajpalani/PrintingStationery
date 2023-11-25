using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrintingStationeryApp.Models
{
    public class StationeryOrderItem
    {
        [Key]
        public int StationeryOrderItemId { get; set; }

        [ForeignKey("StationeryOrderId")]
        public int? StationeryOrderId { get; set; }
        public StationeryOrder? StationeryOrder { get; set; }

        [ForeignKey("PrintingStationeryId")]
        public int? PrintingStationeryId { get; set; }
        public PrintingStationery? PrintingStationery { get; set; }

        [Display(Name = "From Stationery No")]
        public int? FromStationeryNo { get; set; }
        [Display(Name = "To Stationery No")]
        public int? ToStationeryNo { get; set; }

        public int? NoOfBooks { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Comments { get; set; }

        public string? TenantId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Completion Date")]
        public DateTime? CompletionDate { get; set; }

        [Display(Name = "Is Deleted")]
        public bool IsDeleted { get; set; }

       // public List<StationeryOrderCompletion>? StationeryOrderCompletions { get; set; }
    }
}

