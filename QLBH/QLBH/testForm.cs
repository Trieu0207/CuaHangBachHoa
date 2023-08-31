using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLBH
{
    public partial class testForm : Form
    {
        BUS_QLBH DangNhap = new BUS_QLBH();
        public testForm()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            DTO_UserApp user = DangNhap.get1User(username.Text, password.Text);
            if (user != null) MessageBox.Show("correct");
            else MessageBox.Show("sai cmnr");
        }

        private void testForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dATABASEQLBHDataSet.UserApp' table. You can move, or remove it, as needed.
            this.userAppTableAdapter.Fill(this.dATABASEQLBHDataSet.UserApp);

        }
    }
}
