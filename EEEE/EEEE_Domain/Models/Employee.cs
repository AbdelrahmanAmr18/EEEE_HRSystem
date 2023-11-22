using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EEEE_Domain.Models
{
    public enum Gener
    {
        F,
        M
    }
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public int? Age { set; get; }
        public Gener Gener { set; get; }

        public DateTime? DateOfBirth { set; get; }
        [MaxLength(350)]
        [Required]
        public string CurrentAddress { set; get; } = string.Empty;
        [MaxLength(350)]
        public string PerminentAddress { set; get; } = string.Empty;

        public string State { set; get; } = string.Empty;

        public string City { set; get; } = string.Empty;
        public string Country { set; get; } = string.Empty;

        public string PostalCode { get; set; } = string.Empty;
        [Required]
        [RegularExpression(@"^\+?[0-9\s.-]+$")]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public string EmargancyContact { get; set; } = string.Empty;
        public decimal GrossSalary { set; get; }
        public decimal? Tax { get; set; }
        public decimal NetSalary { get; set; }
        public decimal? Appraisal { get; set; }
        public decimal? Deduction { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
        ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;


        /*the relationship and navigation property */

        public virtual Level Level { get; set; }
        [ForeignKey(nameof(Level))]
        public int LevelId { get; set; }

        /*self relationship */
        [ForeignKey(nameof(Manager))]
        public int ManagerId { get; set; }
        public virtual Employee Manager { set; get; }



    }
}
