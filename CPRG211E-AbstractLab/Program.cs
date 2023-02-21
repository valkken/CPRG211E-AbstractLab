using CPRG211E_AbstractLab.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_AbstractLab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal animal1 = new Dog();
            Animal animal2 = new Cat();

            Console.Write("What do you want to name the dog? ");
            string dogName = Console.ReadLine();
            animal1.Name = dogName;

            Console.Write("What color is the dog? ");
            string dogColor = Console.ReadLine();
            animal1.Colour = dogColor;

            Console.Write("What age is the dog? ");
            int dogAge = Convert.ToInt32(Console.ReadLine());
            animal1.Age = dogAge;

            Console.WriteLine();

            Console.Write("What do you want to name the cat? ");
            string catName = Console.ReadLine();
            animal2.Name = catName;

            Console.Write("What color is the cat? ");
            string catColor = Console.ReadLine();
            animal2.Colour = catColor;

            Console.Write("What age is the cat? ");
            int catAge = Convert.ToInt32(Console.ReadLine());
            animal2.Age = catAge;

            Console.WriteLine();

            Console.WriteLine("DOG\n----------\nName: {0}\nColor: {1}\nAge: {2}", animal1.Name, animal1.Colour, animal1.Age);
            animal1.Eat();

            Console.WriteLine();

            Console.WriteLine("CAT\n----------\nName: {0}\nColor: {1}\nAge: {2}", animal2.Name, animal2.Colour, animal2.Age);
            animal2.Eat();

            Console.WriteLine();

            //PART 2//////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("USING INTERFACES...");
            Console.WriteLine();
            IAnimal animal3 = new Dog();
            IAnimal animal4 = new Cat();

            Console.Write("What do you want to name the dog#2? ");
            string dogName2 = Console.ReadLine();
            animal3.Name = dogName2;

            Console.Write("What color is the dog#2 ");
            string dogColor2 = Console.ReadLine();
            animal3.Colour = dogColor2;

            Console.Write("What age is the dog#2? ");
            int dogAge2 = Convert.ToInt32(Console.ReadLine());
            animal3.Age = dogAge2;

            Console.WriteLine();

            Console.Write("What do you want to name the cat#2? ");
            string catName2 = Console.ReadLine();
            animal4.Name = catName2;

            Console.Write("What color is the cat#2? ");
            string catColor2 = Console.ReadLine();
            animal4.Colour = catColor2;

            Console.Write("What age is the cat#2? ");
            int catAge2 = Convert.ToInt32(Console.ReadLine());
            animal4.Age = catAge2;

            Console.WriteLine();

            Console.WriteLine("DOG#2\n----------\nName: {0}\nColor: {1}\nAge: {2}", animal3.Name, animal3.Colour, animal3.Age);
            animal3.Eat();
            animal3.Speak();

            Console.WriteLine();

            Console.WriteLine("CAT#2\n----------\nName: {0}\nColor: {1}\nAge: {2}", animal4.Name, animal4.Colour, animal4.Age);
            animal4.Eat();
            animal4.Speak();

            Console.WriteLine();

            List<Animal> animals = new List<Animal>();

            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add((Animal)animal3);
            animals.Add((Animal)animal4);


            Console.WriteLine("All animal names: ");
            foreach(Animal entity in animals)
            {
                Console.Write(entity.Name + " ");
                Console.WriteLine();
            }



        }
    }
}
