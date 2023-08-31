using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Employees
    {
        private int EmployeeID;
        private string firstname;
        private string lastname;
        private string Gioitinh;
        private string phone;
        private string email;
        private DateTime Ngaysinh;


        public DTO_Employees() { }
        public DTO_Employees(int employeeID, string firstname, string lastname, string gioitinh, string phone, string email, DateTime ngaysinh)
        {
            EmployeeID = employeeID;
            this.firstname = firstname;
            this.lastname = lastname;
            Gioitinh = gioitinh;
            this.phone = phone;
            this.email = email;
            Ngaysinh = ngaysinh;
        }
        public DTO_Employees( string firstname, string lastname, string gioitinh, string phone, string email, DateTime ngaysinh)
        { 
            this.firstname = firstname;
            this.lastname = lastname;
            Gioitinh = gioitinh;
            this.phone = phone;
            this.email = email;
            Ngaysinh = ngaysinh;
        }
        public int EmployeeID1 { get => EmployeeID; set => EmployeeID = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Gioitinh1 { get => Gioitinh; set => Gioitinh = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Ngaysinh1 { get => Ngaysinh; set => Ngaysinh = value; }
    }
}
