namespace test
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.lbTong = new System.Windows.Forms.Label();
            this.lbHieu = new System.Windows.Forms.Label();
            this.lbTich = new System.Windows.Forms.Label();
            this.lbThuong = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số b: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(123, 51);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(215, 20);
            this.txtSoA.TabIndex = 1;
            this.txtSoA.TextChanged += new System.EventHandler(this.txtSoA_TextChanged);
            this.txtSoA.Leave += new System.EventHandler(this.txtSoA_Leave);
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(123, 94);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(215, 20);
            this.txtSoB.TabIndex = 2;
            // 
            // btnTinh
            // 
            this.btnTinh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTinh.AutoSize = true;
            this.btnTinh.Location = new System.Drawing.Point(386, 58);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 40);
            this.btnTinh.TabIndex = 3;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Location = new System.Drawing.Point(63, 172);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(59, 13);
            this.lbTong.TabIndex = 5;
            this.lbTong.Text = "Tổng a+b=";
            this.lbTong.Click += new System.EventHandler(this.lbTong_Click);
            // 
            // lbHieu
            // 
            this.lbHieu.AutoSize = true;
            this.lbHieu.Location = new System.Drawing.Point(63, 216);
            this.lbHieu.Name = "lbHieu";
            this.lbHieu.Size = new System.Drawing.Size(56, 13);
            this.lbHieu.TabIndex = 6;
            this.lbHieu.Text = "Hiệu a+b=";
            // 
            // lbTich
            // 
            this.lbTich.AutoSize = true;
            this.lbTich.Location = new System.Drawing.Point(63, 266);
            this.lbTich.Name = "lbTich";
            this.lbTich.Size = new System.Drawing.Size(56, 13);
            this.lbTich.TabIndex = 7;
            this.lbTich.Text = "Tích axb=";
            // 
            // lbThuong
            // 
            this.lbThuong.AutoSize = true;
            this.lbThuong.Location = new System.Drawing.Point(63, 313);
            this.lbThuong.Name = "lbThuong";
            this.lbThuong.Size = new System.Drawing.Size(70, 13);
            this.lbThuong.TabIndex = 8;
            this.lbThuong.Text = "Thương a/b=";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThoat.Location = new System.Drawing.Point(386, 216);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 40);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTinh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 357);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lbThuong);
            this.Controls.Add(this.lbTich);
            this.Controls.Add(this.lbHieu);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label lbHieu;
        private System.Windows.Forms.Label lbTich;
        private System.Windows.Forms.Label lbThuong;
        private System.Windows.Forms.Button btnThoat;
    }
}

