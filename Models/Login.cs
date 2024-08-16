using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AR_VehicleServiceCenter.Models
{
    public class LoginModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoginId { get; set; }
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
