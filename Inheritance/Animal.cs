using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Animal
    {
        public int Legs { get; set; }
        public string Habitat { get; set; }
        public bool HasTail { get; set; }
        public bool EatsMeat { get; set; }

        public void textOpt(Birb animal)
        {
            Console.WriteLine($"The animal's name is {animal.Name}");
            Console.WriteLine();
            Console.WriteLine($"it had {animal.Legs} legs");
            Console.WriteLine();
            Console.WriteLine($"It usualy lives in {animal.Habitat}");
            Console.WriteLine();
            if (animal.HasTail)
            {
                Console.WriteLine("yes it dose have a tail");
            }
            else
            {
                Console.WriteLine("no it dose not have a tail");
            }
            Console.WriteLine();
            if (animal.EatsMeat)
            {
                Console.WriteLine("yes it dose eat meat");
            }
            else
            {
                Console.WriteLine("no it dose not eat meat");
            }
            Console.WriteLine();
            if (animal.CanFly)
            {
                Console.WriteLine("yes it can");
            }
            else
            {
                Console.WriteLine("no it can not fly");
            }
            Console.WriteLine();
            Console.WriteLine($"the color of there feathers are {animal.Color}");
            Console.WriteLine();
            if (animal.IsCute)
            {
                Console.WriteLine("yes it is cute");
            }
            else
            {
                Console.WriteLine("no such thing");
            }
        }




        public void textOpt2(Reptile animal)
        {
            Console.WriteLine($"The animal's name is {animal.Name}");
            Console.WriteLine();
            Console.WriteLine($"it had {animal.Legs} legs");
            Console.WriteLine();
            Console.WriteLine($"It usualy lives in {animal.Habitat}");
            Console.WriteLine();
            if (animal.HasTail)
            {
                Console.WriteLine("yes it dose have a tail");
            }
            else
            {
                Console.WriteLine("no it dose not have a tail");
            }
            Console.WriteLine();
            if (animal.EatsMeat)
            {
                Console.WriteLine("yes it dose eat meat");
            }
            else
            {
                Console.WriteLine("no it dose not eat meat");
            }
            Console.WriteLine();
            Console.WriteLine($"it has {animal.ScailColor} scails");
            Console.WriteLine();
            Console.WriteLine($"it had {animal.EyeColor} color eyes");
            Console.WriteLine();
            if (animal.IsAFunnyLittleDude)
            {
                Console.WriteLine("yes it is a funny little dude");
            }
            else
            {
                Console.WriteLine("no such thing");
            }
        }

    }
}
