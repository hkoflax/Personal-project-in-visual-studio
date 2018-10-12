using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaPlusLibrary
{
    public class Order
    {
        //private static int noOfOrder=10000;
        public long OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public String OrderDescription { get; set; }
        public String OrderDeliveryAdress { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public User OrderUser { get; set; }

        public Order(string description, string adress)
        {
            //OrderId = ++noOfOrder;
            OrderDescription = description;
            OrderDeliveryAdress = adress;
            OrderStatus = OrderStatus.Requested;
            OrderDate = DateTime.UtcNow;
            DeliveryDate = OrderDate.AddDays(1);
        }

        public override string ToString()
        {
            return string.Format("Order Id: {0}\n"+
                                 "Description: {1}\n"+
                                 "Delivery Adress: {2}\n"+
                                 "Status: {3}\n"+
                                 "Name of User: {4} and Id: {5}\n"+
                                 "order Date: {6}\n"+
                                 "Delivery Date: {7}\n",OrderId,OrderDescription,OrderDeliveryAdress,OrderStatus,OrderUser.UserFName,OrderUser.UserId,OrderDate, DeliveryDate);
        }
    }
    public enum OrderStatus {Requested,On_Road,Completed,Canceled};
}
