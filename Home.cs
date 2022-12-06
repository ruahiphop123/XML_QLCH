using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weepoo_QuanLyCuaHangThucAnNhanh
{
    public partial class Home : Form
    {

        private Form formHienTai;

        private void moFormMenu(Form form)
        {
            if (formHienTai != null)
            {
                formHienTai.Close();
            }
            formHienTai = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            containerpanel.Controls.Add(form);
            containerpanel.Tag = form;
            form.BringToFront();
            form.Show();
        }
        public Home()
        {
            InitializeComponent();
            moFormMenu(new QuanLyNhanVien());
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            formHienTai.Close();
        }

        private void qlnhanvienclick_Click(object sender, EventArgs e)
        {
            moFormMenu(new QuanLyNhanVien());
        }

        private void qldanhmucclick_Click(object sender, EventArgs e)
        {
            moFormMenu(new QuanLyDanhMuc());
        }

        private void qlmonanclick_Click(object sender, EventArgs e)
        {
            moFormMenu(new QuanLyMonAn());

        }

        private void banhangclick_Click(object sender, EventArgs e)
        {
            moFormMenu(new BanHang());
        }

        private void saoluuclick_Click(object sender, EventArgs e)
        {
            moFormMenu(new SaoLuu());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            qlnhanvienclick_Click(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            qldanhmucclick_Click(sender, e);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            qlmonanclick_Click(sender, e);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            banhangclick_Click(sender, e);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            saoluuclick_Click(sender, e);
        }
    }
}
