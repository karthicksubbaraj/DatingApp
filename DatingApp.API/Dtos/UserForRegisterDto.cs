using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [StringLength(8, MinimumLength=4, ErrorMessage="Enter password of 4 to 8 characters long")]
        public string Password { get; set; }
    }
}