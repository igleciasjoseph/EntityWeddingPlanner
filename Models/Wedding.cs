using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WeddingPlanner.Models
{
    public class Wedding {
        [Key]
        public int WedId {get;set;}
        public string WedOne{get;set;}
        public string WedTwo{get;set;}
        public DateTime Date{get;set;}
        public string WedAddress{get;set;}

        public List<Guests> Guests {get;set;}
    }
}