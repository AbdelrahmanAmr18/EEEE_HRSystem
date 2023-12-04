using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EEEE_Domain.Models
{
    [Table("Company")]
    public class Company
    {
        [Required]
        public int Id{ get; set; }
		
        [Required]
        public string Name { get; set; }=string.Empty;
        public string ArabicName { get; set; }=string.Empty;
        
		public string PhoneNumber { get; set; } = string.Empty;
		public string MobileNumber { get; set; } = string.Empty;
        
        [Required]
        public string Email { get; set; } = string.Empty;
        public string Fax { get; set; } = string.Empty;

        public string Description { get; set; }=string.Empty;

        public virtual ICollection<Branch> Branches { get; set; }
        = new HashSet<Branch>();

    }
}
