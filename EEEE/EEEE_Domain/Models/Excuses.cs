using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEEE_Domain.Models
{
    public enum ExcuseStatus
    {
        Pending = 1,
        Approved = 2,
        Declained = 3
    }
    public class Excuses
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual Employee? Employee { get; set; }

        [ForeignKey(nameof(Employee))]
        public int? EmployeeId { get; set; }

        public int ExcuseStatus { get; set; }
        public string ExcuseStatusComment { get; set; } = string.Empty;
    }
}
