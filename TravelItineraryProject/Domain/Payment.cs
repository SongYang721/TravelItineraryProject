using System.ComponentModel.DataAnnotations;

namespace TravelItineraryProject.Domain
{
    public class Payment 
    {

        public int PaymentId { get; set; } // PK

        [Required(ErrorMessage = "Name on Card is required.")]
        [StringLength(100, ErrorMessage = "Name on Card cannot exceed 100 characters.")]
        public string? NameOnCard { get; set; }

        [Required(ErrorMessage = "Card Number is required.")]
        [RegularExpression(@"^\d{16}$", ErrorMessage = "Card Number must be exactly 16 digits.")]
        public string? CardNumber { get; set; }

        [Required(ErrorMessage = "Expiry Date is required.")]
        [RegularExpression(@"^(0[1-9]|1[0-2])\/\d{2}$", ErrorMessage = "Expiry Date must be in MM/YY format.")]
        public string? ExpiryDateOfCard { get; set; }

        [Required(ErrorMessage = "Security Code is required.")]
        [RegularExpression(@"^\d{3}$", ErrorMessage = "Security Code must be exactly 3 digits.")]
        public string? SecurityCode { get; set; }

        public bool PaymentStatus { get; set; }
    }
}
