using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetTreatsStore.Model
{
    public class CourierModel
    {
        public int cId { get; set; }
        public string name { get; set; }
        public DateTime workingStartHours { get; set; }
        public DateTime workingEndHours { get; set; }
        public int deliveryRange { get; set; }
        public double charges { get; set; }
        public bool hasRefrigirated { get; set; }
    }
}
