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
        public bool themNV(int manv,string honv,string tennv,string gioitinh,string sdt,string chucvu,string calam,string tienthu, string tienchi)
        {
            SqlCommand command = new SqlCommand("INSERT INTO NV (manv,honv,tennv,gioitinh,sdt,chucvu,chamcong,tienthu,tienchi)" + "VALUES (@manv,@ho,@ten,@gt,@sdt,@cv,@ca,@thu,@chi)", mydb.getConnection);
            command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            command.Parameters.Add("@ho", SqlDbType.VarChar).Value = honv;
            command.Parameters.Add("@ten", SqlDbType.VarChar).Value = tennv;
            command.Parameters.Add("@gt", SqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
            command.Parameters.Add("@cv", SqlDbType.VarChar).Value = chucvu;
            command.Parameters.Add("@ca", SqlDbType.VarChar).Value = calam;
            command.Parameters.Add("@thu", SqlDbType.VarChar).Value = tienthu;
            command.Parameters.Add("@chi", SqlDbType.VarChar).Value = tienchi;
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
        public bool CapNhatNV(int manv, string honv, string tennv, string gioitinh, string sdt, string chucvu, string calam, string tienthu, string tienchi)
        {
            SqlCommand command = new SqlCommand("UPDATE NV SET honv=@ho,tennv=@ten,gioitinh=@gt,sdt=@sdt,chucvu=@cv,chamcong=@ca,tienthu=@thu,tienchi=@chi WHERE manv=@manv" , mydb.getConnection);
            command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            command.Parameters.Add("@ho", SqlDbType.VarChar).Value = honv;
            command.Parameters.Add("@ten", SqlDbType.VarChar).Value = tennv;
            command.Parameters.Add("@gt", SqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
            command.Parameters.Add("@cv", SqlDbType.VarChar).Value = chucvu;
            command.Parameters.Add("@ca", SqlDbType.VarChar).Value = calam;
            command.Parameters.Add("@thu", SqlDbType.VarChar).Value = tienthu;
            command.Parameters.Add("@chi", SqlDbType.VarChar).Value = tienchi;
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
