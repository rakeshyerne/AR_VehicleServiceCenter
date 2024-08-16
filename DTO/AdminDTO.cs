using System.ComponentModel.DataAnnotations;

namespace AR_VehicleServiceCenter.DTO
{
    public class AdminDTO
    {

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }
       
    }
}
