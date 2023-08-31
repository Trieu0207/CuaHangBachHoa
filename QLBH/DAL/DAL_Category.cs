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
    public class DAL_Category : DBConnect
    {
        public DataTable getAll()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Category", _con);
            DataTable cateTable = new DataTable();
            adapter.Fill(cateTable);
            return cateTable;
        }
        public DTO_Category get1Cate(int id)
        {
            DTO_Category cate = null;
            if (id > 0)
            {
                try
                {
                    _con.Open();
                    string query = "SELECT * FROM Category WHERE CategoryID = @cateid";
                    using(SqlCommand cmd = new SqlCommand(query, _con))
                    {
                        cmd.Parameters.AddWithValue("@cateid", id);
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                cate = new DTO_Category(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                            }
                        }
                    }
                } catch (Exception ex) { }
                finally { _con.Close(); }
            }
            return cate;
        }
        public DataTable getThongKeCate()
        {
            DataTable dt = new DataTable();
            string query = "select Category.categoryname, sum(BillDetail.quantity) As totalQuantity, " +
                           "CAST(SUM(BillDetail.quantity) * 100.0 / (SELECT SUM(quantity) FROM BillDetail) AS DECIMAL(18,2)) AS phantram " +
                           "From BillDetail " +
                           "INNER JOIN Product on Product.ProductID = BillDetail.ProductID " +
                           "Inner join Category on Category.CategoryID = Product.CategoryID " +
                           "Group by Category.categoryname";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _con);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable getTop5Cate()
        {
            DataTable dt = new DataTable();
            string query = "select Top 5 Category.categoryname, sum(BillDetail.quantity) As totalQuantity " +
                           "From BillDetail " +
                           "INNER JOIN Product on Product.ProductID = BillDetail.ProductID " +
                           "Inner join Category on Category.CategoryID = Product.CategoryID " +
                           "Group by Category.categoryname";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _con);
            adapter.Fill(dt);
            return dt;
        }
        public int getIdByNameCate(string name)
        {
            int result = 0;
            try
            {
                _con.Open();
                string query = "SELECT CategoryID FROM Category WHERE categoryname = @name";
                using( SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue ("@name", name);
                    using( SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        result = reader.GetInt32(0);
                    }
                }
            } catch (Exception ex) { }
            finally { _con.Close();}
            return result;
        }
        public string getNameByIdCate(int id)
        {
            string result = null;
            try
            {
                _con.Open();
                string query = "SELECT categoryname FROM Category WHERE CategoryID = @id";
                using(SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        result = reader.GetString(0);
                    }

                }
            } catch (Exception ex) { }
            finally { _con.Close(); }
            return result;
        }
        public List<string> getNameCate()
        {
            List<string> names = new List<string>();
            try
            {
                _con.Open();
                string query = "SELECT categoryname FROM Category";
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            names.Add(reader["categoryname"].ToString());
                        }
                    }
                }

            }
            catch (Exception ex) { }
            finally { _con.Close(); }
            return names;
        }
        public bool addCate(string name, string des)
        {
            int result = 0;
            try
            {
                _con.Open();
                string query = "INSERT INTO Category (categoryname, CategoryDescription) VALUES (@name, @des) ";
                using(SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@des", des);
                    result = cmd.ExecuteNonQuery();
                }
                
            } catch(Exception ex) { }
            finally { _con.Close(); }
            return result > 0;
        }
        public bool delCate(int id)
        {
            int result = 0;
            try
            {
                _con.Open();
                string query = "DELETE FROM Category WHERE CategoryID=@id";
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    result = cmd.ExecuteNonQuery();
                }
            } catch(Exception ex) { }
            finally { _con.Close(); }
            return result > 0;
        }
        public bool updateCate(int id, string name, string des)
        {
            int result = 0;
            try
            {
                _con.Open();
                string query = "UPDATE Category SET categoryname = @name, CategoryDescription = @des WHERE CategoryID=@id";
                using( SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@des", des);
                    cmd.Parameters.AddWithValue("@id", id);
                    result = cmd.ExecuteNonQuery();
                }
            }catch(Exception ex) { }
            finally { _con.Close(); }
            return result > 0;
        }
        public void exportToExcel(string excelFilePath)
        {
            string table = "Category";
            string query = "SELECT * FROM Category";
            DataTable categorys = getAll();
            try
            {
                _con.Open();
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(categorys);
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook wb = excel.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
                    Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)excel.ActiveSheet;
                    int i = 1;
                    int j = 1;
                    foreach (DataColumn column in categorys.Columns)
                    {
                        ws.Cells[i, j] = column.ColumnName;
                        j++;
                    }
                    i++;
                    foreach (DataRow row in categorys.Rows)
                    {
                        j = 1;
                        foreach (DataColumn column in categorys.Columns)
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
            } catch(Exception ex) { }
            finally { _con.Close(); }
        }
        public void exportDoanhThuCateToExcel(DataTable data, string excelFilePath)
        {
            try
            {
                _con.Open();  
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
            catch (Exception ex) { }
            finally { _con.Close(); }
        }
    }
}
