using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AR_VehicleServiceCenter.Models
{
    public class Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ServiceId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public TimeSpan EstimatedTime { get; set; }

        [Required]
        public double Price { get; set; }

        public DateTime ServiceDate { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
    }
}
