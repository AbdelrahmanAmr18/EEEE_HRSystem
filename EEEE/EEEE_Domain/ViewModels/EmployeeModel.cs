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
        public  new Gener? Gener { set; get; }

        public  new DateTime? DateOfBirth { set; get; }

        [MaxLength(350)]
        [Required]
        public new string CurrentAddress { set; get; } = string.Empty;
        //***

        [Required]
        public new  string PerminentAddress { set; get; } = string.Empty;

        public new  string PostalCode { get; set; } = string.Empty;   [Required]
        [RegularExpression(@"^\+?[0-9\s.-]+$")]
        public new  string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public new  string EmargancyContact { get; set; } = string.Empty;
     

        public  new decimal NetSalary { get; set; }

     
        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
        ErrorMessage = "Invalid email address")]
        public new string Email { get; set; } = string.Empty;


    }
}
