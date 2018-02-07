using System;
using System.Collections.Generic;
using System.Text;


namespace Lab11DesignTheClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Design classes, properties, and methods for Person, Student, Staff and their various fields

            {

                Person person1 = new Person { Name = "John Person", Address = "P42 Wallaby Way, Sydney" };

                Student student1 = new Student { Name = "Sam Student", Address = "30 Rockefeller Plaza", Program = "Software Engineer", Year = 2018, Fee = 1000 };

                Staff staff1 = new Staff { Name = "Bob Staff", Address = "Where everybody knows your name", School = "Grand Circus", Pay = 1000 };


                Console.WriteLine(staff1);
                Console.WriteLine(person1);
                Console.WriteLine(student1);



                ////didn't work; were a type not a variable
                //Console.WriteLine(Person);
                //Console.WriteLine(Student);
                //Console.WriteLine(Staff);


                ////Example
                //Person person = new Person { Name = "John", Age = 12 };
                //Console.WriteLine(person);
                // Output:
                // Person: John 12




            }
        }

    }
}

