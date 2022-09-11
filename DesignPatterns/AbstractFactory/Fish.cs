using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Fish : Animal
    {
        public string speak()
        {
            return "No Sound";
        }
    }
}
