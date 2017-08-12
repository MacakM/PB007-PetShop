namespace PetShop
{
    public class Food
    {
        public string Name { get; set; }
        public int Protein { get; set; }
        public int Carbohydrates { get; set; }
        public int Fat { get; set; }

        public Food(string name)
        {
            Name = name;
        }
    }
}