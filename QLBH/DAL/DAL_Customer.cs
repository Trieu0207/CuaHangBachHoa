using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Customer: DBConnect
    {
        public DataTable getAllCustomer()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Customer", _con);
            DataTable customer = new DataTable();
            adapter.Fill(customer);
            return customer;
        }
        public DTO_Customer get1Customer(int id)
        {
            DTO_Customer customer = null;
            try
            {
                _con.Open();
                string query = "SELECT * FROM Customer WHERE CustomerID=@id";
                using(SqlCommand cmd =  new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customer = new DTO_Customer(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4));
                        }
                       
                    }

                }

            } catch (Exception ex) { }
            finally { _con.Close(); }
            return customer;
        }
    
        public bool addCustomer( string name, string addr, string sdt)
        {
            int result = 0;
            try
            {
                _con.Open();
                string query = "INSERT INTO Customer (name, addrees, phone) VALUES ( @name, @addr, @phone)";
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@addr", addr);
                    cmd.Parameters.AddWithValue("@phone", sdt);
                    result = cmd.ExecuteNonQuery();

                }

            }
            catch (Exception ex) { }
            finally { _con.Close(); }
            return result > 0;
        }
        public bool delCustomer(int id)
        {
            int result = 0;
            try
            {
                _con.Open();
                string query = "DELETE FROM Customer WHERE CustomerID =@id";
                using(SqlCommand cmd = new SqlCommand(query,_con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    result = cmd.ExecuteNonQuery();
                }
            } catch (Exception ex) { }
            finally { _con.Close(); }
            return result > 0;
        }
        public bool updateCustomer(int id, string name, string addr, string sdt)
        {
            int result = 0;
            try
            {
                _con.Open();
                string query = "UPDATE Customer SET name = @name, addrees = @addr, phone = @phone WHERE CustomerID=@id";
                using(SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue ("@addr", addr);
                    cmd.Parameters.AddWithValue("@phone", sdt);
                    cmd.Parameters.AddWithValue("@id", id);
                    result = cmd.ExecuteNonQuery();
                }
            } catch (Exception ex) { }
            finally { _con.Close(); }
            return result > 0;
        }
        public bool addPoint(int id, int point)
        {
            int result = 0;
            try
            {
                _con.Open();
                string query = "UPDATE Customer SET point = @point WHERE CustomerID = @id";
                using(SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@point", point);
                    cmd.Parameters.AddWithValue("@id", id);
                    result = cmd.ExecuteNonQuery();
                }
            }catch (Exception ex) { }
            finally { _con.Close(); }
            return result > 0;
        }
        public void exportToExcel(string excelFilePath)
        {
            DataTable customer = getAllCustomer();
            try
            {
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook wb = excel.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
                    Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)excel.ActiveSheet;
                    int i = 1;
                    int j = 1;
                    foreach (DataColumn column in customer.Columns)
                    {
                        ws.Cells[i, j] = column.ColumnName;
                        j++;
                    }
                    i++;
                    foreach (DataRow row in customer.Rows)
                    {
                        j = 1;
                        foreach (DataColumn column in customer.Columns)
                        {
                            ws.Cells[i, j] = row[column.ColumnName].ToString();
                            j++;
                        }
                        i++;
                    }

                    wb.SaveAs(excelFilePath);
                    wb.Close();
                    excel.Quit();
                
            }
            catch (Exception ex) { }
            finally { _con.Close(); }
        }
    }
}
