using System;

namespace ConsoleApp1
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
