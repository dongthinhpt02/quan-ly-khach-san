using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHotel
{
    class NhanVien
    {
        MY_DB mydb = new MY_DB();
        public bool themNV(int manv, string honv, string tennv, string gioitinh, string sdt, string chucvu, string diachi, string quequan, string cmnnd)
        {
            SqlCommand command = new SqlCommand("INSERT INTO NV (manv,honv,tennv,gioitinh,sdt,chucvu,diachi,quequan,cmt)" + "VALUES (@manv,@ho,@ten,@gt,@sdt,@cv,@dc,@que,@cmnd)", mydb.getConnection);
            command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            command.Parameters.Add("@ho", SqlDbType.VarChar).Value = honv;
            command.Parameters.Add("@ten", SqlDbType.VarChar).Value = tennv;
            command.Parameters.Add("@gt", SqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
            command.Parameters.Add("@cv", SqlDbType.VarChar).Value = chucvu;
            command.Parameters.Add("@dc", SqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@que", SqlDbType.VarChar).Value = quequan;
            command.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnnd;
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
        public DataTable layNV(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool XoaNV(int manv)
        {
            SqlCommand command = new SqlCommand("DELETE FROM NV where manv = @manv", mydb.getConnection);
            command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
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
        public bool CapNhatNV(int manv, string honv, string tennv, string gioitinh, string sdt, string chucvu, string diachi, string quequan, string cmnnd)
        {
            SqlCommand command = new SqlCommand("UPDATE NV SET honv=@ho,tennv=@ten,gioitinh=@gt,sdt=@sdt,chucvu=@cv,diachi=@dc,quequan=@que,cmt=@cmnd WHERE manv=@manv", mydb.getConnection);
            command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            command.Parameters.Add("@ho", SqlDbType.VarChar).Value = honv;
            command.Parameters.Add("@ten", SqlDbType.VarChar).Value = tennv;
            command.Parameters.Add("@gt", SqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
            command.Parameters.Add("@cv", SqlDbType.VarChar).Value = chucvu;
            command.Parameters.Add("@dc", SqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@que", SqlDbType.VarChar).Value = quequan;
            command.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnnd;
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
        public DataTable CaLamList(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool ThemCa(string day, int manv,string honv,string tennv,string chucvu,string ca1,string ca2,string ca3, string ca4, string ca5, string ca6)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Ca (dayofweek,manv,honv,tennv,chucvu,ca1,ca2,ca3,ca4,ca5,ca6)" + "VALUES (@day,@manv,@honv,@tennv,@chucvu,@ca1,@ca2,@ca3,@ca4,@ca5,@ca6)", mydb.getConnection);
            command.Parameters.Add("@day", SqlDbType.VarChar).Value = day;
            command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            command.Parameters.Add("@honv", SqlDbType.VarChar).Value = honv;
            command.Parameters.Add("@tennv", SqlDbType.VarChar).Value = tennv;
            command.Parameters.Add("@chucvu", SqlDbType.VarChar).Value = chucvu;
            command.Parameters.Add("@ca1", SqlDbType.VarChar).Value = ca1;
            command.Parameters.Add("@ca2", SqlDbType.VarChar).Value = ca2;
            command.Parameters.Add("@ca3", SqlDbType.VarChar).Value = ca3;
            command.Parameters.Add("@ca4", SqlDbType.VarChar).Value = ca4;
            command.Parameters.Add("@ca5", SqlDbType.VarChar).Value = ca5;
            command.Parameters.Add("@ca6", SqlDbType.VarChar).Value = ca6;
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
        public bool Themgiolam(int manv,int gio,string date)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Giolam (manv,giolam,dayofweek)" + "VALUES (@manv,@giolam,@date)", mydb.getConnection);
            command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            command.Parameters.Add("@giolam", SqlDbType.Int).Value = gio;
            command.Parameters.Add("@date", SqlDbType.VarChar).Value = date;
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
