using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TestEmployeeEF.Models
{
    [Table("Contractor", Schema = "dbo")]
    public class Contractor
    {
        [Key]
        [Required]
        public int ContractorId { get; set; }

      
        public DateTime? ContractDate { get; set; }

      
        public decimal? HourlyRate { get; set; }

      
        public string? ContractorState { get; set; }
    }
}
