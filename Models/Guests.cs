using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WeddingPlanner.Models
{
    public class Guests
    {
        [Key]
        public int GuestId { get; set; }
        public int UserId {get;set;}
        public RegUser User{get;set;}
        public int WedId{get;set;}
        public Wedding UserWedding {get;set;}
    }
}