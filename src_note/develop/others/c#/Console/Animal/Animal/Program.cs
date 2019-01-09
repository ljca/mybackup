using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animal = new List<Animal>();
            animal.Add(new Dog());
            animal.Add(new Bird());
            animal.Add(new Fish());
            Console.WriteLine("森林中的小动物在快乐的生活！");
            animal[0].Run();
            animal[1].Run();
            animal[2].Run();
            Console.ReadKey();
        }
    }
}
