using System.Globalization;

namespace CPRG211___Lab_3___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PART 2 Start
            //DOG CLASS
            //Create Dog Object
            Dog dog2 = new Dog();

            //Prompt User for Input of Dog Name
            Console.WriteLine("Please enter a name for your dog");
            string userDogName2 = Console.ReadLine();

            //Set Dog Object Name to User Input
            dog2.Name = userDogName2;

            //Prompt user for input of dog name
            Console.WriteLine("Please enter an age for your dog");
            string userDogAge2 = Console.ReadLine();

            //Set Dog age
            dog2.Age = userDogAge2;

            //Prompt user for Input of Dog Color
            Console.WriteLine("Please enter a Colour for your dog");
            string userDogColour2 = Console.ReadLine();

            //Set Dog Color
            dog2.Colour = userDogColour2;
            
            //Prompt user for Input of Dog Height
            Console.WriteLine("Please enter a Height for your dog");
            string userDogHeight = Console.ReadLine();
            //Set Dog Height
            dog2.Height = userDogHeight;

            //State Get Methods on Dog Object
            dog2.GetName();
            dog2.GetColour();
            dog2.GetAge();
            dog2.GetHeight();

            //State Eat Method on Dog Object
            dog2.Eat();
            
            //Print Dog Cry method to Console
            Console.WriteLine(dog2.Cry());

            //CAT CLASS
            //Create Cat Object
            Cat cat2 = new Cat();

            //Prompt user for Input of Cat Name
            Console.WriteLine("Please Enter a Cat Name");
            string userCatName2 = Console.ReadLine();

            //Set Cat Object Name to User Input
            cat2.Name = userCatName2;

            //Prompt user for Input of Cat Age
            Console.WriteLine("Please Enter a Cat Age");
            string userCatAge2 = Console.ReadLine();

            //Set Cat Age
            cat2.Age = userCatAge2;

            //Prompt user for Cat Color Input
            Console.WriteLine("Please Enter a Cat Colour");
            string userCatColour2 = Console.ReadLine();

            //set Cat Color
            cat2.Colour = userCatColour2;
            //Prompt user for Cat Height
            Console.WriteLine("Please Enter a Cat Height");
            string userCatHeight2 = Console.ReadLine();

            //Set cat height for object
            cat2.Height = userCatHeight2;

            //State Get Methods on Cat Object
            cat2.GetName();
            cat2.GetColour();
            cat2.GetAge();
            cat2.GetHeight();

            //State Eat Method on Cat Object
            cat2.Eat();
            //Print Cry Method on Cat Object
            Console.WriteLine(cat2.Cry());

        //Create additional objects of Dogs and Cats for animals list and give names
            Cat cat3 = new Cat();
            cat3.Name = "Frank";
            Cat cat4 = new Cat();
            cat4.Name = "John";
            Dog dog3 = new Dog();
            dog3.Name = "Bill";
            Dog dog4 = new Dog();
            dog4.Name = "John";

            //Create List
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(cat2);
            animals.Add(dog2);
            animals.Add(cat3);
            animals.Add(dog4);
            animals.Add(dog3);
            animals.Add(cat4);

            //Output List
            Console.WriteLine("Animal Names:");
            //For Loop to get each dog and cat object name
            for (int i = 0; i < animals.Count; i++)
            {
                // Create variable to hold each animals index
                var animal = animals[i];
                // Print the name of each object to console.
                Console.WriteLine(animal.Name);
            }
        }
    }
}
