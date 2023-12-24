using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunt_Models.Common
{
    public class address
    {
        [Key]
        public int Id { get; set; }
        public string DoorNo { get; set; }
        public string street { get; set; }
        public string area { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string pincode { get; set; }
        public string country { get; set; }
        public string Landmark { get; set; }

    }
}
