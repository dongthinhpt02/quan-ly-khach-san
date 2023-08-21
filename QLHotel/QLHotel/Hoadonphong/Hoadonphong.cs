using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHotel
{
    
    class Hoadonphong
    {
        MY_DB mydb = new MY_DB();
        public bool inserthoadonphong(int sophong, DateTime checkin, DateTime checkout, double songayothucte, double sogiotre, double tienphong1ngay, double thanhtien)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Hoadonphong (SoPhong,Checkin,Checkout,Songayo,Sogiotre,Tienphong1ngay,Thanhtien) " +
                " VALUES (@sp,@ci,@co,@sno,@sgt,@tp1d,@tt)", mydb.getConnection);
            command.Parameters.Add("sp", SqlDbType.Int).Value = sophong;
            command.Parameters.Add("@ci", SqlDbType.DateTime).Value = checkin;
            command.Parameters.Add("@co", SqlDbType.DateTime).Value = checkout;
            command.Parameters.Add("@sno", SqlDbType.Int).Value = songayothucte;
            command.Parameters.Add("@sgt", SqlDbType.Int).Value = sogiotre;
            command.Parameters.Add("@tp1d", SqlDbType.Int).Value = tienphong1ngay;
            command.Parameters.Add("@tt", SqlDbType.Int).Value = thanhtien;
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
        public bool checkidRoom(int roomid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Room WHERE SoPhong = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = roomid;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public DataTable gethoadonphong(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool deletehoadonphong(int sophong)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Hoadonphong WHERE SoPhong = @sp", mydb.getConnection);
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
