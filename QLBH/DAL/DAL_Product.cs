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
    public class DAL_Product : DBConnect
    {
        public DataTable getAllProduct()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Product", _con);
            DataTable proTable = new DataTable();
            adapter.Fill(proTable);
            return proTable;
        }
        public DataTable getProductQuantity()
        {
            DataTable proTable = new DataTable();
            string query = "SELECT ProductID, productname, quantity FROM Product";
            SqlDataAdapter adapter = new SqlDataAdapter (query, _con);
            adapter.Fill(proTable);
            return proTable;
        }
        //public List<string> test(int id)
        //{
        //    List<string> list = new List<string>();
        //    int result = 0;
        //    try
        //    {
        //        _con.Open();
        //        string query = "SELECT * FROM Product WHERE ProductID = @id";
        //        using(SqlCommand cmd = new SqlCommand(query, _con))
        //        {
        //            cmd.Parameters.AddWithValue("@id", id);
        //            using(SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                if(reader.Read())
        //                {
        //                    list.Add(reader.GetInt32(0).ToString());
        //                    list.Add(reader.GetInt32(1).ToString());
        //                    list.Add(reader.GetString(2));
        //                    list.Add(reader.GetDouble(3).ToString());
        //                    list.Add(reader.GetInt32(4).ToString());
        //                    list.Add(reader.GetString(5));

        //                }
        //            }
        //        }
        //    }catch (Exception ex) { }
        //    finally { _con.Close(); }
        //    return list;
        //}
        public DataTable getTop5()
        {
            DataTable top5pro = new DataTable();
            try
            {
                _con.Open();
                string query = "select top 5 Product.productname, sum(BillDetail.quantity) as totalQuantity " +
                               "From BillDetail " +
                               "inner join Product on Product.productname = BillDetail.productname " +
                               "group by Product.productname";
                SqlDataAdapter adapter = new SqlDataAdapter ( query, _con);
                adapter.Fill(top5pro);
            }
            catch (Exception ex) { }
            finally { _con.Close(); }
            return top5pro;
        }
        public DataTable getThongkeProduct()
        {
            DataTable top5pro = new DataTable();
            try
            {
                _con.Open();
                string query = "select Product.productname, sum(BillDetail.quantity) AS totalquantity, " +
                               "CAST(SUM(BillDetail.quantity) * 100.0 / (SELECT SUM(quantity) FROM BillDetail) AS DECIMAL(18,2)) AS phantram " +
                               "From BillDetail " +
                               "Inner join Product on Product.ProductID = BillDetail.ProductID " +
                               "group by Product.productname";
                SqlDataAdapter adapter = new SqlDataAdapter(query, _con);
                adapter.Fill(top5pro);
            }
            catch (Exception ex) { }
            finally { _con.Close(); }
            return top5pro;
        }
        public int getIdProductByName(string name)
        {
            int result = 0;
            try
            {
                _con.Open();
                string query = "SELECT ProductID FROM Product WHERE productname =@name";
                using(SqlCommand cmd = new SqlCommand(query,_con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    using(SqlDataReader reader=cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            result = reader.GetInt32(0);
                        }
                    }
                }
            } catch (Exception ex) { }
            finally { _con.Close(); } ;
            return result;
        }
        public int getquantity(int id)
        {
            int result = 0;
            try
            {
                _con.Open();
                string query = "SELECT quantity FROM Product WHERE ProductID =@id";
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = reader.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception ex) { }
            finally { _con.Close(); }
            return result;
        }
        
        public DTO_Product get1Product(int id)
        {
            DTO_Product product = null;
            try
            {
                _con.Open();
                string query = "SELECT * FROM Product WHERE ProductID =@id";
                using(SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                       if(reader.Read())
                        {
                            float temp = (float)reader.GetDouble(3);
                            product = new DTO_Product(reader.GetInt32(0), reader.GetInt32(1), 
                                reader.GetString(2), temp, 
                                reader.GetInt32(4), reader.GetString(5));
                        }
                    }
                }
            } catch (Exception ex) { }
            finally { _con.Close(); }
            return product;
        }
        public bool minusQuantity(int id, int quantity)
        {
            int result = 0;
            int productquantity;
            int quantitydata = getquantity(id);
            if (quantitydata >= quantity) productquantity = quantitydata - quantity;
            else return false;
            try
            {
                _con.Open();
                string query = "UPDATE Product SET quantity=@quantity WHERE ProductID=@id";
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@quantity", productquantity);
                    cmd.Parameters.AddWithValue("@id", id);
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { }
            finally { _con.Close(); };
            return result > 0;
        }
       
        public bool addProduct(string productName, int categoryID, float price, int quantity, string note)
        {
            int result = 0;
            try
            {
                _con.Open();
                string query = "INSERT INTO Product (CategoryID, productname, price, quantity, note) VALUES (@categoryID, @productname, @price, @quantity, @note)";
                using(SqlCommand cmd =  new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                    cmd.Parameters.AddWithValue("@productName", productName);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@note", note);
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { }
            finally { _con.Close(); }
            return result > 0;
        }
        public bool delProduct(int id)
        {
            int result = 0;
            try
            {
                _con.Open();
                string query = "DELETE FROM Product WHERE ProductID=@id";
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    result = cmd.ExecuteNonQuery();
                }
            }catch (Exception ex) { }
            finally { _con.Close(); }
            return result > 0;
        }
        public bool updateProduct(int id,string productName, int categoryID, float price, int quantity, string note)
        {
            if (quantity < 0)
            {
                return false;
            }
            int result = 0;
            try
            {
                _con.Open();
                string query = "UPDATE Product SET categoryID = @cateid, productName = @name, price = @price, quantity=@quantity, note=@note WHERE ProductID=@id";
                using(SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@cateid", categoryID);
                    cmd.Parameters.AddWithValue("@name", productName);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@note", note);
                    cmd.Parameters.AddWithValue("@id", id);
                    result = cmd.ExecuteNonQuery ();
                }
            }
            catch (Exception ex) { }
            finally { _con.Close(); }
            return result > 0;
        }
        public bool addquantity(int id,int quantity)
        {
            int result = 0;
            int dataquantity = getquantity(id) + quantity;
            try
            {
                _con.Open();
                string query = "UPDATE Product SET quantity=@quantity WHERE ProductID=@id";
                using( SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@quantity", dataquantity);
                    cmd.Parameters.AddWithValue("@id", id);
                   result = cmd.ExecuteNonQuery();

                }
            } catch(Exception ex) { }
            finally { _con.Close(); }

            return result > 0;
        }
        public void exportDoanhThuProduct(DataTable data, string excelFilePath)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = excel.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)excel.ActiveSheet;
            int i = 1;
            int j = 1;
            foreach (DataColumn column in data.Columns)
            {
                ws.Cells[i, j] = column.ColumnName;
                j++;
            }
            i++;
            foreach (DataRow row in data.Rows)
            {
                j = 1;
                foreach (DataColumn column in data.Columns)
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
        public void exportProductToExcel(string excelFilePath)
        {
            DataTable product = getAllProduct();
            try
            {
                _con.Open();
               
                    
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook wb = excel.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
                    Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)excel.ActiveSheet;
                    int i = 1;
                    int j = 1;
                    foreach (DataColumn column in product.Columns)
                    {
                        ws.Cells[i, j] = column.ColumnName;
                        j++;
                    }
                    i++;
                    foreach (DataRow row in product.Rows)
                    {
                        j = 1;
                        foreach (DataColumn column in product.Columns)
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
        public void exportTopProductToExcel(string excelFilePath)
        {
            
            try
            {
                _con.Open();
                string query = "SELECT Product.productname, COUNT(*) AS TotalSold " +
                               "FROM BillDetail " +
                               "JOIN Product ON BillDetail.ProductID = Product.ProductID " +
                               "GROUP BY Product.productname " +
                               "ORDER BY TotalSold DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, _con);
                DataTable product = new DataTable();
                adapter.Fill(product);

                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook wb = excel.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)excel.ActiveSheet;
                int i = 1;
                int j = 1;
                foreach (DataColumn column in product.Columns)
                {
                    ws.Cells[i, j] = column.ColumnName;
                    j++;
                }
                i++;
                foreach (DataRow row in product.Rows)
                {
                    j = 1;
                    foreach (DataColumn column in product.Columns)
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
