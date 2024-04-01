using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Entities
{
    public class Customer
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(60, ErrorMessage = "First name cannot be longer than 60 characters.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(60, ErrorMessage = "Last name cannot be longer than 60 characters.")]
        public string? LastName { get; set;}

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

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
        [StringLength(16, ErrorMessage = "Card Number has to be 16 characters.")]
        public string? CardNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ExpirationDate { get; set; }

        [Required]
        public int? CCV { get; set; }

        public ICollection<Plan>? Plans { get; set; }

    }
}
