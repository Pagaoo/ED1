using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            cat1.name = "Sullyvan";
            cat1.gender = 'f';
            cat1.age = 18;
            cat1.hungry = true;
            
            cat1.Eat();

            Console.WriteLine($"Name: {cat1.name}, fome: {cat1.hungry}");
        }
    }
}
