using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EEEE_Domain.Models
{
    public enum Gender
    {
        F=1,
        M=2
    }

    [Table("Employee")]
    public class Employee
    {

        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; } = string.Empty;
        public int? Age { set; get; }
        public Gender? Gender { set; get; }
        public DateTime? DateOfBirth { set; get; }
        
        [Required]
        public string Address { set; get; } = string.Empty;
        
        [MaxLength(350)]
        public string ArabicAddress { set; get; } = string.Empty;
        public string City { set; get; } = string.Empty;
        public string Country { set; get; } = string.Empty;
        //public string PostalCode { get; set; } = string.Empty;
        
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;
        
        [Required]
        public string EmargancyContact { get; set; } = string.Empty;
        
        /*should be deleted*/
        //public decimal GrossSalary { set; get; }
        //public decimal? Tax { get; set; }
        //public decimal NetSalary { get; set; }
        //public decimal? Appraisal { get; set; }
        //public decimal? Deduction { get; set; }
        /**/
        
        [Required]
        public string Email { get; set; } = string.Empty;

        /*the relationship and navigation property */
        [JsonIgnore]
        [ForeignKey(nameof(Level))]
        public int? LevelId { get; set; }
        public virtual Level? Level { get; set; }

        /*self relationship */
        [ForeignKey(nameof(Manager))]
        public int? ManagerId { get; set; }
        [JsonIgnore]
        public virtual Employee? Manager { set; get; }
        public virtual ICollection<Excuses> Employees { get; set; } = new HashSet<Excuses>();

    }
}
