using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11DesignTheClasses
{
    //Design classes, properties, and methods for Person, Student, Staff and their various fields

    class Person
    {
        // FIELDS - what the person is made of
        //private string name;
        //private string address;


        //PROPERTIES - where to get the fields that build the person

        public string Name //properties start with a capital and do not have parameters
        {
            set;  //used to change the value of the field
            get;  //used to return the value of the field (like retrieving your atm balance)

            //once the properties are set, now it will pop up in the list when you type the string name. Jacob.Name
        }

        public string Address
        {
            set;
            get;
        }


        //CONSTRUCTOR - specific instructions for building the person
        public Person(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        //METHOD - Print
        public override string ToString()
        {
            Console.WriteLine(new string('*', 20));
            Console.WriteLine("\n PERSONAL INFO \n");
            Console.WriteLine(new string('*', 20));

            return "\nName: " + Name+"\nAddress: "+ Address;

          
        }


    }



}
