using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Tinhdiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btntinhtb_Click(object sender, EventArgs e)
        {
            if (txtso2.Text == "" || txtso3.Text == "")
            {
                MessageBox.Show("Phải nhập tên, toán, văn");
                return;
            }
            Double toan, van, TB, XL;
            toan = Convert.ToDouble(txtso2.Text);
            van = Convert.ToDouble(txtso3.Text);
            TB = (toan + van) / 2;
            txtso4.Text = TB.ToString();
            if (TB < 5)
            {
                txtso5.Text = "yếu";
            }
            else if (TB < 6)
            {
                txtso5.Text = "Trung bình";
            }
            else if (TB < 8)
            {
                txtso5.Text = "Khá";
            }
            else
            {
                txtso5.Text = "Giỏi";
            }
        }
    }
    }
