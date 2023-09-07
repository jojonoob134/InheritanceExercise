using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Animals
    {
        public int legs { get; set; }
        public string habitat { get; set; }
        public bool hasTail { get; set; }
        public bool eatsMeat { get; set; }

        public void textOpt(Birb animal)
        {
            Console.WriteLine($"The animal's name is {animal.name}");
            Console.WriteLine($"it had {animal.legs} legs");
            Console.WriteLine($"It usualy lives in {animal.habitat}");
            if (animal.hasTail)
            {
                Console.WriteLine("yes it dose have a tail");
            }
            else
            {
                Console.WriteLine("no it dose not have a tail");
            }
            if (animal.eatsMeat)
            {
                Console.WriteLine("yes it dose eat meat");
            }
            else
            {
                Console.WriteLine("no it dose not eat meat");
            }
            if (animal.canFly)
            {
                Console.WriteLine("yes it can");
            }
            else
            {
                Console.WriteLine("no it can not fly");
            }
            Console.WriteLine($"the color of there feathers are {animal.color}");
            if (animal.isCute)
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
            Console.WriteLine($"The animal's name is {animal.name}");
            Console.WriteLine($"it had {animal.legs} legs");
            Console.WriteLine($"It usualy lives in {animal.habitat}");
            if (animal.hasTail)
            {
                Console.WriteLine("yes it dose have a tail");
            }
            else
            {
                Console.WriteLine("no it dose not have a tail");
            }
            if (animal.eatsMeat)
            {
                Console.WriteLine("yes it dose eat meat");
            }
            else
            {
                Console.WriteLine("no it dose not eat meat");
            }
            Console.WriteLine($"it has {animal.scailColor} scails");
            Console.WriteLine($"it had {animal.eyeColor} color eyes");
            if (animal.isAFunnyLittleDude)
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
