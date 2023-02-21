using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_AbstractLab
{
    internal interface IAnimal 
    {
        string Name { get; set; }
        string Colour { get; set; }  
        int Age { get; set; }
        void Eat();
        void Speak();

    }
}
