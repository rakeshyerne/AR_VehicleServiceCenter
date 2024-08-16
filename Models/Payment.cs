using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AR_VehicleServiceCenter.Models
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentId { get; set; }

        public int? InvoiceId { get; set; }

        public Invoice Invoice { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        public double PaymentAmount { get; set; }
    }
}
