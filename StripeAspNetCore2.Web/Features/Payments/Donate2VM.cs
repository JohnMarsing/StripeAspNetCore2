using System.ComponentModel.DataAnnotations;

namespace StripeAspNetCore2.Web.Features.Payments
{
	public class Donate2VM
    {
		[Required]
		[Range(1, 5000,	ErrorMessage = "Value for {0} must be between {1} and {2}.")]
		public int Amount { get; set; }
		public string Message { get; set; }
	}
}

//$"Value for {0} must be between {1} and {2}.")]