using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHotel
{
    class LoaiPhong
    {
        MY_DB mydb = new MY_DB();
        public DataTable getallLoaiPhong()
        {
            SqlCommand command = new SqlCommand("SELECT TenloaiPhong FROM LoaiPhong",mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
