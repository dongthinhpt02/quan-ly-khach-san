using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHotel
{
    class Card
    {
        MY_DB mydb = new MY_DB();
        public bool insertThe(int sophong, DateTime checkin, DateTime checkout)
        {
            SqlCommand command = new SqlCommand("INSERT INTO The (SoPhong, Checkin, Checkout)" + "VALUES (@sp,@ci,@co)", mydb.getConnection);
            command.Parameters.Add("@sp", SqlDbType.Int).Value = sophong;
            command.Parameters.Add("@ci", SqlDbType.DateTime).Value = checkin;
            command.Parameters.Add("@co", SqlDbType.DateTime).Value = checkout;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
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
        public bool checkidroom(int roomid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM The WHERE SoPhong = @rid", mydb.getConnection);
            command.Parameters.Add("@rid", SqlDbType.Int).Value = roomid;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool deleteThe(int roomid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM The WHERE Sophong = @rid", mydb.getConnection);
            command.Parameters.Add("@rid", SqlDbType.Int).Value = roomid;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }   
        }
        public DataTable getngaythe(SqlCommand comamnd)
        {
            comamnd.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(comamnd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
