using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestEmployeeEF.Models
{
    [Table("Employee", Schema = "dbo")]
    public class Employee
    {
        [Key]
        [Required]
        public int EmployeeId { get; set; }
        
        [Required]
        [Display(Name = "SSN")]
        public string SSN { get; set; }

        [Required]
        [Display(Name = "HireDate")]
        public DateTime HireDate { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

       
        [Display(Name = "Termination Date")]
        public DateTime? TerminationDate { get; set; }

        
        [Display(Name = "Annual Salary")]
        public decimal? AnnualSalary { get; set; }
    }
}
