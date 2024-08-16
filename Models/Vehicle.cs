using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AR_VehicleServiceCenter.Models
{
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VehicleId { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string RegistrationNumber { get; set; }

        public string Colour { get; set; }

        [Required]
        public int UserId { get; set; }

        public User User { get; set; }

        public int? AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
    }
}
