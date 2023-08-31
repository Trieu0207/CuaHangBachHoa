using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BillDetail : DBConnect
    {
        public DataTable getAllBillDetail()
        {

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.BillDetail", _con);
            DataTable billdetails = new DataTable();
            adapter.Fill(billdetails);
            return billdetails;
           
        }
        public DataTable getBillDetailByBillid(int id)
        {
            DataTable billdetails = new DataTable();
            try
            {
                _con.Open();
                string query = "SELECT * FROM BillDetail WHERE BillID = @id";
                using(SqlCommand cmd =  new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(billdetails);

                }
            } catch (Exception ex) { }
            finally { _con.Close(); }
            return billdetails;
        }
        
        public bool addBillDetail(int billID, int productID, string productname,int quantity, float unitPrice)
        {
            int result = 0;
            try
            {
                _con.Open();
                string query = "INSERT INTO BillDetail (billID, productID, productname, quantity, unitPrice) VALUES (@billid, @productid,@name,@quantity, @price)";
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@billid", billID);
                    cmd.Parameters.AddWithValue("@productid", productID);
                    cmd.Parameters.AddWithValue("@name", productname);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@price", unitPrice);
                    result = cmd.ExecuteNonQuery();

                }

            } catch (Exception ex) { }
            finally { _con.Close(); } 
            return result > 0;
        }
        public bool delBillDetailById(int id)
        {
            int result = 0;
            try
            {
                _con.Open();
                string query = "DELETE FROM BillDetail WHERE BillDetailID = @id";
                using( SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    result = cmd.ExecuteNonQuery();
                    
                }
            } catch (Exception ex) { }
            finally { _con.Close(); }
            return result > 0;
        }
        public bool delBillDetailByBillId(int id)
        {
            int result = 0;
            try
            {
                _con.Open();
                string query = "DELETE FROM BillDeTail WHERE BillID = @id";
                using (SqlCommand cmd = new SqlCommand(query,_con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    result = cmd.ExecuteNonQuery();
                }
            } catch(Exception ex) { }
            finally { _con.Close(); }
            return result > 0;
        }
    }
}
