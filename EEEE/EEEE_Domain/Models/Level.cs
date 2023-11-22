using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EEEE_Domain.Models
{
    public class Level
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name{ get; set; }=string.Empty;

        public string Description { get; set; } = string.Empty;

        public virtual ICollection<Employee> Employees { get; set; }
        = new HashSet<Employee>();

        public virtual Position Position { get; set; }
        [ForeignKey(nameof(Position))]
        public int PositionId { get; set; }
    }
}
