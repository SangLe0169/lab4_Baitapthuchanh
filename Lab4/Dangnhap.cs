using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Lab4.Modules;

namespace Lab4
{
    public partial class Dangnhap : DevExpress.XtraEditors.XtraForm
    {
        //NhanVien fMain = null;
        
        public Dangnhap()
        {
            //fMain = pf;
            InitializeComponent();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }
        XLNHANVIEN tblNhanVien;
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            tblNhanVien = new XLNHANVIEN();
            var r = tblNhanVien.Select("Username='" + txtTendangnhap.Text + "' and Password='" + txtMatkhau.Text + "'" );
            if(r.Count()>0)
            {
                NhanVien f = (NhanVien)this.MdiParent;
                f.Text = "Quản Lý Nhà Sách - Chào" + r[0]["TenNV"].ToString();
                f.maNV = r[0]["MaNV"].ToString();
                f.enableControl((int)r[0]["MaLTK"]);
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (int)Keys.Enter)
            {
                btnDangnhap_Click(sender, e);
            }
        }

        private void Dangnhap_Enter(object sender, EventArgs e)
        {
            btnDangnhap_Click(sender, e);
        }
    }
}