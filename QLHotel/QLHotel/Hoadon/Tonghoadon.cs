using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHotel
{
    class Tonghoadon
    {
        MY_DB mydb = new MY_DB();
        public bool insertonghoadon(int sp, string ten, int gia)
        {
            SqlCommand command = new SqlCommand("INSERT INTO TONGHOADON (Sophong, Ten, Giatien) " +
                "VALUES (@sp,t,gt)",mydb.getConnection);
            command.Parameters.Add("@sp", SqlDbType.Int).Value = sp;
            command.Parameters.Add("@t", SqlDbType.NVarChar).Value = ten;
            command.Parameters.Add("@gt", SqlDbType.Int).Value = gia;
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
