using System;

namespace OOPChallenge01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating an array type string
            string[] person = new string[3];

            // creating a loop to add names into the array
            for (int o = 0; o < person.Length; o++)
            {
                Console.WriteLine("Please, let me know the name!");
                person[o] = Console.ReadLine();
                Console.Clear();
            }
            //Creating new Objects
            Person a = new Person(person[0]);
            Person b = new Person(person[1]);
            Person c = new Person(person[2]);

            //Greeting each person in the array.
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(c.ToString());
        }
    }
}
