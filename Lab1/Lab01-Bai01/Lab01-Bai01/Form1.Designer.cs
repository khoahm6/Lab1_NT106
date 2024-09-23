namespace Lab01_Bai01
{
    partial class BaiTH1
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
            tbsothunhat = new TextBox();
            tbsothuhai = new TextBox();
            tbsothuba = new TextBox();
            tbsolonnhat = new TextBox();
            tbsonhonhat = new TextBox();
            lbsothunhat = new Label();
            lbsothuhai = new Label();
            lbsothuba = new Label();
            lbsolonnhat = new Label();
            lbsonhonhat = new Label();
            bttim = new Button();
            btxoa = new Button();
            btthoat = new Button();
            SuspendLayout();
            // 
            // tbsothunhat
            // 
            tbsothunhat.Location = new Point(106, 67);
            tbsothunhat.Multiline = true;
            tbsothunhat.Name = "tbsothunhat";
            tbsothunhat.Size = new Size(125, 32);
            tbsothunhat.TabIndex = 0;
            tbsothunhat.TextChanged += tbsothunhat_TextChanged;
            // 
            // tbsothuhai
            // 
            tbsothuhai.BackColor = Color.White;
            tbsothuhai.Location = new Point(359, 66);
            tbsothuhai.Multiline = true;
            tbsothuhai.Name = "tbsothuhai";
            tbsothuhai.Size = new Size(125, 33);
            tbsothuhai.TabIndex = 2;
            // 
            // tbsothuba
            // 
            tbsothuba.BackColor = Color.White;
            tbsothuba.Location = new Point(654, 67);
            tbsothuba.Multiline = true;
            tbsothuba.Name = "tbsothuba";
            tbsothuba.Size = new Size(125, 30);
            tbsothuba.TabIndex = 3;
            // 
            // tbsolonnhat
            // 
            tbsolonnhat.BackColor = Color.FromArgb(224, 224, 224);
            tbsolonnhat.Location = new Point(179, 346);
            tbsolonnhat.Multiline = true;
            tbsolonnhat.Name = "tbsolonnhat";
            tbsolonnhat.ReadOnly = true;
            tbsolonnhat.Size = new Size(125, 32);
            tbsolonnhat.TabIndex = 4;
            // 
            // tbsonhonhat
            // 
            tbsonhonhat.BackColor = Color.FromArgb(224, 224, 224);
            tbsonhonhat.Location = new Point(541, 346);
            tbsonhonhat.Multiline = true;
            tbsonhonhat.Name = "tbsonhonhat";
            tbsonhonhat.ReadOnly = true;
            tbsonhonhat.Size = new Size(125, 32);
            tbsonhonhat.TabIndex = 5;
            // 
            // lbsothunhat
            // 
            lbsothunhat.AutoSize = true;
            lbsothunhat.Location = new Point(12, 70);
            lbsothunhat.Name = "lbsothunhat";
            lbsothunhat.Size = new Size(91, 20);
            lbsothunhat.TabIndex = 6;
            lbsothunhat.Text = "Số Thứ Nhất";
            // 
            // lbsothuhai
            // 
            lbsothuhai.AutoSize = true;
            lbsothuhai.Location = new Point(262, 70);
            lbsothuhai.Name = "lbsothuhai";
            lbsothuhai.Size = new Size(82, 20);
            lbsothuhai.TabIndex = 7;
            lbsothuhai.Text = "Số Thứ Hai";
            // 
            // lbsothuba
            // 
            lbsothuba.AutoSize = true;
            lbsothuba.Location = new Point(550, 70);
            lbsothuba.Name = "lbsothuba";
            lbsothuba.Size = new Size(76, 20);
            lbsothuba.TabIndex = 8;
            lbsothuba.Text = "Số Thứ Ba";
            // 
            // lbsolonnhat
            // 
            lbsolonnhat.AutoSize = true;
            lbsolonnhat.Location = new Point(68, 352);
            lbsolonnhat.Name = "lbsolonnhat";
            lbsolonnhat.Size = new Size(90, 20);
            lbsolonnhat.TabIndex = 9;
            lbsolonnhat.Text = "Số Lớn Nhất";
            // 
            // lbsonhonhat
            // 
            lbsonhonhat.AutoSize = true;
            lbsonhonhat.Location = new Point(415, 349);
            lbsonhonhat.Name = "lbsonhonhat";
            lbsonhonhat.Size = new Size(98, 20);
            lbsonhonhat.TabIndex = 10;
            lbsonhonhat.Text = "Số Nhỏ Nhất ";
            // 
            // bttim
            // 
            bttim.Location = new Point(106, 183);
            bttim.Name = "bttim";
            bttim.Size = new Size(94, 29);
            bttim.TabIndex = 11;
            bttim.Text = "Tìm ";
            bttim.UseVisualStyleBackColor = true;
            bttim.Click += bttim_Click;
            // 
            // btxoa
            // 
            btxoa.Location = new Point(319, 183);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(94, 29);
            btxoa.TabIndex = 12;
            btxoa.Text = "Xóa";
            btxoa.UseVisualStyleBackColor = true;
            btxoa.Click += btxoa_Click;
            // 
            // btthoat
            // 
            btthoat.Location = new Point(532, 183);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(94, 29);
            btthoat.TabIndex = 13;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = true;
            btthoat.Click += btthoat_Click;
            // 
            // BaiTH1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btthoat);
            Controls.Add(btxoa);
            Controls.Add(bttim);
            Controls.Add(lbsonhonhat);
            Controls.Add(lbsolonnhat);
            Controls.Add(lbsothuba);
            Controls.Add(lbsothuhai);
            Controls.Add(lbsothunhat);
            Controls.Add(tbsonhonhat);
            Controls.Add(tbsolonnhat);
            Controls.Add(tbsothuba);
            Controls.Add(tbsothuhai);
            Controls.Add(tbsothunhat);
            Name = "BaiTH1";
            Text = "BaiTH1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbsothunhat;
        private TextBox tbsothuhai;
        private TextBox tbsothuba;
        private TextBox tbsolonnhat;
        private TextBox tbsonhonhat;
        private Label lbsothunhat;
        private Label lbsothuhai;
        private Label lbsothuba;
        private Label lbsolonnhat;
        private Label lbsonhonhat;
        private Button bttim;
        private Button btxoa;
        private Button btthoat;
    }
}
