using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Dog : IAnimal
    {
        public string Name { get; set; }

        public void Speak()
        {
            Console.WriteLine("woof");
        }
    }
}
