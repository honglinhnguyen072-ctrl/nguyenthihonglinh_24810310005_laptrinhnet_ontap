namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDonGia = new TextBox();
            nameSoLuong = new TextBox();
            txtGiamGia = new TextBox();
            lbTongtien = new Label();
            btnTinhtien = new Button();
            btnlammoi = new Button();
            label1 = new Label();
            label2 = new Label();
            tongtinhtien = new Label();
            SuspendLayout();
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(264, 12);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(150, 31);
            txtDonGia.TabIndex = 0;
            // 
            // nameSoLuong
            // 
            nameSoLuong.Location = new Point(264, 67);
            nameSoLuong.Name = "nameSoLuong";
            nameSoLuong.Size = new Size(150, 31);
            nameSoLuong.TabIndex = 1;
            nameSoLuong.TextChanged += nameSoLuong_TextChanged;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(274, 104);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(150, 31);
            txtGiamGia.TabIndex = 2;
            // 
            // lbTongtien
            // 
            lbTongtien.AutoSize = true;
            lbTongtien.Location = new Point(154, 18);
            lbTongtien.Name = "lbTongtien";
            lbTongtien.Size = new Size(73, 25);
            lbTongtien.TabIndex = 3;
            lbTongtien.Text = "đơn giá";
            // 
            // btnTinhtien
            // 
            btnTinhtien.Location = new Point(245, 157);
            btnTinhtien.Name = "btnTinhtien";
            btnTinhtien.Size = new Size(112, 34);
            btnTinhtien.TabIndex = 3;
            btnTinhtien.Text = "tinh tien";
            btnTinhtien.UseVisualStyleBackColor = true;
            btnTinhtien.Click += btnTinhtien_Click;
            // 
            // btnlammoi
            // 
            btnlammoi.Location = new Point(385, 157);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(112, 34);
            btnlammoi.TabIndex = 4;
            btnlammoi.Text = "lam moi";
            btnlammoi.UseVisualStyleBackColor = true;
            btnlammoi.Click += btnlammoi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 67);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 5;
            label1.Text = "so luong";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 110);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 6;
            label2.Text = "giảm giá";
            // 
            // tongtinhtien
            // 
            tongtinhtien.AutoSize = true;
            tongtinhtien.Location = new Point(200, 206);
            tongtinhtien.Name = "tongtinhtien";
            tongtinhtien.Size = new Size(164, 25);
            tongtinhtien.TabIndex = 7;
            tongtinhtien.Text = "tong so tien: 0VND";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tongtinhtien);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnlammoi);
            Controls.Add(btnTinhtien);
            Controls.Add(lbTongtien);
            Controls.Add(txtGiamGia);
            Controls.Add(nameSoLuong);
            Controls.Add(txtDonGia);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDonGia;
        private TextBox nameSoLuong;
        private TextBox txtGiamGia;
        private Label lbTongtien;
        private Button btnTinhtien;
        private Button btnlammoi;
        private Label label1;
        private Label label2;
        private Label tongtinhtien;
    }
}
