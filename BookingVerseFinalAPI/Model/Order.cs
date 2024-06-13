using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingVerseFinalAPI.Model
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int AccountID { get; set; }

        [ForeignKey("AccountID")]
        public Account Account { get; set; }

        [Required]
        public int EventID { get; set; }

        [ForeignKey("EventID")]
        public Event Event { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
    }
}
