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
    public partial class fmThongKeDoanhThu : Form
    {
        BUS_QLBH bus = new BUS_QLBH();
        public fmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void fmThongKeDoanhThu_Load(object sender, EventArgs e)
        {


            Series salesSeries = new Series("DoanhThu"); // Tạo một chuỗi dữ liệu mới với tên "Doanh số"
            salesSeries.ChartType = SeriesChartType.Column; // Thiết lập kiểu biểu đồ là cột
            foreach (DataRow row in bus.getDoanhThu1Nam().Rows)
            {
                string xValue = row["Thang"].ToString(); // Lấy giá trị của cột "Thang" làm giá trị trục x
                double yValue = Convert.ToDouble(row["DoanhThu"]); // Lấy giá trị của cột "DoanhSo" làm giá trị trục y
                salesSeries.Points.AddXY(xValue, yValue); // Thêm điểm dữ liệu vào chuỗi dữ liệu
            }
            chart1.Series.Add(salesSeries); // Thêm chuỗi dữ liệu vào biểu đồ
            chart1.Titles.Add("Doanh Thu trong năm nay"); // Thiết lập tiêu đề cho biểu đồ
            chart1.ChartAreas[0].AxisX.Title = "Tháng"; // Thiết lập tiêu đề cho trục x
            chart1.ChartAreas[0].AxisY.Title = "Doanh Thu"; // Thiết lập tiêu đề cho trục y
            
            Series lineSeries = new Series("Tăng trưởng");
            lineSeries.ChartType = SeriesChartType.Line;
            lineSeries.Color = Color.Black;
            lineSeries.BorderWidth = 3;
            foreach (DataRow row in bus.getDoanhThu1Nam().Rows)
            {
                string month = row["Thang"].ToString();
                int revenue = Convert.ToInt32(row["DoanhThu"]);
                lineSeries.Points.AddXY(month, revenue);
            }
            chart1.Series.Add(lineSeries);
            chart1.Show();


            //Series salesSeries2 = new Series("Doanh số theo sản phẩm");
            //salesSeries2.ChartType = SeriesChartType.Pie;
            //salesSeries2.IsValueShownAsLabel = true; // Hiển thị giá trị của mỗi phần trăm trên biểu đồ
            //salesSeries2.LabelFormat = "#.#%"; // Định dạng hiển thị giá trị phần trăm
            //foreach (DataRow row in bus.getTop5().Rows)
            //{
            //    string xValue = row["productname"].ToString(); // Lấy giá trị của cột "LoaiSanPham" làm tên loại sản phẩm
            //    double yValue = Convert.ToDouble(row["TotalSold"]) / 100; // Lấy giá trị của cột "DoanhSo" làm giá trị phần trăm
            //    salesSeries2.Points.AddXY(xValue, yValue); // Thêm điểm dữ liệu vào chuỗi dữ liệu
            //}
            //chart2.Series.Add(salesSeries2); // Thêm chuỗi dữ liệu vào biểu đồ
            dgvThongKe.DataSource = bus.getDoanhThu1Nam();

        }

        private void xuấtFileExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string test = null;
            foreach (DataRow row in bus.getDoanhThu1Nam().Rows)
            {
                string xValue = row["Thang"].ToString();
                test += xValue + " ";
            }
            MessageBox.Show(test);
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    bus.exportTopProductToExcel(saveFileDialog.FileName);
            //}
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
               bus.exportBillToExcel(bus.getDoanhThu1Nam(), saveFileDialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
