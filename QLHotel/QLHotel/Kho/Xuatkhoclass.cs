using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHotel
{
    class Xuatkhoclass
    {
        MY_DB mydb = new MY_DB();
        public bool insertxuatkho(string thucpham, int soluong)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Xuatkho (Tenthucpham, Soluongxuatkho)" +
                "VALUES (@ttp,@sl)", mydb.getConnection);
            command.Parameters.Add("@ttp", SqlDbType.NVarChar).Value = thucpham;
            command.Parameters.Add("sl", SqlDbType.Int).Value = soluong;
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
