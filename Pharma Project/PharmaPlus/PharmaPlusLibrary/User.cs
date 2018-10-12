using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaPlusLibrary
{
    public class User
    {
        //private static int noOfUser;
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public long UserId { get; set; }
        public string UserFName { get; set; }
        public string UserLName { get; set; }
        public long UserPhoneNumber { get; set; }
        public int UserAge { get; set; }
        public string UserAdress { get; set; }
        //private Address registrantAddress;
        //private static Address defaultAddress = new Address();
        public UserType UserType { get; set; }
        //public List<Order> RegistrantList = new List<Order>();

        public User()
        {
            UserEmail = "No email";
            UserPassword = "";
            UserId = 0;
            UserFName = "unknown";
            UserLName = "";
            UserPhoneNumber = 0;
            UserAge = 0;
            UserAdress = "unknown";
            UserType = UserType.Client;
        }
        public User(string fname, string lname, long phoneNumber, int age, string adress, UserType type,string email, string password): this(fname,lname,phoneNumber,age,adress,email,password)
        {
            UserType = type;
        }
        public User(string fname, string lname, long phoneNumber,int age, string adress, string email, string password)
        {
            UserEmail = email;
            UserPassword = password;
            //UserId = ++noOfUser;
            UserId = 0;
            UserFName = fname;
            UserLName = lname;
            UserPhoneNumber = phoneNumber;
            UserAge = age;
            UserAdress = adress;
            UserType = UserType.Client;
        }

        public void PlaceAnOrder(Order anOrder)
        {
            anOrder.OrderUser = this;
        }
        public override string ToString()
        {
            return string.Format("User ID: {0}\n"+
                                 "User Name: {1}\n"+
                                 "User Phone #: {2}\n"+
                                 "User age: {3}\n"+
                                 "User Adress: {4}\n"+
                                 "User Type: {5}\n",UserId,UserFName+" "+UserLName,UserPhoneNumber,UserAge,UserAdress,UserType);
        }

    }
    public enum UserType { Client, Admin};
}
