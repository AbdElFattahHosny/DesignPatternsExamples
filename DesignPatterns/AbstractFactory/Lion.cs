using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Lion : Animal
    {
        public string speak()
        {
            return "Roar";
        }
    }
}
