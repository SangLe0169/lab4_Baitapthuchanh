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
    public partial class doimatkhau : DevExpress.XtraEditors.XtraForm
    {
        public doimatkhau()
        {
            InitializeComponent();
        }

        private void doimatkhau_Load(object sender, EventArgs e)
        {

        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapnhap_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDoimatkhau, "");
            errorProvider1.SetError(txtNhaplaimatkhau, "");
            if(txtDoimatkhau.Text.Length<8 || !txtDoimatkhau.Text.Any(char.IsDigit)||!txtDoimatkhau.Text.Any(char.IsLower)||!txtDoimatkhau.Text.Any(char.IsUpper))
            {
                errorProvider1.SetError(txtDoimatkhau, "Mật khẩu mới tối thiểu 8 ký tự, gồm chữ số," + "in hoa, in thường");
                return;
            }
            if(txtDoimatkhau.Text != txtNhaplaimatkhau.Text)
            {
                errorProvider1.SetError(txtNhaplaimatkhau, "Mật khẩu nhập lại không đúng!!");
                return;
            }
            NhanVien f = (NhanVien)this.MdiParent;
            int count = XLBANG.Thuc_hien_lenh("Update NHANVIEN set Password ='" + txtDoimatkhau.Text + "'where MaNV ='" + f.maNV + "'");
            if (count > 0)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Mật khẩu không hợp lệ!!");
            }
        }
    }
}