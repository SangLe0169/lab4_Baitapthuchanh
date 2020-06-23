using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Lab4
{
    public partial class NhanVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string maNV;
        public NhanVien()
        {
            InitializeComponent();
        }
        doimatkhau fdoimatkhau;
        public void enableControl(int maLTK)
        {
            switch(maLTK)
            {
                case 1:
                    btnDangxuat.Enabled = true;
                    btnDoimatkhau.Enabled = true;
                    btnNhanvien.Enabled = true;
                    btnChamcong.Enabled = true;
                    btnLoaisanpham.Enabled = true;
                    btnDonhang.Enabled = true;
                    btnKhachhang.Enabled = true;
                    btnTaohoadon.Enabled = true;
                    btnDoanhthu.Enabled = true;
                    break;
                case 2:
                    btnDangxuat.Enabled = true;
                    btnDoimatkhau.Enabled = true;
                    btnNhanvien.Enabled = false;
                    btnChamcong.Enabled = false;
                    btnLoaisanpham.Enabled = false;
                    btnSanpham.Enabled = false;
                    btnDonhang.Enabled = false;
                    btnKhachhang.Enabled = true;
                    btnTaohoadon.Enabled = true;
                    btnDoanhthu.Enabled = false;
                    break;
                case 3:
                    btnDangxuat.Enabled = true;
                    btnDoimatkhau.Enabled = true;
                    btnNhanvien.Enabled = false;
                    btnChamcong.Enabled = false;
                    btnLoaisanpham.Enabled = true;
                    btnSanpham.Enabled = true;
                    btnDonhang.Enabled = false;
                    btnKhachhang.Enabled = false;
                    btnTaohoadon.Enabled = false;
                    btnDoanhthu.Enabled = false;
                    break;
                default:
                    btnDangxuat.Enabled = false;
                    btnDoimatkhau.Enabled = false;
                    btnNhanvien.Enabled = false;
                    btnChamcong.Enabled = false;
                    btnLoaisanpham.Enabled = false;
                    btnSanpham.Enabled = false;
                    btnDonhang.Enabled = false;
                    btnKhachhang.Enabled = false;
                    btnTaohoadon.Enabled = false;
                    btnDoanhthu.Enabled = false;
                    break;
            }
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            enableControl(-1);
            Dangnhap f = new Dangnhap();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.WindowState = FormWindowState.Normal;
            f.Show();
        }

        private void btnDangxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabControlMain.TabPages.Clear();
            NhanVien_Load(sender, e);
        }

        private void btnDoimatkhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fdoimatkhau == null)
            {
                fdoimatkhau = new doimatkhau();
                fdoimatkhau.MdiParent = this;
                fdoimatkhau.WindowState = FormWindowState.Maximized;
                fdoimatkhau.Show();
            }
            else
            {
                fdoimatkhau.Activate();
                fdoimatkhau.Show();
            }
        }
    }
}