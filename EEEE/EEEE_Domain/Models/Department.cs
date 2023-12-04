using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EEEE_Domain.Models
{
    [Table("Department")]
    public class Department
    {

        [Required]
        public int Id { get; set; }
		
        [Required]
		public string Name { get; set; } = string.Empty;
		public string ArabicName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;
        public string Email { get; set; }=string.Empty;
		public string Description { get; set; } = string.Empty;



        [ForeignKey(nameof(Branch))]
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual ICollection<Position> Positions { get; set; } = new HashSet<Position>();


        [ForeignKey(nameof(Parent))]
        public int? ParentId { get; set; }
        [JsonIgnore]
        public virtual Department? Parent { set; get; }


        public virtual ICollection<Level> Levels { get; set; } = new HashSet<Level>();


    }
}
