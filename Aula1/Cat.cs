namespace Aula1
{
    using System;
    public class Cat
    {
        public string name;

        public char gender;

        public int age;

        public bool hungry;

        public void Meow() {
            Console.WriteLine("Miaaauuu");
        }

        public void Eat() {
            hungry = false;
        }

        public void Poo() {
            hungry = true;
        }
    }
}