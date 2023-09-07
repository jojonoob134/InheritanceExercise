using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Birb : Animals
    {
        public bool canFly { get; set; }

        public string color { get; set; }

        public string name { get; set; }

        public bool isCute { get; set; }
    }
}
