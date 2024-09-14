using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        [ForeignKey("Booking")]
        public int BookingId { get; set; }

        public DateTime InvoiceDate { get; set; }
        [Column(TypeName = "decimal(8,0)")]
        public decimal? InvoiceAmount { get; set; }
        public bool IsPaid { get; set; }

        public Booking? Booking { get; set; }
    }
}
