using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection connection1 = Connection.GetInstance();
            connection1.OpenConnection();

            Connection connection2 = Connection.GetInstance();
            connection2.OpenConnection();
        }
    }
}

