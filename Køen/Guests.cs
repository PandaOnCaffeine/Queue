using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    internal class Guests
    {
        //Properties
        private string name;
        private byte age;

        //Encapsulation
        public string Name { get { return name; } }
        public byte Age { get { return age; } }


        //constructer
        public Guests(string name, byte age)
        {
            this.name = name;
            this.age = age;
        }

        //Override ToString
        public override string ToString()
        {
            return name + " Age: " +age;
        }
    }
}
