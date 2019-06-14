using System;
using System.ComponentModel.DataAnnotations;
namespace WeddingPlanner.Models
{
    public class LogUser
    {
        [Required(ErrorMessage = "Field must not be empty")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Field must not be blank")]
        [DataType(DataType.Password, ErrorMessage = "Please enter a password before logging in!")]
        public string Password { get; set; }

    }
}