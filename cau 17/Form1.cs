using System;
using System.Drawing;
using System.Windows.Forms;

namespace câu_17
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timerDongHo;

        public Form1()
        {
            InitializeComponent();

            timerDongHo = new System.Windows.Forms.Timer();
            timerDongHo.Interval = 1000;
            timerDongHo.Tick += timerDongHo_Tick;
            timerDongHo.Start();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            LstLopA.Items.Add("Truog Xuan Quang");
            LstLopA.Items.Add("Vu Thi Tuyet Minh");
            LstLopB.Items.Add("Le Duy Tinh");

            lblTacGia.Text = "Designed by Xavier";
            lblNgayGio.Text = DateTime.Now.ToString("M/d/yyyy h:mm:ss tt");

            menuStrip1.BackColor = Color.Cyan;
            statusStrip1.BackColor = Color.Cyan;
        }

        private void timerDongHo_Tick(object? sender, EventArgs e)
        {
            lblNgayGio.Text = DateTime.Now.ToString("M/d/yyyy h:mm:ss tt");
        }

        private void listBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (LstLopA.SelectedItem != null)
                txtTen.Text = LstLopA.SelectedItem.ToString();
        }

        private void btnCapNhat_Click(object? sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();

            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }

            int viTri = LstLopA.SelectedIndex;
            if (viTri >= 0)
            {
                LstLopA.Items[viTri] = ten;
            }
            else
            {
                if (LstLopA.Items.Contains(ten))
                {
                    MessageBox.Show("Sinh viên này đã có trong Lớp A!");
                    return;
                }
                LstLopA.Items.Add(ten);
            }

            txtTen.Clear();
            txtTen.Focus();
        }

        private void btnSangPhai_Click(object? sender, EventArgs e)
        {
            if (LstLopA.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn sinh viên nào ở Lớp A!");
                return;
            }
            string sv = LstLopA.SelectedItem.ToString();
            LstLopB.Items.Add(sv);
            LstLopA.Items.Remove(sv);
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            if (LstLopB.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn sinh viên nào ở Lớp B!");
                return;
            }
            string sv = LstLopB.SelectedItem.ToString();
            LstLopA.Items.Add(sv);
            LstLopB.Items.Remove(sv);
        }

        private void btnSangPhaiAll_Click(object? sender, EventArgs e)
        {
            while (LstLopA.Items.Count > 0)
            {
                LstLopB.Items.Add(LstLopA.Items[0]);
                LstLopA.Items.RemoveAt(0);
            }
        }

        private void btnSangTraiAll_Click(object? sender, EventArgs e)
        {
            while (LstLopB.Items.Count > 0)
            {
                LstLopA.Items.Add(LstLopB.Items[0]);
                LstLopB.Items.RemoveAt(0);
            }
        }

        private void button5_Click(object? sender, EventArgs e)
        {
            if (LstLopA.Items.Count == 0)
            {
                MessageBox.Show("Lớp A hiện đang trống!");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa toàn bộ Lớp A?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LstLopA.Items.Clear();
            }
        }

        private void button6_Click(object? sender, EventArgs e)
        {
            if (LstLopB.Items.Count == 0)
            {
                MessageBox.Show("Lớp B hiện đang trống!");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa toàn bộ Lớp B?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LstLopB.Items.Clear();
            }
        }

        // ============================================
        // BÀI 17 - MENU: gọi lại các hàm Button đã có
        // ============================================
        private void mnuChuyenPhai1_Click(object? sender, EventArgs e)
        {
            btnSangPhai_Click(sender, e);
        }

        private void mnuChuyenPhaiAll_Click(object? sender, EventArgs e)
        {
            btnSangPhaiAll_Click(sender, e);
        }

        private void mnuChuyenTrai1_Click(object? sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void mnuChuyenTraiAll_Click(object? sender, EventArgs e)
        {
            btnSangTraiAll_Click(sender, e);
        }

        private void mnuXoaA_Click(object? sender, EventArgs e)
        {
            button5_Click(sender, e);
        }

        private void mnuXoaB_Click(object? sender, EventArgs e)
        {
            button6_Click(sender, e);
        }

        private void mnuCapNhatSV_Click(object? sender, EventArgs e)
        {
            btnCapNhat_Click(sender, e);
        }

        // Menu "Thông tin" - hiển thị thông tin sinh viên thực hiện
        private void mnuThongTin_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "Họ tên: [Tên bạn]\n" +
                "MSSV: [Mã số sinh viên]\n" +
                "Lớp: [Lớp của bạn]\n" +
                "Bài tập: Bài 17 - Thực hành Lập trình Windows",
                "Thông tin sinh viên",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Menu "Thoát"
        private void mnuThoat_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}