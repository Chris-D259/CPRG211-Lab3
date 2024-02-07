using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211___Lab_3
{
    public class Cat : Animal
    {
        public Cat() { } 
        public Cat(string name, string colour, string age) :base(name,colour,age) 
        { 
        }
        
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }

    }
}
