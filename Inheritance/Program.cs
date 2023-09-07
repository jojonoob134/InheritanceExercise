using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
            Animals animals = new Animals();
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
            birb.name = "Mockingbird";
            birb.legs = 2;
            birb.habitat = "towns";
            birb.eatsMeat = false;
            birb.hasTail = true;
            birb.canFly = true;
            birb.color = "grey";
            birb.isCute = true;
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
            reptile.name = "Green anole";
            reptile.legs = 4;
            reptile.habitat = "forests";
            reptile.eatsMeat = false;
            reptile.hasTail = true;
            reptile.scailColor = "green";
            reptile.eyeColor = "blue";
            reptile.isAFunnyLittleDude = true;
            animals.textOpt2(reptile);
        }
    }
}
