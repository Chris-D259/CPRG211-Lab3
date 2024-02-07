using System.Drawing;

namespace CPRG211___Lab_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Part 1 Start
            //DOG CLASS
            //Create Dog Object
            Dog dog1 = new Dog();

            //Prompt User for Input of Dog Name
            Console.WriteLine("Please enter a name for your dog");
            string userDogName1 = Console.ReadLine();

         //Set Dog Object Name to User Input
            dog1.Name = userDogName1;

            //Set Dog Age 
            Console.WriteLine("Please enter an age for your dog");
            string userDogAge1 = Console.ReadLine();
            dog1.Age = userDogAge1;

            //Set Dog Color
            Console.WriteLine("Please enter a Colour for your dog");
            string userDogColour1 = Console.ReadLine();
            dog1.Colour = userDogColour1;

            //State Get Methods on Dog Object
            dog1.GetName();
            dog1.GetColour();
            dog1.GetAge();

            //State Eat Method on Dog Object
            dog1.Eat();

            //CAT CLASS
            //Create Cat Object

            //Prompt user for Input of Cat Name
            Cat cat1 = new Cat();
            Console.WriteLine("Please Enter a Cat Name");
            string userCatName1 = Console.ReadLine();

            //Set Cat Object Name to User Input
            cat1.Name = userCatName1;
            Console.WriteLine("Please Enter a Cat Age");
            string userCatAge1 = Console.ReadLine();

            //Set Cat Age
            cat1.Age = userCatAge1;

            //Set Cat Color
            Console.WriteLine("Please Enter a Cat Colour");
            string userCatColour1 = Console.ReadLine();
            cat1.Colour = userCatColour1;
            //State Get Methods on Cat Object
            cat1.GetName();
            cat1.GetColour();
            cat1.GetAge();
            //State Eat Method on Cat Object
            cat1.Eat();
            //PART 1 END

            



        }
    }
}
