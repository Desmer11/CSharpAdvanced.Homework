



namespace Abstract.Classes.Library
{
    public class SqlDataAccess : IDataAccess
    {
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }
        public void LoadData(string sql) 
        {
            Console.WriteLine("Loading Microsoft SQL Data");
        }
        public void SaveData(string sql)
        {
            Console.WriteLine("Saving Data To Microsoft SQL Server");
        }

    }
}