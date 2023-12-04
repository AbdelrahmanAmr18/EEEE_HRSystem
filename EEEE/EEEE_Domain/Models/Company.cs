using System.ComponentModel.DataAnnotations;

namespace EEEE_Domain.Models
{
    public class Company
    {
        public int Id{ get; set; }
		[Required]
        public string Name { get; set; }=string.Empty;
        [RegularExpression(@"^\+?[0-9\s.-]+$")]
		public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
           ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;
        public string Fax { get; set; } = string.Empty;

        public string WebsiteURL { get; set; } = string.Empty;
        public string Description { get; set; }=string.Empty;


        public virtual ICollection<Branch> Branches { get; set; }
        = new HashSet<Branch>();


    }
}
