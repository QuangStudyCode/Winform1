namespace test2
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
            this.lbSoA = new System.Windows.Forms.Label();
            this.lbSoB = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbTong = new System.Windows.Forms.Label();
            this.lbHieu = new System.Windows.Forms.Label();
            this.lbTich = new System.Windows.Forms.Label();
            this.lbThuong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSoA
            // 
            this.lbSoA.AutoSize = true;
            this.lbSoA.Location = new System.Drawing.Point(52, 52);
            this.lbSoA.Name = "lbSoA";
            this.lbSoA.Size = new System.Drawing.Size(33, 13);
            this.lbSoA.TabIndex = 0;
            this.lbSoA.Text = "Số A:";
            // 
            // lbSoB
            // 
            this.lbSoB.AutoSize = true;
            this.lbSoB.Location = new System.Drawing.Point(52, 105);
            this.lbSoB.Name = "lbSoB";
            this.lbSoB.Size = new System.Drawing.Size(33, 13);
            this.lbSoB.TabIndex = 1;
            this.lbSoB.Text = "Số B:";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(143, 49);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(171, 20);
            this.txtSoA.TabIndex = 2;
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(143, 102);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(171, 20);
            this.txtSoB.TabIndex = 3;
            // 
            // btnTinh
            // 
            this.btnTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTinh.Location = new System.Drawing.Point(369, 46);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(369, 105);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Location = new System.Drawing.Point(52, 165);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(35, 13);
            this.lbTong.TabIndex = 6;
            this.lbTong.Text = "Tổng:";
            // 
            // lbHieu
            // 
            this.lbHieu.AutoSize = true;
            this.lbHieu.Location = new System.Drawing.Point(52, 217);
            this.lbHieu.Name = "lbHieu";
            this.lbHieu.Size = new System.Drawing.Size(32, 13);
            this.lbHieu.TabIndex = 7;
            this.lbHieu.Text = "Hiệu:";
            // 
            // lbTich
            // 
            this.lbTich.AutoSize = true;
            this.lbTich.Location = new System.Drawing.Point(52, 266);
            this.lbTich.Name = "lbTich";
            this.lbTich.Size = new System.Drawing.Size(33, 13);
            this.lbTich.TabIndex = 8;
            this.lbTich.Text = "Tích:";
            // 
            // lbThuong
            // 
            this.lbThuong.AutoSize = true;
            this.lbThuong.Location = new System.Drawing.Point(52, 309);
            this.lbThuong.Name = "lbThuong";
            this.lbThuong.Size = new System.Drawing.Size(44, 13);
            this.lbThuong.TabIndex = 9;
            this.lbThuong.Text = "Thương";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(500, 362);
            this.ControlBox = false;
            this.Controls.Add(this.lbThuong);
            this.Controls.Add(this.lbTich);
            this.Controls.Add(this.lbHieu);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.lbSoB);
            this.Controls.Add(this.lbSoA);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSoA;
        private System.Windows.Forms.Label lbSoB;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label lbHieu;
        private System.Windows.Forms.Label lbTich;
        private System.Windows.Forms.Label lbThuong;
    }
}

