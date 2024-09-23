namespace Lab01_Bai01
{
    public partial class BaiTH1 : Form
    {
        public BaiTH1()
        {
            InitializeComponent();
        }

        private void tbsothunhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            tbsothunhat.Clear();
            tbsonhonhat.Clear();
            tbsolonnhat.Clear();
            tbsothuba.Clear();
            tbsothuhai.Clear();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            double soThuNhat, soThuHai, soThuBa;
            if (!double.TryParse(tbsothunhat.Text.Trim(), out soThuNhat))
            {
                MessageBox.Show("Hãy nhập số hợp lệ ở ô số thứ nhất!","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(tbsothuhai.Text.Trim(), out soThuHai))
            {
                MessageBox.Show("Hãy nhập số hợp lệ ở ô số thứ hai!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(tbsothuba.Text.Trim(), out soThuBa))
            {
                MessageBox.Show("Hãy nhập số hợp lệ ở ô số thứ ba!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                double soLonNhat = Math.Max(soThuNhat, Math.Max(soThuHai, soThuBa));
                double soNhoNhat = Math.Min(soThuNhat, Math.Min(soThuHai, soThuBa));

                tbsonhonhat.Text = soNhoNhat.ToString();
                tbsolonnhat.Text = soLonNhat.ToString();
            }
        }
    }

}
