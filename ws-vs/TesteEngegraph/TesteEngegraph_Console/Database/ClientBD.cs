using System;

namespace TesteEngegraph_Console.Database
{
    public class ClientBD
    {
        public string Mensage;
        public bool Status;
        public string Table;
        public BD_Connection Db;

        public ClientBD(string table)
        {
            Status = true;
            try
            {
                Db = new BD_Connection();
                Table = table;
                Mensage = "Conexão com a Tabela criada com sucesso";
            }
            catch (Exception e)
            {
                Status = false;
                Mensage = "Erro da onexão com a Tabela " + e.Message;
            }
        }

        public string Buscar(string Id)
        {
            Status = true;
            try
            {
                var Sql = "SELECT * FROM Logs";
                var dt = Db.SqlQuery(Sql);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count - 1; i++)
                    {
                        Console.WriteLine(dt.Rows[i].ToString());
                    }
                }
                else
                {
                    Status = false;
                    Mensage = "Nenhum dado de log encontrado";
                }

            }
            catch (Exception e)
            {
                Status = false;
                Mensage = "Erro ao buscar conteúdo: " + e.Message;
            }
            return "";
        }
    }
}
