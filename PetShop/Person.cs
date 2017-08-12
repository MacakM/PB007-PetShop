using System;
using System.Collections.Generic;

namespace PetShop
{
    public class Person
    {
        public string Name { get; set; }
        public Dog FavouriteDog { get; set; }
        public List<Dog> Dogs { get; set; }
        public List<Cat> Cats { get; set; }

        public Person()
        {
            Dogs = new List<Dog>();
            Cats = new List<Cat>();
        }

        public void MakeCatsSomeFood(Food food)
        {
            foreach (var cat in Cats)
            {
                Console.WriteLine(cat.Name + " here is some " + food.Name + " for you");
            }

        }

        public void GetSomeCat()
        {
            Cats.Add(Shop.SellCat());
        }
    }
}