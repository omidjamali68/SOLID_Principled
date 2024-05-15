namespace InterfaceSegregation.Principled
{
    internal class Bird : Principled.IAnimal, IFlyableAnimal
    {
        public void Eat()
        {
            // Eat code
        }

        public void Fly()
        {
            // Fly code
        }

        public void Run()
        {
            // Run code
        }
    }
}
