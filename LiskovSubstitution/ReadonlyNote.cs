namespace LiskovSubstitution
{
    internal class ReadonlyNote : Note
    {
        public ReadonlyNote(int id) : base(id)
        {

        }

        public void Save(string txt)
        {
            throw new Exception("Can't update readonly notes");
        }
    }
}
