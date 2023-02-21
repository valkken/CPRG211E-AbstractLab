using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_AbstractLab
{
    internal abstract class Animal
    {
        private string name;
        private string colour;
        private int age;

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public abstract void Eat();

    }
}
