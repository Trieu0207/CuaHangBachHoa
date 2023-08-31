using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_UserApp
    {
        private int UserID;
        private int EmployeeID;
        private string username;
        private string password;
        private string user_role;


        public DTO_UserApp() { }
        public DTO_UserApp(int employeeID, string username, string password, string user_role)
        {
            this.EmployeeID = employeeID;
            this.username = username;
            this.password = password;
            this.user_role = user_role;
        }
        public DTO_UserApp(int userID, int employeeID, string username, string password, string user_role)
        {
            UserID = userID;
            EmployeeID = employeeID;
            this.username = username;
            this.password = password;
            this.user_role = user_role;
        }

        public int UserID1 { get => UserID; set => UserID = value; }
        public int EmployeeID1 { get => EmployeeID; set => EmployeeID = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string User_role { get => user_role; set => user_role = value; }
    }
}
