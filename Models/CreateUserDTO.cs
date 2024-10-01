using System.ComponentModel.DataAnnotations;

namespace BodegaVinos.Models
{
    public class CreateUserDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }
}
