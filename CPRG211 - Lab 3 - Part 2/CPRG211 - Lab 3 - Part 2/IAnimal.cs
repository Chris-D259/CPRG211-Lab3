using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211___Lab_3___Part_2
{
    public interface IAnimal
    {
        //Getter and Setter Methods for IAnimal
        string Name { get; set; }
        string Colour { get; set; }
        string Height { get; set; }
        string Age { get; set; }


        //Cry String
        string Cry();
        //Printing Methods referenced in Dog & Cat classes
        void GetHeight();
        void GetName();
        void GetColour();
        void GetAge();

        // Eat Method
        void Eat();

        
    }
}

