namespace Lab4
{
    partial class doimatkhau
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoimatkhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhaplaimatkhau = new System.Windows.Forms.TextBox();
            this.btnCapnhap = new System.Windows.Forms.Button();
            this.btnTrove = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mật khẩu mới";
            // 
            // txtDoimatkhau
            // 
            this.txtDoimatkhau.Location = new System.Drawing.Point(185, 36);
            this.txtDoimatkhau.Name = "txtDoimatkhau";
            this.txtDoimatkhau.Size = new System.Drawing.Size(118, 21);
            this.txtDoimatkhau.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập lại mật khẩu";
            // 
            // txtNhaplaimatkhau
            // 
            this.txtNhaplaimatkhau.Location = new System.Drawing.Point(185, 78);
            this.txtNhaplaimatkhau.Name = "txtNhaplaimatkhau";
            this.txtNhaplaimatkhau.Size = new System.Drawing.Size(118, 21);
            this.txtNhaplaimatkhau.TabIndex = 3;
            // 
            // btnCapnhap
            // 
            this.btnCapnhap.Location = new System.Drawing.Point(81, 142);
            this.btnCapnhap.Name = "btnCapnhap";
            this.btnCapnhap.Size = new System.Drawing.Size(75, 23);
            this.btnCapnhap.TabIndex = 4;
            this.btnCapnhap.Text = "Cập nhật";
            this.btnCapnhap.UseVisualStyleBackColor = true;
            this.btnCapnhap.Click += new System.EventHandler(this.btnCapnhap_Click);
            // 
            // btnTrove
            // 
            this.btnTrove.Location = new System.Drawing.Point(185, 142);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(75, 23);
            this.btnTrove.TabIndex = 5;
            this.btnTrove.Text = "Trở về";
            this.btnTrove.UseVisualStyleBackColor = true;
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // doimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 261);
            this.Controls.Add(this.btnTrove);
            this.Controls.Add(this.btnCapnhap);
            this.Controls.Add(this.txtNhaplaimatkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDoimatkhau);
            this.Controls.Add(this.label1);
            this.Name = "doimatkhau";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.doimatkhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDoimatkhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhaplaimatkhau;
        private System.Windows.Forms.Button btnCapnhap;
        private System.Windows.Forms.Button btnTrove;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}