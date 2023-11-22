using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EEEE_Domain.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public virtual ICollection<Level> Levels { get; set; }
        = new HashSet<Level>();

        public virtual Department Department { get; set; }

        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }
    }
}
