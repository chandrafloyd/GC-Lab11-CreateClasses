using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11DesignTheClasses
{
    class Student : Person
    {
        // FIELDS 
        //private string program;
        //private int year;
        //private double fee;

        // PROPERTIES
        public string Program
        {
            set;
            get;
        }
        public int Year
        {
            set;
            get;
        }

        public double Fee
        {
            set;
            get;
        }

        //CONSTRUCTOR
        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            this.Program = program;
            this.Year = year;
            this.Fee = fee;
        }

        // METHODS - Print
       
        public override string ToString()
        {
            Console.WriteLine(new string('*', 20));
            Console.WriteLine("\n STUDENT INFO \n");
            Console.WriteLine(new string('*', 20));

            return "\n Name: " + Name + "\n Address: " + Address + " \n Program: " + Program + "\n Year: " + Year + "\n Fee: "+ Fee;

        }
    }

}
