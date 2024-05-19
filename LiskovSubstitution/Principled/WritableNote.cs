namespace LiskovSubstitution.Principled
{
    internal class WritableNote : Principled.Note
    {
        public WritableNote(int id) : base(id)
        {
        }

        public void Save(string txt)
        {
            Console.WriteLine($"Save {txt} to note completed");
        }
    }
}
