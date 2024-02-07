using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211___Lab_3
{
    public class Dog : Animal
    {
        public Dog() { }
        public Dog(string name, string colour, string age):base(name,colour,age) 
        { 
        
        }
       
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }

    }
}
