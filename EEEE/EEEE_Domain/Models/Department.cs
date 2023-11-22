using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EEEE_Domain.Models
{
    public class Department
    {
       
   

        public int Id { get; set; }
		[Required]
		public string Name { get; set; } = string.Empty;
        [RegularExpression(@"^\+?[0-9\s.-]+$")]
        public string PhoneNumber { get; set; } = string.Empty;
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
         ErrorMessage = "Invalid email address")]
        public string Email { get; set; }=string.Empty;
		public string Description { get; set; } = string.Empty;

        public virtual ICollection<Position> Positions { get; set; }
        = new HashSet<Position>();

        public virtual Branch Branch { get; set; }

        [ForeignKey(nameof(Branch))]
        public int BranchId { get; set; }

    }
}
