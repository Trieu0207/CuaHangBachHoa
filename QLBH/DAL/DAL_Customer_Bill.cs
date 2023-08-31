using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Customer_Bill : DBConnect
    {
        public bool add(int cusid, int billid)
        {
            int result = 0;
            try
            {
                _con.Open();
                string query = "INSERT INTO [Custommer_Bill] (Billid, Customerid) VALUES (@billid, @cusid)";
                using(SqlCommand cmd = new SqlCommand(query, _con))
                {

                    cmd.Parameters.AddWithValue("@billid", billid);
                    cmd.Parameters.AddWithValue("@cusid", cusid);
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch {Exception ex; }
            finally { _con.Close(); }
            return result > 0;
        }
    }
}
