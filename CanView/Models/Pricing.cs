using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CanView.Models
{
    public class TicketPricing
    {
        public int TicketPricingID { get; set; }
        public string TicketPricingType { get; set; }
        public string TicketPriceDesc { get; set; }
        public string TicketPriceAmount { get; set; }
    }
}