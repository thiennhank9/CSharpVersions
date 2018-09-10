using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3AutoImplementProperties
{
    class Customer
    {
        // Auto-Impl Properties for trivial get and set
        public double TotalPurchases { get; set; }
        public string Name { get; set; }
        public int CustomerID { get; set; }

        // Constructor
        public Customer(double purchases, string name, int ID)
        {
            TotalPurchases = purchases;
            Name = name;
            CustomerID = ID;
        }
        // Methods
        public string GetContactInfo() { return "ContactInfo"; }
        public string GetTransactionHistory() { return "History"; }

        // .. Additional methods, events, etc.
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Intialize a new object.
            Customer cust1 = new Customer(4987.63, "Northwind", 90108);

            //Modify a property
            cust1.TotalPurchases += 499.99;
        }
    }

    public class Student
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }

    public class NewStudent
    {
        public int ID { get; set; }
    }
}
