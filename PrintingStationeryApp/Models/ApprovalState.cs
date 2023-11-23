using System.ComponentModel.DataAnnotations;

namespace PrintingStationeryApp.Models
{
    public enum ApprovalState
    {
        [Display(Name = "Pending")]
        Pending,
        [Display(Name = "Approved")]
        Approved,
        [Display(Name = " Rejected")]
        Rejected

    }
}
