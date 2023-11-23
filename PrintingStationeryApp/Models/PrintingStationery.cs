﻿using System.ComponentModel.DataAnnotations;

namespace PrintingStationeryApp.Models
{
    public class PrintingStationery
    {
        [Key]
        public int PrintingStationeryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsNumbered { get; set; }
        public bool IsWithCarbon { get; set; }
        public bool IsContinuos { get; set; }   // If Continous pages or printed in books
        public int? NoOfPagesInOneBook { get; set; }
        public int? NoOfCopies { get; set; }    // No of duplicates for a single page

        [Display(Name = "Tenant")]
        public string? TenantId { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Comments { get; set; }

        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

    }
}
