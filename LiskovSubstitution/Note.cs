namespace LiskovSubstitution
{
    internal class Note
    {
        public Note(int id)
        {
            
        }

        public void Save(string txt)
        {
            Console.WriteLine($"Save {txt} to note completed");
        }
    }
}
