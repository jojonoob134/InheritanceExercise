using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Birb : Animal
    {
        public bool CanFly { get; set; }

        public string Color { get; set; }

        public string Name { get; set; }

        public bool IsCute { get; set; }
    }
}
