using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();

            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Dog());
            PrintNrInPopulation(animals);


            Console.ReadKey();



        }
        static void PrintNrInPopulation(List<IAnimal> animals)
        {
            int dogCount = 0;
            int catCount = 0;
            foreach (var a in animals)
            {
                if (a is Dog)
                {
                    dogCount++;
                }
                if (a is Cat)
                {
                    catCount++;
                }

            }
            Console.WriteLine($"Liczba kotów to {catCount}");
            Console.WriteLine($"Liczba psów to { dogCount}");
            Console.WriteLine($"Liczba wszystkich zwierzat to {animals.Count}");
        }


    }
}
