namespace Lab4
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoimatkhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.btnChamcong = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaisanpham = new DevExpress.XtraBars.BarButtonItem();
            this.btnSanpham = new DevExpress.XtraBars.BarButtonItem();
            this.btnDonhang = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachhang = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaohoadon = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoanhthu = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnDangxuat,
            this.btnDoimatkhau,
            this.btnNhanvien,
            this.btnChamcong,
            this.btnLoaisanpham,
            this.btnSanpham,
            this.btnDonhang,
            this.btnKhachhang,
            this.btnTaohoadon,
            this.btnDoanhthu});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(819, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Caption = "Dang xuat";
            this.btnDangxuat.Id = 1;
            this.btnDangxuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangxuat.ImageOptions.Image")));
            this.btnDangxuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangxuat.ImageOptions.LargeImage")));
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangxuat_ItemClick);
            // 
            // btnDoimatkhau
            // 
            this.btnDoimatkhau.Caption = "Doi mat khau";
            this.btnDoimatkhau.Id = 2;
            this.btnDoimatkhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoimatkhau.ImageOptions.Image")));
            this.btnDoimatkhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoimatkhau.ImageOptions.LargeImage")));
            this.btnDoimatkhau.Name = "btnDoimatkhau";
            this.btnDoimatkhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoimatkhau_ItemClick);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Caption = "Nhan vien";
            this.btnNhanvien.Id = 3;
            this.btnNhanvien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanvien.ImageOptions.Image")));
            this.btnNhanvien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhanvien.ImageOptions.LargeImage")));
            this.btnNhanvien.Name = "btnNhanvien";
            // 
            // btnChamcong
            // 
            this.btnChamcong.Caption = "Cham cong";
            this.btnChamcong.Id = 4;
            this.btnChamcong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChamcong.ImageOptions.Image")));
            this.btnChamcong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChamcong.ImageOptions.LargeImage")));
            this.btnChamcong.Name = "btnChamcong";
            // 
            // btnLoaisanpham
            // 
            this.btnLoaisanpham.Caption = "Loai san pham";
            this.btnLoaisanpham.Id = 5;
            this.btnLoaisanpham.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoaisanpham.ImageOptions.Image")));
            this.btnLoaisanpham.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLoaisanpham.ImageOptions.LargeImage")));
            this.btnLoaisanpham.Name = "btnLoaisanpham";
            // 
            // btnSanpham
            // 
            this.btnSanpham.Caption = "San pham";
            this.btnSanpham.Id = 6;
            this.btnSanpham.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSanpham.ImageOptions.Image")));
            this.btnSanpham.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSanpham.ImageOptions.LargeImage")));
            this.btnSanpham.Name = "btnSanpham";
            // 
            // btnDonhang
            // 
            this.btnDonhang.Caption = "Đơn hàng";
            this.btnDonhang.Id = 7;
            this.btnDonhang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDonhang.ImageOptions.Image")));
            this.btnDonhang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDonhang.ImageOptions.LargeImage")));
            this.btnDonhang.Name = "btnDonhang";
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.Caption = "Khách hàng";
            this.btnKhachhang.Id = 8;
            this.btnKhachhang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachhang.ImageOptions.Image")));
            this.btnKhachhang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKhachhang.ImageOptions.LargeImage")));
            this.btnKhachhang.Name = "btnKhachhang";
            // 
            // btnTaohoadon
            // 
            this.btnTaohoadon.Caption = "Tạo hóa đơn";
            this.btnTaohoadon.Id = 9;
            this.btnTaohoadon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaohoadon.ImageOptions.Image")));
            this.btnTaohoadon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaohoadon.ImageOptions.LargeImage")));
            this.btnTaohoadon.Name = "btnTaohoadon";
            // 
            // btnDoanhthu
            // 
            this.btnDoanhthu.Caption = "Thống kê doanh thu";
            this.btnDoanhthu.Id = 10;
            this.btnDoanhthu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoanhthu.ImageOptions.Image")));
            this.btnDoanhthu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoanhthu.ImageOptions.LargeImage")));
            this.btnDoanhthu.Name = "btnDoanhthu";
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangxuat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDoimatkhau);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "He thong";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnNhanvien);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnChamcong);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Nhan vien";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLoaisanpham);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSanpham);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "San pham";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDonhang);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnKhachhang);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTaohoadon);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Don hang";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnDoanhthu);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Thống kê";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(819, 31);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Location = new System.Drawing.Point(0, 380);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(819, 41);
            this.tabControlMain.TabIndex = 2;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 449);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "NhanVien";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnDangxuat;
        private DevExpress.XtraBars.BarButtonItem btnDoimatkhau;
        private DevExpress.XtraBars.BarButtonItem btnNhanvien;
        private DevExpress.XtraBars.BarButtonItem btnChamcong;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnLoaisanpham;
        private DevExpress.XtraBars.BarButtonItem btnSanpham;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnDonhang;
        private DevExpress.XtraBars.BarButtonItem btnKhachhang;
        private DevExpress.XtraBars.BarButtonItem btnTaohoadon;
        private DevExpress.XtraBars.BarButtonItem btnDoanhthu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private System.Windows.Forms.TabControl tabControlMain;
    }
}