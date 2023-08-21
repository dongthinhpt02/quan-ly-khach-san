using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
namespace QLHotel
{
    class ChucVu
    {
        MY_DB mydb = new MY_DB();
        public bool insertRole(int id, string rname, int userid)
        {
            SqlCommand command = new SqlCommand("INSERT INTO role (id, name, userid) VALUES (@id, @gn, @uid)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@gn", SqlDbType.VarChar).Value = rname;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool updateRole(int id, string rname)
        {
            SqlCommand command = new SqlCommand("UPDATE role SET name = @gn WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@gn", SqlDbType.VarChar).Value = rname;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool roleExist(string rname, string operation, int userid, int groupid)
        {
            string query = "";
            SqlCommand command = new SqlCommand();
            if (operation == "add")
            {
                query = "SELECT * FROM role WHERE name = @gn AND userid = @uid";
                command.Parameters.Add("@gn", SqlDbType.VarChar).Value = rname;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM role WHERE name = @gn AND userid = @uid AND id <> @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = groupid;
                command.Parameters.Add("@gn", SqlDbType.VarChar).Value = rname;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            }
            command.Connection = mydb.getConnection;
            command.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public bool deleteRole(int roleid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM role WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = roleid;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable getRole(int userid)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM role WHERE userid=@uid", mydb.getConnection);
            adapter.SelectCommand = command;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
    }
}
