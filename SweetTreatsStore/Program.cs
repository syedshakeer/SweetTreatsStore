using SweetTreatsStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetTreatsStore
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime shipTime = Convert.ToDateTime("12:00");
            int deliveryRanage = 3;
            bool hasRefrigerator = true;

            List<CourierModel> obj =  GetCheapestCourier(shipTime, deliveryRanage, hasRefrigerator);

            if (obj.Count == 0) Console.WriteLine("No data found..");
            else
            {
                foreach (var row in obj)
                {
                    Console.WriteLine("Name:" + row.name + " " + "Charges:" + row.charges + " " + "Range:" + row.deliveryRange +"miles");
                }
            }
            Console.ReadLine();
        }

        public static List<CourierModel> GetCheapestCourier(DateTime shippedTime, int distance, bool hasRefrigerator)
        {
            List<CourierModel> data = AddDataToModel();
            var result = data.Where(c =>
             c.workingStartHours <= shippedTime &&
             c.workingEndHours >= shippedTime &&
             c.deliveryRange >= distance &&
             c.hasRefrigirated == hasRefrigerator
             )
               .OrderBy(o=>o.charges)
                .ToList();

            return result.ToList();
        }
        
        //add data
        public static List<CourierModel> AddDataToModel()
        {
            List<CourierModel> cm = new List<CourierModel>();
            cm.Add(new CourierModel()
            {
                cId = 1,
                name = "Bobby",
                deliveryRange = 5,
                workingStartHours = Convert.ToDateTime("9:00"),
                workingEndHours = Convert.ToDateTime("13:00"),
                charges = 1.75,
                hasRefrigirated = true
            });
            cm.Add(new CourierModel()
            {
                cId = 2,
                name = "Martin ",
                deliveryRange = 3,
                workingStartHours = Convert.ToDateTime("9:00"),
                workingEndHours = Convert.ToDateTime("17:00"),
                charges = 1.50,
                hasRefrigirated = false
            });
            cm.Add(new CourierModel()
            {
                cId = 3,
                name = "Geoff ",
                deliveryRange = 4,
                workingStartHours = Convert.ToDateTime("10:00"),
                workingEndHours = Convert.ToDateTime("16:00"),
                charges = 2.0,
                hasRefrigirated = true
            });
            return cm;
        }
    }

   
}
