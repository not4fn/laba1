using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPuJAP_15._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            DogClass dog= new DogClass();
            dog.ToString();
            Console.WriteLine("Введите кличку: ");
            dog.setName(Console.ReadLine());
            Console.WriteLine("Введите породу: ");
            dog.setBreed(Console.ReadLine());
            Console.WriteLine("Введите возраст: ");
            dog.setAge(Console.ReadLine());
            dog.ToString();
            Console.Clear();
            Console.ReadKey();
        }
    }
}
