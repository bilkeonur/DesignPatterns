using System;
namespace SingletonPattern
{
    public class Connection
    {
        private static Connection connection = null;

        private Connection()
        {

        }

        public static Connection GetInstance()
        {
            if (connection == null)
            {
                return new Connection();
            }
            else
            {
                return connection;
            }
        }

        public void OpenConnection()
        {
            Console.WriteLine("Bağlantı Açıldı");
        }
    }
}

