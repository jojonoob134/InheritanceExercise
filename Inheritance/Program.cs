using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
            Animal animals = new Animal();
            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class
            
            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Birb birb = new Birb();
            birb.Name = "Mockingbird";
            birb.Legs = 2;
            birb.Habitat = "towns";
            birb.EatsMeat = false;
            birb.HasTail = true;
            birb.CanFly = true;
            birb.Color = "grey";
            birb.IsCute = true;
            animals.textOpt(birb);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile reptile = new Reptile();
            reptile.Name = "Green anole";
            reptile.Legs = 4;
            reptile.Habitat = "forests";
            reptile.EatsMeat = false;
            reptile.HasTail = true;
            reptile.ScailColor = "green";
            reptile.EyeColor = "blue";
            reptile.IsAFunnyLittleDude = true;
            animals.textOpt2(reptile);
        }
    }
}
