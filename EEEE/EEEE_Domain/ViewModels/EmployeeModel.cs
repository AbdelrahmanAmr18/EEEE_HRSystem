using EEEE_Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEEE_Domain.ViewModels
{
    public class EmployeeModel : Employee
    {
        [Required]
        public new string Name { get; set; } = string.Empty;
        public new  int? Age { set; get; }
        public new Gender? Gender { set; get; }

        public new DateTime? DateOfBirth { set; get; }

        [Required]
        public new string Address { set; get; } = string.Empty;
        

        [Required]
        public new  string ArabicAddress { set; get; } = string.Empty;

        public new  string PostalCode { get; set; } = string.Empty;   
        
        [Required]
        public new  string PhoneNumber { get; set; } = string.Empty;
        public new  string MobileNumber { get; set; } = string.Empty;

        [Required]
        public new  string EmargancyContact { get; set; } = string.Empty;
     
        [Required]
        public new string Email { get; set; } = string.Empty;


    }
}
