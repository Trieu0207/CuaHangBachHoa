using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Globalization;

namespace BUS
{
    public class BUS_QLBH
    {
        DAL_UserApp userApp = new DAL_UserApp();
        DAL_Employee employee = new DAL_Employee();
        DAL_Category category = new DAL_Category();
        DAL_Product product = new DAL_Product();
        DAL_Bill bill = new DAL_Bill();
        DAL_BillDetail billDetail = new DAL_BillDetail();
        DAL_Customer customer = new DAL_Customer();
        DAL_Customer_Bill cus_bill = new DAL_Customer_Bill();
        public static DTO_UserApp currentUser = new DTO_UserApp();





        public DTO_UserApp get1User(string username, string password)
        {
            return userApp.getUser(username, password);
        }
        public DataTable getAllUser()
        {
            return userApp.getAllUser();
        }
        public bool check_username(string username)
        {
            return userApp.check_username(username);
        }
        public bool check_user(string username, int employeeID)
        {
            return userApp.check_user(username, employeeID);
        }
        public bool check_user(string name, string pass)
        {
            return userApp.check_user(name, pass);
        }
        public bool addUser(int txtID, string txtUsername, string txtPassword, string txtRole)
        {
            return userApp.addUser(txtID, txtUsername, txtPassword, txtRole);
        }
        public bool delUser(string  username, string password)
        {
            return userApp.delUser(username, password);
        }
        public bool updateUser(int EmployeeID, string username, string passeword, string role, string selectUsername, string selectPassword)
        {
            return userApp.update(EmployeeID, username, passeword, role, selectUsername, selectPassword);
        }
        public bool changePass(string username, string pass)
        {
            return userApp.changePass(username, pass);
        }




        public DataTable getAllEmployee()
        {
            return employee.getAllEmployee();
        }
        public bool addEmplyee(string firstname, string lastname, string gioitinh, string phone, string email, string ngaysinh, string diaChi)
        {
            return employee.addEmplyee(firstname, lastname, gioitinh, phone, email, ngaysinh, diaChi);

        }
        public bool delEmployee(int id)
        {
            return employee.delEmployee(id);
        }
        public bool updateEmployee(int emID, string firstname, string lastname,
                                    string gioitinh, string phone, string email, string ngaysinh, string diachi)
        {
            return employee.updateEmployee(emID, firstname, lastname, gioitinh, phone, email, ngaysinh, diachi);
        }
        public void saveEmployeeToExcel(string excelFilePath)
        {
            employee.saveToExcel(excelFilePath);
        }





        public string getNameByIdCate(int id)
        {
            return category.getNameByIdCate(id);
        }
        public int getIdByNameCate(string name)
        {
            return category.getIdByNameCate(name);
        }
        public List<string> getNameCate()
        {
            return category.getNameCate();
        }
        public DataTable getAllCate()
        {
            return category.getAll();
        }
        public DataTable getThongKeCate()
        {
            return category.getThongKeCate();
        }
        public DataTable getTop5Cate()
        {
            return category.getTop5Cate();
        }
        public bool addCate(string name, string des)
        {
            return category.addCate(name, des);
        }
        public bool delCate(int id)
        {
            return category.delCate(id);
        }
        public bool updateCate(int id, string name, string des)
        {
            return category.updateCate(id, name, des);
        }
        public void exportToExcel(string excelFilePath)
        {
            category.exportToExcel(excelFilePath);
        }
        public void exportDoanhThuCateToExcel(DataTable data, string excelFilePath)
        {
            category.exportDoanhThuCateToExcel(data, excelFilePath);
        }





        public DataTable getProductQuantity()
        {
            return product.getProductQuantity();
        }
        public DataTable getTop5Product()
        {
            return product.getTop5();
        }
        public DataTable getThongkeProduct()
        {
            return product.getThongkeProduct();
        }
        public DataTable getAllProduct()
        {
            return product.getAllProduct();
        }
        public DTO_Product get1Product(int id)
        {
            return product.get1Product(id);
        }
        public int getIdProductByName(String name)
        {
            return product.getIdProductByName(name);
        }
        public bool addProduct(string productName, int categoryID, float price, int quantity, string note)
        {
            return product.addProduct(productName, categoryID, price, quantity, note);
        }
        public bool delProduct(int id)
        {
            return product.delProduct(id);
        }
        public bool updateProduct(int id, string productName, int categoryID, float price, int quantity, string note)
        {
            return product.updateProduct(id, productName, categoryID, price, quantity, note);
        }
        public void exportProductToExcel(string excelFilePath)
        {
            product.exportProductToExcel(excelFilePath);
        }
        public bool minusQuantity(int id, int quantity)
        {
            return product.minusQuantity(id, quantity);
        }
        public int getquantity(int id)
        {
            return product.getquantity(id);
        }
        public bool addquantity(int id, int quantity)
        {
            return product.addquantity(id, quantity);
        }
        public void exportTopProductToExcel(string excelFilePath)
        {
            product.exportTopProductToExcel(excelFilePath);
        }
        public void exportDoanhThuProduct(DataTable data, string excelFilePath)
        {
            product.exportDoanhThuProduct(data, excelFilePath);
        }




        public DataTable getAllBill()
        {
            return bill.getAllBill();
        }
        public DataTable getBillInDay(string time)
        {
            return bill.getBillInDay(time);
        }
        public DataTable getDoanhThu1Nam()
        {
            return bill.getDoanhThu1Nam();
        }
        public DTO_Bill get1Bill(int id)
        {
            return bill.get1Bill(id);
        }
        public DTO_Bill getBillByTime(DateTime time)
        {
            return bill.getBillByTime(time);
        }
        public bool addBill(DateTime time, int userid, float price)
        {
            return bill.addBill(time, userid, price);
        }
        
        public bool delBill(int id)
        {
            return bill.delBill(id);
        }
        public void exportBillToExcel(DataTable data, string excelFilePath)
        {
            bill.exportToExcel(data, excelFilePath);
        }
        










        public DataTable getAllBillDetail()
        {
            return billDetail.getAllBillDetail();
        }
        public DataTable getBillDetailByBillid(int id)
        {
            return billDetail.getBillDetailByBillid(id);
        }
        public bool addBillDetail(int billID, int productID, string productname, int quantity, float unitPrice)
        {
            return billDetail.addBillDetail(billID, productID, productname, quantity, unitPrice);
        }
        public bool delBillDetailById(int id)
        {
            return billDetail.delBillDetailById(id);
        }
        public bool delBillDetailByBillId(int id)
        {
            return billDetail.delBillDetailByBillId(id);
        }





        public DataTable getAllCustomer()
        {
            return customer.getAllCustomer();
        }
        public DTO_Customer get1Customer(int id)
        {
            return customer.get1Customer(id);
        }
        public bool addCustomer(string name, string addr, string sdt)
        {
            return customer.addCustomer(name, addr, sdt);
        }
        public bool delCustomer(int id)
        {
            return customer.delCustomer(id);
        }
        public bool updateCustomer(int id, string name, string addr, string sdt)
        {
            return customer.updateCustomer(id, name, addr, sdt);
        }
        public bool addPoint(int id, int point)
        {
            return customer.addPoint(id, point);
        }
        public void exportCustomerToExcel(string file)
        {
             customer.exportToExcel(file);
        }


        public bool addCus_bill(int cusid, int billid)
        {
            return cus_bill.add(cusid, billid);
        }

    }
}
