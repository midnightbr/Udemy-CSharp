using System;
using System.Data;
using System.Data.SqlClient;
using TesteEngegraph_Console.Database;

namespace TesteEngegraph_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClientBD client = new ClientBD("Logs");
            TriggerContact trigger = new TriggerContact();

            int number = client.Find("Select * From Logs");
            if (number == 0)
            {
                trigger.Create();
            }
        }
    }
}
