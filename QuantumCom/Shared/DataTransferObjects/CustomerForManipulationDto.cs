using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record CustomerForManipulationDto
    {
        [Required(ErrorMessage = "First name is required")]
        [MaxLength(50, ErrorMessage = "First name cannot be longer than 50 characters")]
        public string? FirstName { get; init; }

        [Required(ErrorMessage = "Last name is required")]
        [MaxLength(50, ErrorMessage = "Last name cannot be longer than 50 characters")]
        public string? LastName { get; init; }

        [Required(ErrorMessage = "Email is a required field.")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; init; }

        [Required(ErrorMessage = "Card Type is required")]
        [MaxLength(25, ErrorMessage = "Card type cannot exceed 25 characters")]
        public string? CardType { get; set; }

        [Required(ErrorMessage = "Card Number is required")]
        [StringLength(16, ErrorMessage = "Card Number must be 16 characters, no spaces")]
        public string? CardNumber { get; set; }

        [Required(ErrorMessage ="Expiration date is required")]
        [DataType(DataType.DateTime)]
        public DateTime? ExpirationDate { get; set; }

        [Required]
        public int? CCV { get; set; }
    }
}
