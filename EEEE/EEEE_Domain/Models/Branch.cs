using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EEEE_Domain.Models
{
    [Table("Branch")]
    public class Branch
    {
     
        [Required]
        public int Id { get; set; }
		
        [Required]
        public string Name { get; set; } = string.Empty;
        public string ArabicName { get; set; } = string.Empty;
		
        [Required]
        public string Address { set; get; } = string.Empty;
        
        public string ArabicAddress { set; get; } = string.Empty;
        public string City { set; get; } = string.Empty;
        public string Country { set; get; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty; /////////////// Ask Eng. Ehab

        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;
        
        [Required]
        public string Email { get; set; } = string.Empty;
        public string Fax { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        
        [ForeignKey(nameof(Company))]
        public int CompanyId { get; set; }
        public virtual Company Company{ get; set; }
        public virtual ICollection<Department> Departments { get; set; } = new HashSet<Department>();

    }
}
