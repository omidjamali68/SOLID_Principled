namespace InterfaceSegregation
{
    internal class Rabbit : IAnimal
    {
        public void Eat()
        {
            // Eat code
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            // Run code
        }
    }
}
