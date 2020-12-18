using System;
using Npgsql;
namespace data01.Data
{
    public class MyPostgresDB
    {
        private NpgsqlDataReader data = null;
        private NpgsqlConnection lnk;
        public MyPostgresDB()
        {
            string  con = "Server=209.126.96.59;";
            con += "User Id=u108696;";
            con += "Password=CYI8YQB1;";
            con += "Database=adv_prog;";
            this.lnk = new NpgsqlConnection(con);// creating connection 
            lnk.Open();
        }
        
        ~MyPostgresDB()
        { //destroyer
            this.lnk.Close();
        }
        public NpgsqlDataReader executeSQL(string sql)
        {
            NpgsqlCommand command = new NpgsqlCommand(sql,this.lnk);
            data = command.ExecuteReader();
            return data;
        }
    }
} 

