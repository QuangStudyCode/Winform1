namespace BTTH04_03
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
            this.lbSoNguyen = new System.Windows.Forms.Label();
            this.lbSoNguyenTo = new System.Windows.Forms.Label();
            this.lbSoChinhPhuong = new System.Windows.Forms.Label();
            this.lbSoHoanChinh = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSoNguyen
            // 
            this.lbSoNguyen.AutoSize = true;
            this.lbSoNguyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoNguyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbSoNguyen.Location = new System.Drawing.Point(29, 51);
            this.lbSoNguyen.Name = "lbSoNguyen";
            this.lbSoNguyen.Size = new System.Drawing.Size(105, 16);
            this.lbSoNguyen.TabIndex = 0;
            this.lbSoNguyen.Text = "Nhập số nguyên";
            // 
            // lbSoNguyenTo
            // 
            this.lbSoNguyenTo.AutoSize = true;
            this.lbSoNguyenTo.Location = new System.Drawing.Point(45, 138);
            this.lbSoNguyenTo.Name = "lbSoNguyenTo";
            this.lbSoNguyenTo.Size = new System.Drawing.Size(121, 13);
            this.lbSoNguyenTo.TabIndex = 1;
            this.lbSoNguyenTo.Text = "Số nguyên tố nhỏ hơn n";
            // 
            // lbSoChinhPhuong
            // 
            this.lbSoChinhPhuong.AutoSize = true;
            this.lbSoChinhPhuong.Location = new System.Drawing.Point(45, 184);
            this.lbSoChinhPhuong.Name = "lbSoChinhPhuong";
            this.lbSoChinhPhuong.Size = new System.Drawing.Size(141, 13);
            this.lbSoChinhPhuong.TabIndex = 2;
            this.lbSoChinhPhuong.Text = "Số chính phương nhỏ hơn n";
            // 
            // lbSoHoanChinh
            // 
            this.lbSoHoanChinh.AutoSize = true;
            this.lbSoHoanChinh.Location = new System.Drawing.Point(45, 223);
            this.lbSoHoanChinh.Name = "lbSoHoanChinh";
            this.lbSoHoanChinh.Size = new System.Drawing.Size(127, 13);
            this.lbSoHoanChinh.TabIndex = 3;
            this.lbSoHoanChinh.Text = "Số hoàn chỉnh nhỏ hơn n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(310, 39);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 41);
            this.btnHienThi.TabIndex = 5;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 275);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbSoHoanChinh);
            this.Controls.Add(this.lbSoChinhPhuong);
            this.Controls.Add(this.lbSoNguyenTo);
            this.Controls.Add(this.lbSoNguyen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSoNguyen;
        private System.Windows.Forms.Label lbSoNguyenTo;
        private System.Windows.Forms.Label lbSoChinhPhuong;
        private System.Windows.Forms.Label lbSoHoanChinh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnHienThi;
    }
}

