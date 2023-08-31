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
    public class DAL_Bill : DBConnect
    {
        public DataTable getAllBill()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Product", _con);
            DataTable bills = new DataTable();
            adapter.Fill(bills);
            return bills;
            
        }
        public DataTable getBillInDay(string time)
        {
            DataTable bills = new DataTable();
            string fromTimeString = string.Format("{0} 00:00:00", time);
            string toTimeString = string.Format("{0} 23:59:59", time);
            try
            {
                _con.Open();
                string query = string.Format("SELECT * FROM Bill WHERE Time >= '{0}' AND Time <= '{1}'", fromTimeString, toTimeString);
                SqlDataAdapter adapter = new SqlDataAdapter(query, _con);
                adapter.Fill(bills);
            }
            catch (Exception ex) { }
            finally { _con.Close(); }
            return bills;
        }
        public DTO_Bill get1Bill(int id)
        {
            DTO_Bill bill = null;
            try
            {
                _con.Open();
                string query = "SELECT * From Bill WHERE BillID =@id";
                using(SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                          
                            
                            float temp = (float)reader.GetDouble(3);
                            string tempTime = reader.GetDateTime(1).ToString("dd/MM/yyyy HH:mm:ss");
                            DateTime tempDateTime = DateTime.Parse(tempTime);
                            bill = new DTO_Bill(reader.GetInt32(0), tempDateTime, reader.GetInt32(2), temp);
                        }
                    }
                }
            }
            catch (Exception ex) { }
            finally { _con.Close(); }
            return bill;
        }
        public DataTable getDoanhThu1Nam()
        {
            DataTable doanhthu = new DataTable();
            try
            {
                _con.Open();
                string query = "WITH CTE_Months AS (SELECT 1 AS Thang " +
                             "UNION SELECT 2 AS Thang " +
                             "UNION SELECT 3 AS Thang " +
                             "UNION SELECT 4 AS Thang " +
                             "UNION SELECT 5 AS Thang " +
                             "UNION SELECT 6 AS Thang " +
                             "UNION SELECT 7 AS Thang " +
                             "UNION SELECT 8 AS Thang " +
                             "UNION SELECT 9 AS Thang " +
                             "UNION SELECT 10 AS Thang " +
                             "UNION SELECT 11 AS Thang " +
                             "UNION SELECT 12 AS Thang) " +
                             "SELECT CTE_Months.Thang, ISNULL(SUM(Bill.totalprice), 0) AS DoanhThu " +
                             "FROM CTE_Months " +
                             "LEFT JOIN Bill ON MONTH(Bill.Time) = CTE_Months.Thang AND YEAR(Bill.Time) = YEAR(GETDATE()) " +
                             "GROUP BY CTE_Months.Thang " +
                             "ORDER BY CTE_Months.Thang";
                SqlDataAdapter adapter = new SqlDataAdapter(query,_con);
                adapter.Fill(doanhthu);
            }
            catch (Exception ex) { }
            finally { _con.Close(); }
            return doanhthu;
        }
        public void exportToExcel(DataTable data, string excelFilePath)
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
       
        public DTO_Bill getBillByTime(DateTime time)
        {
            DTO_Bill bill = null;
            try
            {
                _con.Open();
                string query = "SELECT * FROM Bill WHERE time = @time";
                using( SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@time", time.ToString("yyyy-MM-dd HH:mm:ss"));
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                           
                            string dateString = reader.GetDateTime(1).ToString("dd/MM/yyyy HH:mm:ss");
                            DateTime testtime = DateTime.Parse(dateString);
                            float temp = (float)reader.GetDouble(3);
                            bill = new DTO_Bill(reader.GetInt32(0), testtime, reader.GetInt32(2), temp);
                        }
                    }
                }
            }
            catch(Exception ex) { }
            finally { _con.Close(); }
            return bill;
        }
        //public bool testbill()
        //{
        //    int result = 0;
        //    try
        //    {
        //        _con.Open();
        //        DateTime time = DateTime.Now;
        //        int userid = 1;
        //        float price = 150000;
        //        string query = "INSERT INTO Bill (Time, UserID, totalprice) VALUES (@Time, @userid, @price)";
        //        using (SqlCommand cmd = new SqlCommand(query, _con))
        //        {
        //            cmd.Parameters.AddWithValue("@Time", time);
        //            cmd.Parameters.AddWithValue("@userid", userid);
        //            cmd.Parameters.AddWithValue("@price", price);
        //            result = cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex) { }
        //    finally { _con.Close(); }
        //    return result > 0;

        //}
        public bool addBill(DateTime time, int userid, float price)
        {
            int result = 0;
            try
            {
                _con.Open();
                string query = "INSERT INTO Bill (Time, UserID, totalprice) VALUES (@Time, @userid, @price)";
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@Time", time.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@userid", userid);
                    cmd.Parameters.AddWithValue("@price", price);
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { }
            finally { _con.Close(); }



            return result > 0;
        }
        public bool delBill(int id)
        {
            int result = 0;
            try
            {
                _con.Open();
                string query = "DELETE FROM Bill WHERE BillID = @id";
                using(SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    result = cmd.ExecuteNonQuery();
                }
            }catch (Exception ex) { }
            finally { _con.Close(); }

            return result > 0;
        }
    }
}
