using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLBH
{
    public partial class fmHangHoa : Form
    {
        BUS_QLBH bus = new BUS_QLBH();
        public fmHangHoa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fmHangHoa_Load(object sender, EventArgs e)
        {
            Series salesSeries = new Series("Category"); // Tạo một chuỗi dữ liệu mới với tên "Doanh số"
            salesSeries.ChartType = SeriesChartType.Column; // Thiết lập kiểu biểu đồ là cột
            foreach (DataRow row in bus.getTop5Cate().Rows)
            {
                string xValue = row["Categoryname"].ToString(); // Lấy giá trị của cột "Thang" làm giá trị trục x
                double yValue = Convert.ToDouble(row["totalQuantity"]); // Lấy giá trị của cột "DoanhSo" làm giá trị trục y
                salesSeries.Points.AddXY(xValue, yValue); // Thêm điểm dữ liệu vào chuỗi dữ liệu
            }
            chartCate1.Series.Add(salesSeries); // Thêm chuỗi dữ liệu vào biểu đồ
            chartCate1.Titles.Add("Top 5 loại hàng bán chạy nhất"); // Thiết lập tiêu đề cho biểu đồ
            chartCate1.ChartAreas[0].AxisX.Title = "loại hàng"; // Thiết lập tiêu đề cho trục x
            chartCate1.ChartAreas[0].AxisY.Title = "Doanh Thu"; // Thiết lập tiêu đề cho trục y 


 
            chartCate2.Series.Clear();
            Series salesSeries2 = new Series("Category");
            salesSeries2.ChartType = SeriesChartType.Doughnut;
            salesSeries2.IsValueShownAsLabel = true; // Hiển thị giá trị của mỗi phần trăm trên biểu đồ
            salesSeries2.LabelFormat = "#.#%"; // Định dạng hiển thị giá trị phần trăm
            foreach (DataRow row in bus.getThongKeCate().Rows)
            {
                string xValue = row["Categoryname"].ToString(); // Lấy giá trị của cột "LoaiSanPham" làm tên loại sản phẩm
                double yValue = Convert.ToDouble(row["phantram"]) / 100; // Lấy giá trị của cột "DoanhSo" làm giá trị phần trăm
                salesSeries2.Points.AddXY(xValue, yValue); // Thêm điểm dữ liệu vào chuỗi dữ liệu
            }
            chartCate2.Series.Add(salesSeries2); // Thêm chuỗi dữ liệu vào biểu đồ



            chartProduct1.Series.Clear();
            Series salesSeries3 = new Series("Product"); // Tạo một chuỗi dữ liệu mới với tên "Doanh số"
            salesSeries.ChartType = SeriesChartType.Column; // Thiết lập kiểu biểu đồ là cột
            foreach (DataRow row in bus.getTop5Product().Rows)
            {
                string xValue = row["productname"].ToString(); // Lấy giá trị của cột "Thang" làm giá trị trục x
                double yValue = Convert.ToDouble(row["totalQuantity"]); // Lấy giá trị của cột "DoanhSo" làm giá trị trục y
                salesSeries3.Points.AddXY(xValue, yValue); // Thêm điểm dữ liệu vào chuỗi dữ liệu
            }
            chartProduct1.Series.Add(salesSeries3); // Thêm chuỗi dữ liệu vào biểu đồ
            chartProduct1.Titles.Add("Top 5 mặt hàng bán chạy nhất"); // Thiết lập tiêu đề cho biểu đồ
            chartProduct1.ChartAreas[0].AxisX.Title = "Mặt hàng"; // Thiết lập tiêu đề cho trục x
            chartProduct1.ChartAreas[0].AxisY.Title = "Doanh Thu"; // Thiết lập tiêu đề cho trục y 






            chartProduct2.Series.Clear();
            Series salesSeries4 = new Series("Category");
            salesSeries4.ChartType = SeriesChartType.Doughnut;
            salesSeries4.IsValueShownAsLabel = true; // Hiển thị giá trị của mỗi phần trăm trên biểu đồ
            salesSeries4.LabelFormat = "#.##%"; // Định dạng hiển thị giá trị phần trăm
            foreach (DataRow row in bus.getThongkeProduct().Rows)
            {
                string xValue = row["productname"].ToString(); // Lấy giá trị của cột "LoaiSanPham" làm tên loại sản phẩm
                double yValue = Convert.ToDouble(row["phantram"]) / 100; // Lấy giá trị của cột "DoanhSo" làm giá trị phần trăm
                salesSeries4.Points.AddXY(xValue, yValue); // Thêm điểm dữ liệu vào chuỗi dữ liệu
            }
            chartProduct2.Series.Add(salesSeries4); // Thêm chuỗi dữ liệu vào biểu đồ





            // đổ dữ liệu vào datagridview
            dgvCate.DataSource = bus.getThongKeCate();
            dgvProduct.DataSource = bus.getThongkeProduct();
        }

        private void btnCate_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bus.exportBillToExcel(bus.getThongKeCate(), saveFileDialog.FileName);
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bus.exportBillToExcel(bus.getThongkeProduct(), saveFileDialog.FileName);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
