using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteEngegraph_Console.Database
{
    internal class TriggerContact
    {
        ClientBD client = new ClientBD("Logs");

        public void Identity()
        {
            string sql = "SET IDENTITY_INSERT dbo.Logs ON;";
            client.CreateTable(sql);
        }

        public void Create()
        {    
            Console.WriteLine(client.Mensage);
            string sql = "Select * From Logs";

            sql = "CREATE TRIGGER Historico_Contacts ON Contacts" +
                    " AFTER INSERT, DELETE, UPDATE AS " +
                    "BEGIN " +
                    "INSERT INTO Logs (Id, DataModificacao, Acao) SELECT Id, DataModificacao = GETDATE(), Acao = 'INSERT' from inserted " +
                    "INSERT INTO Logs (Id, DataModificacao, Acao) SELECT Id, Data/Modificacao = GETDATE(), Acao = 'DELETE' from deleted " +
                    "INSERT INTO Logs (Id, DataModificacao, Acao) SELECT Id, DataModificacao = GETDATE(), Acao = 'UPDATE' from deleted " +
                    "END;";

            Console.WriteLine(client.CreateTable(sql));
        }
    }
}
