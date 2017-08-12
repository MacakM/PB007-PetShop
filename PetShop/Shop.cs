namespace PetShop
{
    public static class Shop
    {
        public static Cat SellCat()
        {
            return new Cat();
        }

        public static Dog SellDog()
        {
            return new Dog();
        }
    }
}