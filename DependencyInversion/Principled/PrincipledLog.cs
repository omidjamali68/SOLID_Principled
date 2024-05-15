namespace DependencyInversion.Principled
{
    internal class PrincipledLog
    {
        private IDatabase db;

        public PrincipledLog(IDatabase database)
        {
            this.db = database;            
        }

        public void Update()
        {
            db.Update();
        }
    }
}
