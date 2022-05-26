namespace testBTTH04
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
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.txtSoa = new System.Windows.Forms.TextBox();
            this.txtSob = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.btnHoanDoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(66, 44);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(22, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "a =";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(66, 101);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(22, 13);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "b =";
            // 
            // txtSoa
            // 
            this.txtSoa.Location = new System.Drawing.Point(112, 41);
            this.txtSoa.Name = "txtSoa";
            this.txtSoa.Size = new System.Drawing.Size(31, 20);
            this.txtSoa.TabIndex = 2;
            // 
            // txtSob
            // 
            this.txtSob.Location = new System.Drawing.Point(112, 98);
            this.txtSob.Name = "txtSob";
            this.txtSob.Size = new System.Drawing.Size(31, 20);
            this.txtSob.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(190, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 36);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(190, 81);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(75, 53);
            this.btnDung.TabIndex = 5;
            this.btnDung.Text = "Dừng";
            this.btnDung.UseVisualStyleBackColor = true;
            // 
            // btnHoanDoi
            // 
            this.btnHoanDoi.Location = new System.Drawing.Point(60, 144);
            this.btnHoanDoi.Name = "btnHoanDoi";
            this.btnHoanDoi.Size = new System.Drawing.Size(116, 40);
            this.btnHoanDoi.TabIndex = 6;
            this.btnHoanDoi.Text = "Hoán Đổi";
            this.btnHoanDoi.UseVisualStyleBackColor = true;
            this.btnHoanDoi.Click += new System.EventHandler(this.btnHoanDoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 205);
            this.Controls.Add(this.btnHoanDoi);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtSob);
            this.Controls.Add(this.txtSoa);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Hoán đổi giá trị";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txtSoa;
        private System.Windows.Forms.TextBox txtSob;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.Button btnHoanDoi;
    }
}

