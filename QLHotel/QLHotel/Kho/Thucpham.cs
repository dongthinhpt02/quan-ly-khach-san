using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHotel
{
    class Thucpham
    {
        MY_DB mydb = new MY_DB();
        public bool insertThucpham(int id, string thucpham, int soluong)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Kho (ThucphamID, Tenthucpham, Soluongnhap) " +
                "VALUES (@id,@ttp,@sl)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@ttp", SqlDbType.NVarChar).Value = thucpham;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;
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
        public bool insertxuatkho(string thucpham, int soluong)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Kho (Soluongxuat) " +
                "VALUES (@slx) WHERE Tenthucpham = @ttp", mydb.getConnection);
            command.Parameters.Add("@ttp", SqlDbType.NVarChar).Value = thucpham;
            command.Parameters.Add("@slx", SqlDbType.Int).Value = soluong;
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
        public DataTable getallThucpham()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Kho", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getallThucphamnhap()
        {
            SqlCommand command = new SqlCommand("SELECT Tenthucpham, Soluongnhap FROM Kho", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getallThucphamxuat()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Xuatkho", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getthucpham(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
