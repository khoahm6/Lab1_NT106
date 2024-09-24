namespace Lab01_Bai02
{
    partial class BaiTH2
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
            lbnhapA = new Label();
            lbnhapB = new Label();
            tbnhapA = new TextBox();
            tbnhapB = new TextBox();
            bttinhgiatri = new Button();
            btxoa = new Button();
            btthoat = new Button();
            tbketqua = new TextBox();
            lbketqua = new Label();
            cbluachon = new ComboBox();
            SuspendLayout();
            // 
            // lbnhapA
            // 
            lbnhapA.AutoSize = true;
            lbnhapA.Location = new Point(58, 96);
            lbnhapA.Name = "lbnhapA";
            lbnhapA.Size = new Size(59, 20);
            lbnhapA.TabIndex = 0;
            lbnhapA.Text = "Nhập A";
            // 
            // lbnhapB
            // 
            lbnhapB.AutoSize = true;
            lbnhapB.Location = new Point(490, 96);
            lbnhapB.Name = "lbnhapB";
            lbnhapB.Size = new Size(58, 20);
            lbnhapB.TabIndex = 1;
            lbnhapB.Text = "Nhập B";
            // 
            // tbnhapA
            // 
            tbnhapA.Location = new Point(123, 93);
            tbnhapA.Multiline = true;
            tbnhapA.Name = "tbnhapA";
            tbnhapA.Size = new Size(125, 34);
            tbnhapA.TabIndex = 2;
            // 
            // tbnhapB
            // 
            tbnhapB.Location = new Point(554, 96);
            tbnhapB.Multiline = true;
            tbnhapB.Name = "tbnhapB";
            tbnhapB.Size = new Size(125, 34);
            tbnhapB.TabIndex = 3;
            tbnhapB.TextChanged += textBox2_TextChanged;
            // 
            // bttinhgiatri
            // 
            bttinhgiatri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            bttinhgiatri.Location = new Point(90, 220);
            bttinhgiatri.Name = "bttinhgiatri";
            bttinhgiatri.Size = new Size(182, 29);
            bttinhgiatri.TabIndex = 4;
            bttinhgiatri.Text = "Tính các giá trị";
            bttinhgiatri.UseVisualStyleBackColor = true;
            bttinhgiatri.Click += bttinhgiatri_Click;
            // 
            // btxoa
            // 
            btxoa.Location = new Point(337, 220);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(94, 29);
            btxoa.TabIndex = 5;
            btxoa.Text = "Xóa";
            btxoa.UseVisualStyleBackColor = true;
            btxoa.Click += btxoa_Click;
            // 
            // btthoat
            // 
            btthoat.Location = new Point(500, 220);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(94, 29);
            btthoat.TabIndex = 6;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = true;
            btthoat.Click += btthoat_Click;
            // 
            // tbketqua
            // 
            tbketqua.BackColor = SystemColors.Control;
            tbketqua.Dock = DockStyle.Bottom;
            tbketqua.Location = new Point(0, 297);
            tbketqua.Multiline = true;
            tbketqua.Name = "tbketqua";
            tbketqua.ReadOnly = true;
            tbketqua.Size = new Size(757, 153);
            tbketqua.TabIndex = 7;
            tbketqua.TextChanged += tbketqua_TextChanged;
            // 
            // lbketqua
            // 
            lbketqua.AutoSize = true;
            lbketqua.BackColor = SystemColors.Control;
            lbketqua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbketqua.Location = new Point(12, 276);
            lbketqua.Name = "lbketqua";
            lbketqua.Size = new Size(97, 28);
            lbketqua.TabIndex = 8;
            lbketqua.Text = "KẾT QUẢ";
            // 
            // cbluachon
            // 
            cbluachon.FormattingEnabled = true;
            cbluachon.Items.AddRange(new object[] { "Bảng cửu chương", "Tính toán giá trị" });
            cbluachon.Location = new Point(300, 146);
            cbluachon.Name = "cbluachon";
            cbluachon.Size = new Size(151, 28);
            cbluachon.TabIndex = 9;
            cbluachon.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // BaiTH2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 450);
            Controls.Add(cbluachon);
            Controls.Add(lbketqua);
            Controls.Add(tbketqua);
            Controls.Add(btthoat);
            Controls.Add(btxoa);
            Controls.Add(bttinhgiatri);
            Controls.Add(tbnhapB);
            Controls.Add(tbnhapA);
            Controls.Add(lbnhapB);
            Controls.Add(lbnhapA);
            Name = "BaiTH2";
            Text = "BaiTH2";
            Load += BaiTH2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbnhapA;
        private Label lbnhapB;
        private TextBox tbnhapA;
        private TextBox tbnhapB;
        private Button bttinhgiatri;
        private Button btxoa;
        private Button btthoat;
        private TextBox tbketqua;
        private Label lbketqua;
        private ComboBox cbluachon;
    }
}
