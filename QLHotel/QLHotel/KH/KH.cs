using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHotel
{
    class KH
    {
        MY_DB mydb = new MY_DB();
        public bool insertKH(int makh, string fname, string lname, string gender, string cmnd, string quoctich, DateTime checkin, DateTime checkout, int sophong)
        {
            SqlCommand command = new SqlCommand("INSERT INTO KH (MaKH, Fname, Lname, Gender, Cmnd, Quoctich, Checkin, Checkout, SoPhong )" + 
                "VALUES (@makh, @fn, @ln, @gd, @cmnd, @qt, @ci, @co, @sp)", mydb.getConnection);
            command.Parameters.Add("@makh", SqlDbType.Int).Value = makh;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@gd", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;
            command.Parameters.Add("@qt", SqlDbType.NVarChar).Value = quoctich;
            command.Parameters.Add("@ci", SqlDbType.DateTime).Value = checkin;
            command.Parameters.Add("@co", SqlDbType.DateTime).Value = checkout;
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
        public bool editKH(int makh, string fname, string lname, string gender, string cmnd, string quoctich, DateTime checkin, DateTime checkout, int sophong)
        {
            SqlCommand command = new SqlCommand("UPDATE KH SET fname = @fn, lname = @ln, gender = @gd, cmnd = @cmnd, quoctich = @qt, checkin=@ci, checkout = @co, sophong = @sp WHERE MaKH = @makh", mydb.getConnection);
            command.Parameters.Add("@makh", SqlDbType.Int).Value = makh;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@gd", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;
            command.Parameters.Add("@qt", SqlDbType.NVarChar).Value = quoctich;
            command.Parameters.Add("@ci", SqlDbType.DateTime).Value = checkin;
            command.Parameters.Add("@co", SqlDbType.DateTime).Value = checkout;
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
        public DataTable getKH(SqlCommand comamnd)
        {
            comamnd.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(comamnd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool deleteKH(int makh)
        {
            SqlCommand command = new SqlCommand("DELETE FROM KH WHERE MaKH= @makh", mydb.getConnection);
            command.Parameters.Add("@makh", SqlDbType.Int).Value = makh;
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
        public bool deleteKHtheosophong(int sophong)
        {
            SqlCommand command = new SqlCommand("DELETE FROM KH WHERE Sophong = @sp", mydb.getConnection);
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
        public DataTable getfullcustomer()
        {
            SqlCommand command = new SqlCommand("SELECT Makh as 'Mã KH', fname as 'Họ tên đệm KH', lname as 'Tên KH', cmnd as 'Cmnd' , sophong as 'Số phòng' FROM KH", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        
    }
}
