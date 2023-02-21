using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_AbstractLab.Entities
{
    internal class Dog : Animal, IAnimal
    {
    
        string name { get; set; }
        string colour { get; set; }
        int age { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }

        public void Speak()
        {
            Console.WriteLine("Woof!");
        }
    }
}
