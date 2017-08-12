using System.Linq;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Person martin = new Person();
            martin.GetSomeCat();
            martin.MakeCatsSomeFood(new Food("Kit Cat"));
            martin.Cats.First().MakeSound();
        }
    }
}