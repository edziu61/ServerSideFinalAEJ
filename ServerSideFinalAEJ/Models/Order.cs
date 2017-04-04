using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerSideFinalAEJ.Models
{
    public class Order
    {
        public int orderId { get; set; }
        public int totalAmount { get; set; }
        public string item { get; set; }

        public virtual Client Client { get; set; }
        //not sure what else to add I think Ed is working on employee 

    }
}