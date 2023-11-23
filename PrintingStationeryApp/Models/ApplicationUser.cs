using System.ComponentModel.DataAnnotations;

namespace PrintingStationeryApp.Models
{
    public class ApplicationUser
    {
        [Key]
        public int ApplicationUserId { get; set; }

        public string ApplicationUserName { get; set; }
    }
}
