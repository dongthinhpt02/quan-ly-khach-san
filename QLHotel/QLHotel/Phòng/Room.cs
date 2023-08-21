using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHotel
{
    class Room
    {
        MY_DB mydb = new MY_DB();
        public bool checkidRoom(int roomid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Room WHERE PhongID = @id", mydb.getConnection);
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
        public bool insertRoom(int phongid, string loaiphongid, string tinhtrang, int sophong)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Room (PhongID, LoaiPhongID, TinhTrang, SoPhong)" + "VALUES (@id,@lpid,@tt,@sp) ", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = phongid;
            command.Parameters.Add("@lpid", SqlDbType.NVarChar).Value = loaiphongid;
            command.Parameters.Add("@tt", SqlDbType.NVarChar).Value = tinhtrang;
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
        public bool editRoom(int phongid, string loaiphongid, string tinhtrang, int sophong)
        {
            SqlCommand command = new SqlCommand("UPDATE Room SET LoaiPhongID = @lpid, TinhTrang = @tt, SoPhong = @sp WHERE PhongID = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = phongid;
            command.Parameters.Add("@lpid", SqlDbType.NVarChar).Value = loaiphongid;
            command.Parameters.Add("@tt", SqlDbType.NVarChar).Value = tinhtrang;
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
        public DataTable getRoom(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool deleteRoom(int phongid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Room WHERE PhongID = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = phongid;
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
        public DataTable getAllRoom()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Room", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getAllRoom(int rid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Room WHERE PhongID = " + rid, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getRoomClear()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Room WHERE TinhTrang = 'Clear'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getRoomFull()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Room WHERE TinhTrang = 'Full'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getRoomNumberFull()
        {
            SqlCommand command = new SqlCommand("SELECT SoPhong FROM Room WHERE TinhTrang = 'Full'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updateRoom(int sophong, string tinhtrang)
        {
            SqlCommand command = new SqlCommand("UPDATE Room SET tinhtrang = @tt WHERE SoPhong = " + sophong, mydb.getConnection);
            command.Parameters.Add("@tt", SqlDbType.NVarChar).Value = tinhtrang;
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
        public DataTable getfullroom()
        {
            SqlCommand command = new SqlCommand("SELECT phongid as 'Mã Phòng', sophong as 'Số phòng', tinhtrang as 'Tình trạng' FROM Room ", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getroomnumber()
        {
            SqlCommand command = new SqlCommand("SELECT phongid, sophong FROM Room ", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
