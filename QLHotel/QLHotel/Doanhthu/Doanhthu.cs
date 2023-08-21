using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHotel
{
    class Doanhthu
    {
        MY_DB mydb = new MY_DB();
        public bool insertdoanhthu(string ngaythangnam, int SoPhong, int Tien)
        {
            SqlCommand command = new SqlCommand("INSERT INTO DOANHTHU (Ngaythangnam, SoPhong, Tien) " +
                "VALUES (@ntn,@sp,@t)", mydb.getConnection);
            command.Parameters.Add("@ntn", SqlDbType.NVarChar).Value = ngaythangnam;
            command.Parameters.Add("@sp", SqlDbType.Int).Value = SoPhong;
            command.Parameters.Add("@t", SqlDbType.Int).Value = Tien;
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
        public DataTable getalldoanhthu()
        {
            SqlCommand command = new SqlCommand("SELECT ngaythangnam as 'Ngày tháng năm', SoPhong as 'Số phòng', Tien as 'Tiền' FROM Doanhthu", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getdoanhthu1(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
