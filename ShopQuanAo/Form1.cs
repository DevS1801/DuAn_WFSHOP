using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopQuanAo
{
    public partial class ShopHDD : Form
    {
        public ShopHDD()
        {
            InitializeComponent();
        }
        #region event
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien f = new FrmNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuanLi f = new FrmQuanLi();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBanHang f = new FrmBanHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongKe f = new FrmThongKe();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhachHang f = new FrmKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoiMk f = new FrmDoiMk();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion



        #region Method


        #endregion
    }
}
