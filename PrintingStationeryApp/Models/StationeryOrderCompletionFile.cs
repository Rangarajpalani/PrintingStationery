using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PrintingStationeryApp.Models
{
    public class StationeryOrderCompletionFile
    {
        [Key]
        public int StationeryOrderCompletionFileId { get; set; }

        public StationeryOrderCompletion? StationeryOrderCompletion { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Created On")]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        [Display(Name = "File Name")]
        public string FileName { get; set; } = string.Empty;
        public string BlobName { get; set; } = string.Empty;
        public string Uri { get; set; } = String.Empty;

        public DocumentType DocumentType { get; set; }

        [Display(Name = "Tenant")]
        public string? TenantId { get; set; }
        public bool IsDeleted { get; set; }

        [NotMapped]
        public IFormFile? File { get; set; }
    }
}

