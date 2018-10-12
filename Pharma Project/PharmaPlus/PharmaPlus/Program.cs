using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmaPlusLibrary;

namespace PharmaPlus
{
    class Program
    {
        static void Main(string[] args)
        {
            User koflax = new User("koflax", "HOUNKPE",123456789, 25, "be klikame","hkof@abc.com", "Mypassword");
            User marc1 = new User("marc1","KPODAR" ,123456789, 23, "canada", UserType.Admin, "marcf@abc.com","Password");

            Order order1 = new Order("order1","canada");
            Order order2 = new Order("order2", "klikame");

            Console.WriteLine(koflax.ToString());
            Console.WriteLine(marc1.ToString());
            Console.WriteLine(order1.ToString());
            Console.WriteLine(order2.ToString());

            koflax.PlaceAnOrder(order1);
            marc1.PlaceAnOrder(order2);
            Console.WriteLine(order1.ToString());
            Console.WriteLine(order2.ToString());
        }
    }
}