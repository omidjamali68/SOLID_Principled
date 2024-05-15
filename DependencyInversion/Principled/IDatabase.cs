namespace DependencyInversion.Principled
{
    internal interface IDatabase
    {
        void Insert();
        void Update();
        void Delete();
    }
}
