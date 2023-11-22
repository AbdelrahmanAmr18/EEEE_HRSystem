using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EEEE_Domain.Models
{
    public class Branch
    {
     
        public int Id { get; set; }
		[Required]
        [MaxLength(500)]
        public string Name { get; set; }=string.Empty;
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
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
           ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;
        public string Fax { get; set; } = string.Empty;

        public string WebsiteURL { get; set; } = string.Empty;


        public string Description { get; set; } = string.Empty;

        public virtual Company Company{ get; set; }
        [ForeignKey(nameof(Company))]
        public int CompanyId { get; set; }

        public virtual ICollection<Department> Departments { get; set; } = new HashSet<Department>();

    }
}
