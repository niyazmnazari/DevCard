using System.ComponentModel.DataAnnotations;

namespace DevCard_MVC.Models
{
	public class Contact
	{
		[Required(ErrorMessage ="Name is Mandatory.")]
		[MinLength(3, ErrorMessage ="Minimum Length is 3 Character")]
		[MaxLength(100)]
		public string Name { get; set; }

		[Required(ErrorMessage = "Email is Mandatory.")]
		[EmailAddress(ErrorMessage ="Is not a vvalid email address.")]
		public string Email { get; set; }
		public string Service { get; set; }
		public string Message { get; set; }

	}
}
