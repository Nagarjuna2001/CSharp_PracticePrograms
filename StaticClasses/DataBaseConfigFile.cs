using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClasses
{
    public static class DataBaseConfigFile
    {
        internal static string DB_Name { get; set; }
        internal static string Server_Name { get; set; }
        internal static int port { get; set; }
        internal static string DB_Username { get; set; }
        internal static string DB_Password { get; set; }

        
        internal static bool DatabaseConnection()
        {
            //Database connection logic is coded here
            Console.WriteLine("Database connection is successful");

            return true;
        }


    }
}
