using System;

namespace PetShop
{
    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public Food FavouriteFood { get; set; }

        public Cat()
        {
            Name = "Tom";
        }

        public void MakeSound()
        {
            Console.WriteLine("Mnau");
        }
    }
}