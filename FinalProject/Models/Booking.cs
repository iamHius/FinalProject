﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace FinalProject.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        [ForeignKey("IdentityUser")]
        public string? UserId { get; set; }
        [ForeignKey("Room")]
        public int RoomId { get; set; }
        public bool IsPayment { get; set; } = false;
        [Required]
        public DateTime? CheckInDate { get; set; }
        [Required]
        public DateTime? CheckOutDate { get; set; }
        [Required]
        public DateTime? BookingDate { get; set; } = DateTime.Now;
        [ForeignKey("BookingStatus")]
        public string? Status { get; set; }

        public IdentityUser? User { get; set; }
        public Room? Room { get; set; }
    }
}
