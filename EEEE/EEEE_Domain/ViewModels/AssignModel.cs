using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEEE_Domain.ViewModels
{
    public class AssignModel
    {
        [Required]
        public string UserToAssign { get; set; } = string.Empty;
    }
}
