using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_AbstractLab.Entities
{
    internal class Cat : Animal, IAnimal
    {
        string Name { get; set; }
        string colour { get; set; }
        int age { get; set; }   

        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }

        public void Speak()
        {
            Console.WriteLine("Meow~");
        }
    }
}
