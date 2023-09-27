using System.ComponentModel.DataAnnotations;

namespace AboutMe.Models
{
	public class ContactModel
	{
		public int Id { get; set; }

        [Required(ErrorMessage = "NAME VALUE")]
        public string Name { get; set; }

        [Required(ErrorMessage = "EMAIL VALUE")]
        [EmailAddress(ErrorMessage = "EMAIL IS INVALID")]
        public string Email { get; set; }

        [Required(ErrorMessage = "MESSAGE VALUE")]
        public string Message { get; set; }
    }
}

