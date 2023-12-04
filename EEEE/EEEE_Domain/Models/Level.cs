using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EEEE_Domain.Models
{
    [Table("Level")]
    public class Level
    {
        [Key]
        public int Id { get; set; }
 
        [Required]
        public string Name{ get; set; }=string.Empty;
        public string ArabicName { get; set; }=string.Empty;
        public string Description { get; set; } = string.Empty;


        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
