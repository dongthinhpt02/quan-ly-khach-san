using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHotel
{
    class Service
    {
        MY_DB mydb = new MY_DB();
        public DataTable getdichvu()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Dichvu", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getgiatien(string tdv)
        {
            SqlCommand command = new SqlCommand("SELECT tendichvu, giatien FROM Dichvu Where tendichvu= @tdv" , mydb.getConnection);
            command.Parameters.Add("@tdv", SqlDbType.NVarChar).Value = tdv;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertdichvu(int sophong, string tendichvu,int giatien)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Hoadondichvu (SoPhong,Tendichvu, Giatien) " +
                " VALUES (@sp,@tdv,@gt)", mydb.getConnection);
            command.Parameters.Add("sp", SqlDbType.Int).Value = sophong;
            command.Parameters.Add("@tdv", SqlDbType.NVarChar).Value = tendichvu;
            command.Parameters.Add("@gt", SqlDbType.Int).Value = giatien;
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
        public DataTable gethoadondichvu(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool deletedichvu(int sophong)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Hoadondichvu WHERE SoPhong = @sp", mydb.getConnection);
            command.Parameters.Add("@sp", SqlDbType.Int).Value = sophong;
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
    }
}
