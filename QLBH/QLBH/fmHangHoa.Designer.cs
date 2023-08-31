namespace QLBH
{
    partial class fmHangHoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartProduct2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProduct1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCate1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCate = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.dgvCate = new System.Windows.Forms.DataGridView();
            this.chartCate2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCate1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCate2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1163, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Hàng Hóa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chartProduct2);
            this.groupBox1.Controls.Add(this.chartProduct1);
            this.groupBox1.Controls.Add(this.chartCate2);
            this.groupBox1.Controls.Add(this.chartCate1);
            this.groupBox1.Location = new System.Drawing.Point(0, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 609);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Biểu đồ Biểu Diễn";
            // 
            // chartProduct2
            // 
            chartArea17.Name = "ChartArea1";
            this.chartProduct2.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            this.chartProduct2.Legends.Add(legend17);
            this.chartProduct2.Location = new System.Drawing.Point(406, 314);
            this.chartProduct2.Name = "chartProduct2";
            series17.ChartArea = "ChartArea1";
            series17.Legend = "Legend1";
            series17.Name = "Series1";
            this.chartProduct2.Series.Add(series17);
            this.chartProduct2.Size = new System.Drawing.Size(328, 289);
            this.chartProduct2.TabIndex = 0;
            this.chartProduct2.Text = "chart1";
            // 
            // chartProduct1
            // 
            chartArea18.Name = "ChartArea1";
            this.chartProduct1.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.chartProduct1.Legends.Add(legend18);
            this.chartProduct1.Location = new System.Drawing.Point(6, 314);
            this.chartProduct1.Name = "chartProduct1";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "Series1";
            this.chartProduct1.Series.Add(series18);
            this.chartProduct1.Size = new System.Drawing.Size(394, 289);
            this.chartProduct1.TabIndex = 0;
            this.chartProduct1.Text = "chart1";
            // 
            // chartCate1
            // 
            chartArea19.Name = "ChartArea1";
            this.chartCate1.ChartAreas.Add(chartArea19);
            legend19.Name = "Legend1";
            this.chartCate1.Legends.Add(legend19);
            this.chartCate1.Location = new System.Drawing.Point(6, 19);
            this.chartCate1.Name = "chartCate1";
            this.chartCate1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series19.ChartArea = "ChartArea1";
            series19.Legend = "Legend1";
            series19.Name = "Series1";
            this.chartCate1.Series.Add(series19);
            this.chartCate1.Size = new System.Drawing.Size(394, 289);
            this.chartCate1.TabIndex = 0;
            this.chartCate1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnProduct);
            this.groupBox2.Controls.Add(this.btnCate);
            this.groupBox2.Controls.Add(this.dgvProduct);
            this.groupBox2.Controls.Add(this.dgvCate);
            this.groupBox2.Location = new System.Drawing.Point(746, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 612);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng Thống Kê";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Maroon;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(3, 560);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(411, 49);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.SystemColors.Control;
            this.btnProduct.ForeColor = System.Drawing.Color.Green;
            this.btnProduct.Location = new System.Drawing.Point(258, 298);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(147, 23);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Xuất sản Phẩm";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCate
            // 
            this.btnCate.ForeColor = System.Drawing.Color.Green;
            this.btnCate.Location = new System.Drawing.Point(258, 11);
            this.btnCate.Name = "btnCate";
            this.btnCate.Size = new System.Drawing.Size(147, 23);
            this.btnCate.TabIndex = 1;
            this.btnCate.Text = "Xuất loại hàng hóa";
            this.btnCate.UseVisualStyleBackColor = true;
            this.btnCate.Click += new System.EventHandler(this.btnCate_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(6, 327);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(399, 226);
            this.dgvProduct.TabIndex = 0;
            // 
            // dgvCate
            // 
            this.dgvCate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCate.BackgroundColor = System.Drawing.Color.White;
            this.dgvCate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCate.Location = new System.Drawing.Point(3, 40);
            this.dgvCate.Name = "dgvCate";
            this.dgvCate.Size = new System.Drawing.Size(402, 252);
            this.dgvCate.TabIndex = 0;
            // 
            // chartCate2
            // 
            chartArea20.Name = "ChartArea2";
            this.chartCate2.ChartAreas.Add(chartArea20);
            legend20.Name = "Legend1";
            this.chartCate2.Legends.Add(legend20);
            this.chartCate2.Location = new System.Drawing.Point(406, 19);
            this.chartCate2.Name = "chartCate2";
            series20.ChartArea = "ChartArea2";
            series20.Legend = "Legend1";
            series20.Name = "Series1";
            this.chartCate2.Series.Add(series20);
            this.chartCate2.Size = new System.Drawing.Size(328, 289);
            this.chartCate2.TabIndex = 0;
            this.chartCate2.Text = "chart1";
            // 
            // fmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1163, 706);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "fmHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmHangHoa";
            this.Load += new System.EventHandler(this.fmHangHoa_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCate1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCate2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCate1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduct1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduct2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridView dgvCate;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCate;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCate2;
    }
}