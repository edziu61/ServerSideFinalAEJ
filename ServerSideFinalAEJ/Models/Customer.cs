using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerSideFinalAEJ.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string company { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
    }
}