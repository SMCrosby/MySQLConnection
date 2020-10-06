using System;

using MySQLLibrary;     //add namespace for library

namespace MySQLConnection {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Working on sending SQLServer data to C# library");

            var ss = new SqlServer();
            var ok = ss.Connect("localhost", "sqlexpress", "EdDb");        //localhost instead of server name (pulls up my laptops info)

            var students = ss.ExecuteQuery("SELECT * from Student;");

            ss.Disconnect();


        }
    }
}
