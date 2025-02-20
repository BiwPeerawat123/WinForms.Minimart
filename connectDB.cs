using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace WinForms.Minimart
{
    internal class connectDB
    {
        public static SqlConnection ConnectMinimart()
        {
            string server = "DESKTOP-0JABGD6\\SQLEXPRESS";//server name
            string db = "MiniMart";//database name used
            //Connection String
            string strCon = string.Format("Data Source={0};Initial Catalog={1};" + "Integrated Security=True;Encrypt=False", server, db);
            //class conntion
            SqlConnection conn = new SqlConnection(strCon);
            //Open database connection
            conn.Open();
            return conn;
        }
    }
}
