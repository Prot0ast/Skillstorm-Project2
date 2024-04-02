using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [MaxLength(50, ErrorMessage = "First name cannot be longer than 50 characters")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [MaxLength(50, ErrorMessage = "Last name cannot be longer than 50 characters")]
        public string? LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set;}

        public string? FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        [Required]
        public string? CardType { get; set; }

        [Required]
        [StringLength(16, ErrorMessage = "Card Number must be 16 characters")]
        public string? CardNumber { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ExpirationDate { get; set; }

        [Required]
        public int? CCV { get; set; }

        public CustomerPlan? Plans { get; set; }
    }
}
