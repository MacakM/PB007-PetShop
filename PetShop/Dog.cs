using System;

namespace PetShop
{
    public class Dog : IAnimal
    {
        public Person Owner { get; set; }
        public string Color { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("Hau");
        }
    }
}