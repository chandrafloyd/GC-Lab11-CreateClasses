using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11DesignTheClasses
{
    class Staff : Person
    {
        // FIELDS 
        //private string school;
        //private double pay;

        //PROPERTY
        public string School
        {
            set;
            get;
        }

        public double Pay
        {
            set;
            get;
        }

        //CONSTRUCTOR
        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            this.School = school;
            this.Pay = pay;
        }

        // METHODS
        public override string ToString()
        {
            Console.WriteLine(new string ('*',20));
            Console.WriteLine("\n STAFF INFO \n");
            Console.WriteLine(new string('*', 20));

            return "\n Name: " + Name + "\n Address: " + Address +  " \n School: " + School + "\n Pay: " + Pay;
           
        }
      
    }
}