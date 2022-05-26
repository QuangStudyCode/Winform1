namespace testB4
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
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.lbSoNguyenTo = new System.Windows.Forms.Label();
            this.lbSoChinhPhuong = new System.Windows.Forms.Label();
            this.lbSoHoanChinh = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Số";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(113, 38);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(160, 20);
            this.txtSoA.TabIndex = 1;
            this.txtSoA.TextChanged += new System.EventHandler(this.txtSoA_TextChanged);
            this.txtSoA.Leave += new System.EventHandler(this.txtSoA_Leave);
            // 
            // lbSoNguyenTo
            // 
            this.lbSoNguyenTo.AutoSize = true;
            this.lbSoNguyenTo.Location = new System.Drawing.Point(40, 118);
            this.lbSoNguyenTo.Name = "lbSoNguyenTo";
            this.lbSoNguyenTo.Size = new System.Drawing.Size(124, 13);
            this.lbSoNguyenTo.TabIndex = 2;
            this.lbSoNguyenTo.Text = "Số nguyên tố nhỏ hơn n:";
            // 
            // lbSoChinhPhuong
            // 
            this.lbSoChinhPhuong.AutoSize = true;
            this.lbSoChinhPhuong.Location = new System.Drawing.Point(40, 165);
            this.lbSoChinhPhuong.Name = "lbSoChinhPhuong";
            this.lbSoChinhPhuong.Size = new System.Drawing.Size(144, 13);
            this.lbSoChinhPhuong.TabIndex = 3;
            this.lbSoChinhPhuong.Text = "Số chính phương nhỏ hơn n:";
            // 
            // lbSoHoanChinh
            // 
            this.lbSoHoanChinh.AutoSize = true;
            this.lbSoHoanChinh.Location = new System.Drawing.Point(40, 213);
            this.lbSoHoanChinh.Name = "lbSoHoanChinh";
            this.lbSoHoanChinh.Size = new System.Drawing.Size(130, 13);
            this.lbSoHoanChinh.TabIndex = 4;
            this.lbSoHoanChinh.Text = "Số hoàn chỉnh nhỏ hơn n:";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(308, 35);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 5;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 249);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.lbSoHoanChinh);
            this.Controls.Add(this.lbSoChinhPhuong);
            this.Controls.Add(this.lbSoNguyenTo);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Label lbSoNguyenTo;
        private System.Windows.Forms.Label lbSoChinhPhuong;
        private System.Windows.Forms.Label lbSoHoanChinh;
        private System.Windows.Forms.Button btnTinh;
    }
}

