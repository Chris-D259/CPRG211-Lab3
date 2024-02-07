using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211___Lab_3
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public string Age { get; set; }

        public Animal(){ }

        public Animal(string name, string colour, string age)
        {
            this.Name = name;
            this.Colour = colour;
            this.Age = age;
        }

        public void GetName()
        {
            Console.WriteLine($"The Animals Name is {Name}");
        }

        public void GetColour()
        {
            Console.WriteLine($"The Animals Colour is {Colour}");
        }
        public void GetAge()
        {
            Console.WriteLine($"The Animals Age is {Age}");
        }

     

        public abstract void Eat();
    }
}
