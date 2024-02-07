using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211___Lab_3___Part_2
{
    public class Cat: IAnimal
    {
        //Declare Getters and Setters for Variables from IAnimal
        public string Name { get; set; }
        public string Colour { get; set; }
        public string Height { get; set; }
        public string Age { get; set; }
        public Cat()
        {
        }
        //Get Height Method uses IAnimal
        public void GetHeight()
        {
            Console.WriteLine($"The Height of the Animal is {Height} ft");
        }

        //Get Name Method uses IAnimal
        public void GetName()
        {
            Console.WriteLine($"The Animals Name is {Name}");
        }
        //Get Color Method uses IAnimal
        public void GetColour()
        {
            Console.WriteLine($"The Animals Colour is {Colour}");
        }
        //Get Age Method uses IAnimal
        public void GetAge()
        {
            Console.WriteLine($"The Animals Age is {Age}");
        }
        //Eat Method uses IAnimal
        public void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }

        // Cry Method Uses IAnimal
        public string Cry()
        {
            return "Meow"; 
        }
    }
}
