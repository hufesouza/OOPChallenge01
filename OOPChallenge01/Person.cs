using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenge01
{
    internal class Person
    {
        //Defining Property
        public string Name { get; set; }
        
        //Default constructor
        public Person()
        {
            Name = "Jonas";
        }

        //Simple Constructor
        public Person(string name)
        {
            this.Name = name;
        }

        //Override ToString() Method.
        public override string ToString()
        {
            return String.Format($"Hello!! My name is {this.Name}");
        }

        //Setting descructor
        ~Person()
        {
            Name = string.Empty;
        }
    }
}
