using System.Text;

namespace Lab01_Bai02
{
    public partial class BaiTH2 : Form
    {
        public BaiTH2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BaiTH2_Load(object sender, EventArgs e)
        {

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            tbnhapA.Clear();
            tbnhapB.Clear();
            tbketqua.Clear();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttinhgiatri_Click(object sender, EventArgs e)
        {
            string luachon = cbluachon.SelectedItem?.ToString();

            if (luachon == null)
            {
                MessageBox.Show("Hãy chọn một chức năng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long A, B;
            if (!long.TryParse(tbnhapA.Text, out A))
            {
                MessageBox.Show("Hãy nhập chính xác giá trị A", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!long.TryParse(tbnhapB.Text, out B))
            {
                MessageBox.Show("Hãy nhập chính xác giá trị B", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (luachon == "Bảng cửu chương")
            {
                StringBuilder bangcuuchuong = new StringBuilder();
                for (int i = 0; i <= 10; i++)
                {
                    bangcuuchuong.AppendLine($"{A} X {i} = {A * i}");
                }
                tbketqua.Text = bangcuuchuong.ToString();
            }
            else if (luachon == "Tính toán giá trị")
            {
                // Tính (A - B)!
                long hieu = A - B;
                if (hieu < 0)
                {
                    MessageBox.Show("Không thể tính giai thừa của một số âm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                long giaithua = 1;
                for (int i = 1; i <= hieu; i++)
                {
                    giaithua *= i;
                }

                // Tính tổng S
                long S = 0;
                for (int i = 1; i <= B; i++)
                {
                    S += (long)Math.Pow(A, i);
                }

                StringBuilder ketqua = new StringBuilder();
                ketqua.AppendLine($"(A - B)! = {giaithua}");
                ketqua.AppendLine($"S = {S}");

                // Hiển thị kết quả
                tbketqua.Text = ketqua.ToString();
            }
        }

    }
}

