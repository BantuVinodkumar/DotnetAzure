using System.ComponentModel.DataAnnotations;

namespace CodeBasedEvaluation_06.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOJ { get; set; }
        public string Department { get; set; }
        public float Salary { get; set; }
        public string Location { get; set; }
        
    }
}
