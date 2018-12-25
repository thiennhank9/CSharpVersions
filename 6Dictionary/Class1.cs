using System;
using System.Collections.Generic;

namespace _6Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, StudentName> students = new Dictionary<int, StudentName>()
            {
                { 111, new StudentName {FirstName="Sachin", LastName="Karnik", ID=211}},
                { 112, new StudentName {FirstName="Dina", LastName="Salimzianova", ID=317}},
                { 113, new StudentName {FirstName="Andy", LastName="Ruth", ID=198}}
            };

            Dictionary<int, StudentName> students = new Dictionary<int, StudentName>()
            {
                [111] = new StudentName { FirstName = "Sachin", LastName = "Karnik", ID = 211 },
                [112] = new StudentName { FirstName = "Dina", LastName = "Salimzianova", ID = 317 },
                [113] = new StudentName { FirstName = "Andy", LastName = "Ruth", ID = 198 }
            };

        }
    }

    public class StudentName
    {
        public string FirstName { get; set; } = "John";
        public string LastName { get; set; } = "Adam";
        public int ID { get; set; } = 211;
    }

    public class DICT
    {
        public string Currency { get; } = "VND";
        public int Price => 1000;
        public string GetMoney() => string.Format("{0} {1}", Price, Currency);
    }
}
