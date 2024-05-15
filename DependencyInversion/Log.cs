namespace DependencyInversion
{
    internal class Log
    {
        private MySql db;
        public Log()
        {
            this.db = new MySql();
        }

        public void Update()
        {
            db.Update();
        }
    }
}
