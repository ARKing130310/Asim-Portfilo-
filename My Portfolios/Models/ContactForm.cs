using System.ComponentModel.DataAnnotations;

namespace My_Portfolios.Models
{
    public class ContactForm
    {
            [Key]
            public int Id { get; set; }
            [Required(ErrorMessage = "Name is required")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Email is required")]
            [EmailAddress(ErrorMessage = "Invalid Email Address")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Subject is required")]
            public string Subject { get; set; }

            [Required(ErrorMessage = "Message is required")]
            public string Msg { get; set; }
        }
    }