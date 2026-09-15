using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private string filePath = ""; // Lưu đường dẫn file hiện tại

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo ban đầu nếu cần
        }

        // --- 1. XỬ LÝ MENU CHÍNH (MAIN MENU) ---

        // Nút New: Tạo file mới (xóa trắng khung văn bản)
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            filePath = "";
        }

        // Nút Open: Mở file văn bản
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgOpenfile.ShowDialog() == DialogResult.OK)
            {
                filePath = dlgOpenfile.FileName;
                richTextBox1.Text = File.ReadAllText(filePath);
            }
        }

        // Nút Save As: Lưu file văn bản
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                filePath = dlgSaveFile.FileName;
                File.WriteAllText(filePath, richTextBox1.Text);
                MessageBox.Show("Đã lưu file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Nút Exit: Đóng chương trình (Khớp tên sự kiện với giao diện của bạn)
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- 2. XỬ LÝ ĐỊNH DẠNG (FORMAT & HELP - TÙY CHỌN) ---
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgFont.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = dlgFont.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = dlgColor.Color;
            }
        }

        // --- 3. XỬ LÝ MENU CHUỘT PHẢI (CONTEXT MENU) ---

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void coppyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Xử lý khi nội dung văn bản thay đổi nếu cần
        }

        private void cutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
    }
}