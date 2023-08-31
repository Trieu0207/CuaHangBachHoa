using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection _con = new SqlConnection("Data Source=DESKTOP-I35C4CT;Initial Catalog=DATABASEQLBH;Integrated Security=True");

    }
}
