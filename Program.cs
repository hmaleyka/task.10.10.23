namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Snake givenSnake = new Snake("Lala", 3)
            {
                IsPoisonous = true,
                Breed = "female"
            };
            givenSnake.getInfo();

            Dog givenDog = new Dog("Jony", 5)
            {
                Breed = "male"
            };
            givenDog.getInfo();

            Cat givenCat = new Cat("Mastan", -4)
            {
                Breed = "female"
            };
            givenCat.getInfo();

            Dolphin givenDolphin = new Dolphin("Roll", 2)
            { Breed = "female" };
            givenDolphin.getInfo();

        }
    }
}
