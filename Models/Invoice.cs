using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AR_VehicleServiceCenter.Models
{
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceId { get; set; }

        [Required]
        public int AppointmentId { get; set; }

        public Appointment Appointment { get; set; }

        [Required]
        public int PaymentId { get; set; }

        public Payment Payment { get; set; }

        [Required]
        public double TotalCost { get; set; }
    }
}
