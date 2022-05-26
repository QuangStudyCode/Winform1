namespace B1_TH7
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhapSoN = new System.Windows.Forms.TextBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.lbSoNguyenTo = new System.Windows.Forms.Label();
            this.LbSoChinhPhuong = new System.Windows.Forms.Label();
            this.lbSoHoanChinh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(78, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số n:";
            // 
            // txtNhapSoN
            // 
            this.txtNhapSoN.Location = new System.Drawing.Point(181, 62);
            this.txtNhapSoN.Name = "txtNhapSoN";
            this.txtNhapSoN.Size = new System.Drawing.Size(160, 20);
            this.txtNhapSoN.TabIndex = 1;
            this.txtNhapSoN.TextChanged += new System.EventHandler(this.txtNhapSoN_TextChanged);
            this.txtNhapSoN.Leave += new System.EventHandler(this.txtNhapSoN_Leave);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(387, 163);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 38);
            this.btnHienThi.TabIndex = 2;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // lbSoNguyenTo
            // 
            this.lbSoNguyenTo.AutoSize = true;
            this.lbSoNguyenTo.Location = new System.Drawing.Point(54, 150);
            this.lbSoNguyenTo.Name = "lbSoNguyenTo";
            this.lbSoNguyenTo.Size = new System.Drawing.Size(124, 13);
            this.lbSoNguyenTo.TabIndex = 3;
            this.lbSoNguyenTo.Text = "Số nguyên tố nhỏ hơn n:";
            // 
            // LbSoChinhPhuong
            // 
            this.LbSoChinhPhuong.AutoSize = true;
            this.LbSoChinhPhuong.Location = new System.Drawing.Point(54, 212);
            this.LbSoChinhPhuong.Name = "LbSoChinhPhuong";
            this.LbSoChinhPhuong.Size = new System.Drawing.Size(144, 13);
            this.LbSoChinhPhuong.TabIndex = 4;
            this.LbSoChinhPhuong.Text = "Số chính phương nhỏ hơn n:";
            // 
            // lbSoHoanChinh
            // 
            this.lbSoHoanChinh.AutoSize = true;
            this.lbSoHoanChinh.Location = new System.Drawing.Point(54, 276);
            this.lbSoHoanChinh.Name = "lbSoHoanChinh";
            this.lbSoHoanChinh.Size = new System.Drawing.Size(130, 13);
            this.lbSoHoanChinh.TabIndex = 5;
            this.lbSoHoanChinh.Text = "Số hoàn chỉnh nhỏ hơn n:";
            this.lbSoHoanChinh.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 345);
            this.Controls.Add(this.lbSoHoanChinh);
            this.Controls.Add(this.LbSoChinhPhuong);
            this.Controls.Add(this.lbSoNguyenTo);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.txtNhapSoN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuong trinh nhap so";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapSoN;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label lbSoNguyenTo;
        private System.Windows.Forms.Label LbSoChinhPhuong;
        private System.Windows.Forms.Label lbSoHoanChinh;
    }
}

