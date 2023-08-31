using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_UserApp: DBConnect
    {
        public DataTable getAllUser()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.UserApp", _con);
            DataTable user = new DataTable();
            adapter.Fill(user);
            return user;
        }
        public DTO_UserApp getUser(string username, string password)
        {
            DTO_UserApp user = null;
            try
            {
                _con.Open();
                string dataQuery = "SELECT * FROM UserApp WHERE username=@username and password=@password";
                using (SqlCommand cmd = new SqlCommand(dataQuery, _con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new DTO_UserApp(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                        }
                    }
                }
            } catch (Exception ex) {}
            finally { _con.Close(); }
            return user;
        }
        public string hashListMd5(string pass)
        {
            byte[] inputByte = Encoding.UTF8.GetBytes(pass);
            MD5 md5 = MD5.Create();
            byte[] hashByte = md5.ComputeHash(inputByte);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashByte ) sb.Append(b.ToString("x2"));
            return sb.ToString();

        }
        public bool check_username(string username)
        {
            bool result = false;
            try
            {
                _con.Open();
                string check_username_query = "SELECT UserID from UserApp WHERE username =@username ";
                using (SqlCommand cmd = new SqlCommand(check_username_query, _con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) result = true;

                    }
                }
            } catch (Exception ex) { }
            finally { _con.Close(); }
            return result;
        }
        public bool check_user(string username, int employeeID)
        {
            bool result = false;
            try
            {
                _con.Open();
                string check_username_query = "SELECT UserID from UserApp WHERE username =@username or EmployeeID =@employeeID";
                using(SqlCommand cmd = new SqlCommand(check_username_query, _con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);
                   using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = true;
                        }
                    }
                }
            }catch (Exception ex) { }
            finally { _con.Close(); }
            return result;
        }
        public bool check_user(string username, string pass)
        {
            bool result = false;
            try
            {
                _con.Open();
                string query = "SELECT * FROM UserApp WHERE username=@username AND password=@password";
                using(SqlCommand cmd=new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", pass);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = true;
                        }
                    }
                }
            } catch (Exception ex) { }
            finally { _con.Close();}
            return result;
        }
        public bool addUser(int txtID, string txtUsername, string txtPassword, string txtRole)
        {
           

            int result = 0;
            try
            {
                _con.Open(); 
                string query = "INSERT INTO UserApp (EmployeeID, username, password, user_role) VALUES (@txtID, @username, @password, @user_role);";
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@txtID", txtID);
                    cmd.Parameters.AddWithValue("@username", txtUsername);
                    cmd.Parameters.AddWithValue("@password", txtPassword);
                    cmd.Parameters.AddWithValue("@user_role", txtRole);
                    result = cmd.ExecuteNonQuery();
                } 
            }catch(Exception ex) { }
            finally { _con.Close(); }
            return result >= 1;
        }
        public bool delUser(string username, string password)
        {
            DTO_UserApp user = getUser(username, password);
            int result = 0;
            try
            {
                _con.Open();
                string query = "DELETE FROM UserApp WHERE UserID=@userid";
                using(SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@userid", user.UserID1);
                    result = cmd.ExecuteNonQuery();
                }
            }catch (Exception ex) { }
            finally { _con.Close(); }
            return (result >= 1);
        }
        public bool update(int EmployeeiD, string username, string password,string role, string selectUsername,string selectPassword)
        {
            int result = 0;
            DTO_UserApp user = getUser(selectUsername, selectPassword);
            try
            {
                _con.Open();
                string query = "UPDATE UserApp SET EmployeeID = @employeeid, username = @username, password = @password, user_role = @role WHERE UserID = @userid";
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@employeeid", EmployeeiD);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue ("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@userid", user.UserID1);
                    result = cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex) { }
            finally { _con.Close(); }
            return(result >= 1);
        }
        public bool changePass(string username, string password)
        {
            int result = 0;
            try
            {
                _con.Open();
                string query = "UPDATE UserApp SET password = @password WHERE username = @name";
                using(SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@name", username);
                    result = cmd.ExecuteNonQuery();
                }
            }catch (Exception ex) { }
            finally { _con.Close(); }
            return result > 0;
        }
    }
}
