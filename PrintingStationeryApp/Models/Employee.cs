using System.ComponentModel.DataAnnotations;

namespace PrintingStationeryApp.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
    }
}
