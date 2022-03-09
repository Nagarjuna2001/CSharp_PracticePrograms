using System;

namespace StaticClasses
{
    class Employee
    {
        static void Main(string[] args)
        {
            DataBaseConfigFile.DB_Name = "Emolyee_Details_Database";
            DataBaseConfigFile.Server_Name = "R10_Server";
            DataBaseConfigFile.port = 8080;
            DataBaseConfigFile.DB_Username = "username";
            DataBaseConfigFile.DB_Password = "Qwert123";

            Console.WriteLine("Connection established: "+ DataBaseConfigFile.DatabaseConnection());
        }
    }
}
