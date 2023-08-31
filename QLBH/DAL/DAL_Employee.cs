using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace DAL
{
    public class DAL_Employee: DBConnect
    {
        public DataTable getAllEmployee()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.Employees", _con);
            DataTable Employees = new DataTable();
            adapter.Fill(Employees);
            return Employees;
        }
        public bool addEmplyee(string firstname, string lastname,string gioitinh, string phone, string email, string ngaysinh,string diaChi)
        {
            int result = 0;
            
            try
            {
                _con.Open();
                string query = "INSERT INTO Employees (firstname, lastname, Gioitinh, phone, email, Ngaysinh, diaChi) VALUES (@firstname, @lastname, @Gioitinh, @phone, @email, @Ngaysinh, @diaChi);";
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.Parameters.AddWithValue("@Gioitinh", gioitinh);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@Ngaysinh", ngaysinh);
                    cmd.Parameters.AddWithValue("@diaChi", diaChi);
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {  }
            finally { _con.Close(); }
            return result >= 1;

        }
        public DTO_Employees get1Employee(int id)
        {
            DTO_Employees employee = null;
            try
            {
                _con.Open();
                string query = "SELECT * FROM Emloyees WHERE EmployeeID = @employeeid";
                using(SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@employeeid", id);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employee = new DTO_Employees(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                                            reader.GetString(3), reader.GetString(4), reader.GetString(5),
                                                            reader.GetDateTime(5));
                        }
                    }
                }
            }catch(Exception ex) { }
            finally { _con.Close(); }
            return employee;
        }
        public bool delEmployee(int id)
        {
            int result = 0;
            try
            {
                _con.Open();
                string query = "DELETE FROM Employees WHERE EmployeeID=@id";
                using(SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    result = cmd.ExecuteNonQuery();
                }
            } catch (Exception ex) { }
            finally { _con.Close(); }
            return (result >= 1);
        }
        public bool updateEmployee(int emID,  string firstname, string lastname,
                                    string gioitinh, string phone, string email, string ngaysinh, string diachi)
        {
            int result = 0;
            string query = "UPDATE Employees SET firstname = @firstname, lastname = @lastname, Gioitinh = @gioitinh, phone =@phone, email=@email, Ngaysinh=@ngaysinh, diaChi=@diachi WHERE EmployeeID = @id";
            try
            {
                _con.Open();
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                    cmd.Parameters.AddWithValue("@diachi", diachi);
                    cmd.Parameters.AddWithValue("@id", emID);
                    result = cmd.ExecuteNonQuery();
                }
                return result > 0;
            }catch(Exception ex) { }
            finally { _con.Close(); }
            return (result >= 1);
        }
        public void saveToExcel(string excelFilePath)
        {
            string table = "Employees";
            string query = "SELECT * FROM Employees";
            DataTable employees = getAllEmployee();
            try
            {
                _con.Open();
                using(SqlCommand cmd = new SqlCommand(query, _con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(employees);
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook wb = excel.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
                    Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)excel.ActiveSheet;
                    int i = 1;
                    int j = 1;
                    foreach (DataColumn column in employees.Columns)
                    {
                        ws.Cells[i, j] = column.ColumnName;
                        j++;
                    }
                    i++;
                    foreach (DataRow row in employees.Rows)
                    {
                        j = 1;
                        foreach (DataColumn column in employees.Columns)
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
    }
}
