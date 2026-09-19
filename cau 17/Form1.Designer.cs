using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace câu_17
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            mnuCapNhat = new ToolStripMenuItem();
            mnuChuyenPhai1 = new ToolStripMenuItem();
            mnuChuyenPhaiAll = new ToolStripMenuItem();
            mnuChuyenTrai1 = new ToolStripMenuItem();
            mnuChuyenTraiAll = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuXoaA = new ToolStripMenuItem();
            mnuXoaB = new ToolStripMenuItem();
            mnuCapNhatSV = new ToolStripMenuItem();
            mnuHeThong = new ToolStripMenuItem();
            mnuThongTin = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            txtTen = new TextBox();
            btnCapNhat = new Button();
            LstLopA = new ListBox();
            LstLopB = new ListBox();
            btnSangPhai = new Button();
            btnSangTrai = new Button();
            btnSangPhaiAll = new Button();
            btnSangTraiAll = new Button();
            button5 = new Button();
            button6 = new Button();
            statusStrip1 = new StatusStrip();
            lblNgayGio = new ToolStripStatusLabel();
            lblTacGia = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 47);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 0;
            label1.Text = "Tên SV:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuCapNhat, mnuHeThong });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuCapNhat
            // 
            mnuCapNhat.DropDownItems.AddRange(new ToolStripItem[] {
                mnuChuyenPhai1, mnuChuyenPhaiAll, mnuChuyenTrai1, mnuChuyenTraiAll,
                toolStripSeparator1, mnuXoaA, mnuXoaB, mnuCapNhatSV });
            mnuCapNhat.Name = "mnuCapNhat";
            mnuCapNhat.Size = new Size(94, 27);
            mnuCapNhat.Text = "Cập nhật";
            // 
            // mnuChuyenPhai1
            // 
            mnuChuyenPhai1.Name = "mnuChuyenPhai1";
            mnuChuyenPhai1.Size = new Size(280, 26);
            mnuChuyenPhai1.Text = "Chuyển 1 phần tử sang lớp B";
            mnuChuyenPhai1.Click += mnuChuyenPhai1_Click;
            // 
            // mnuChuyenPhaiAll
            // 
            mnuChuyenPhaiAll.Name = "mnuChuyenPhaiAll";
            mnuChuyenPhaiAll.Size = new Size(280, 26);
            mnuChuyenPhaiAll.Text = "Chuyển tất cả sang lớp B";
            mnuChuyenPhaiAll.Click += mnuChuyenPhaiAll_Click;
            // 
            // mnuChuyenTrai1
            // 
            mnuChuyenTrai1.Name = "mnuChuyenTrai1";
            mnuChuyenTrai1.Size = new Size(280, 26);
            mnuChuyenTrai1.Text = "Chuyển 1 phần tử sang lớp A";
            mnuChuyenTrai1.Click += mnuChuyenTrai1_Click;
            // 
            // mnuChuyenTraiAll
            // 
            mnuChuyenTraiAll.Name = "mnuChuyenTraiAll";
            mnuChuyenTraiAll.Size = new Size(280, 26);
            mnuChuyenTraiAll.Text = "Chuyển tất cả sang lớp A";
            mnuChuyenTraiAll.Click += mnuChuyenTraiAll_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(277, 6);
            // 
            // mnuXoaA
            // 
            mnuXoaA.Name = "mnuXoaA";
            mnuXoaA.Size = new Size(280, 26);
            mnuXoaA.Text = "Xóa lớp A";
            mnuXoaA.Click += mnuXoaA_Click;
            // 
            // mnuXoaB
            // 
            mnuXoaB.Name = "mnuXoaB";
            mnuXoaB.Size = new Size(280, 26);
            mnuXoaB.Text = "Xóa lớp B";
            mnuXoaB.Click += mnuXoaB_Click;
            // 
            // mnuCapNhatSV
            // 
            mnuCapNhatSV.Name = "mnuCapNhatSV";
            mnuCapNhatSV.Size = new Size(280, 26);
            mnuCapNhatSV.Text = "Cập nhật sinh viên";
            mnuCapNhatSV.Click += mnuCapNhatSV_Click;
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuThongTin, mnuThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(101, 27);
            mnuHeThong.Text = "Hệ thống ";
            // 
            // mnuThongTin
            // 
            mnuThongTin.Name = "mnuThongTin";
            mnuThongTin.Size = new Size(180, 26);
            mnuThongTin.Text = "Thông tin";
            mnuThongTin.Click += mnuThongTin_Click;
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(180, 26);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(201, 40);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(272, 30);
            txtTen.TabIndex = 2;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(506, 35);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(118, 39);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // LstLopA
            // 
            LstLopA.FormattingEnabled = true;
            LstLopA.Location = new Point(106, 104);
            LstLopA.Name = "LstLopA";
            LstLopA.Size = new Size(224, 234);
            LstLopA.TabIndex = 4;
            LstLopA.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // LstLopB
            // 
            LstLopB.FormattingEnabled = true;
            LstLopB.Location = new Point(444, 104);
            LstLopB.Name = "LstLopB";
            LstLopB.Size = new Size(235, 234);
            LstLopB.TabIndex = 5;
            // 
            // btnSangPhai
            // 
            btnSangPhai.Location = new Point(359, 104);
            btnSangPhai.Name = "btnSangPhai";
            btnSangPhai.Size = new Size(56, 34);
            btnSangPhai.TabIndex = 6;
            btnSangPhai.Text = ">";
            btnSangPhai.UseVisualStyleBackColor = true;
            btnSangPhai.Click += btnSangPhai_Click;
            // 
            // btnSangTrai
            // 
            btnSangTrai.Location = new Point(359, 237);
            btnSangTrai.Name = "btnSangTrai";
            btnSangTrai.Size = new Size(56, 34);
            btnSangTrai.TabIndex = 7;
            btnSangTrai.Text = "<";
            btnSangTrai.UseVisualStyleBackColor = true;
            btnSangTrai.Click += button2_Click;
            // 
            // btnSangPhaiAll
            // 
            btnSangPhaiAll.Location = new Point(359, 168);
            btnSangPhaiAll.Name = "btnSangPhaiAll";
            btnSangPhaiAll.Size = new Size(56, 34);
            btnSangPhaiAll.TabIndex = 8;
            btnSangPhaiAll.Text = ">>";
            btnSangPhaiAll.UseVisualStyleBackColor = true;
            btnSangPhaiAll.Click += btnSangPhaiAll_Click;
            // 
            // btnSangTraiAll
            // 
            btnSangTraiAll.Location = new Point(359, 304);
            btnSangTraiAll.Name = "btnSangTraiAll";
            btnSangTraiAll.Size = new Size(56, 34);
            btnSangTraiAll.TabIndex = 9;
            btnSangTraiAll.Text = "<<";
            btnSangTraiAll.UseVisualStyleBackColor = true;
            btnSangTraiAll.Click += btnSangTraiAll_Click;
            // 
            // button5
            // 
            button5.Location = new Point(146, 361);
            button5.Name = "button5";
            button5.Size = new Size(153, 34);
            button5.TabIndex = 10;
            button5.Text = "Xóa lớp A";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(488, 361);
            button6.Name = "button6";
            button6.Size = new Size(153, 34);
            button6.TabIndex = 11;
            button6.Text = "Xóa lớp B";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblNgayGio, lblTacGia });
            statusStrip1.Location = new Point(0, 421);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 29);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblNgayGio
            // 
            lblNgayGio.Name = "lblNgayGio";
            lblNgayGio.Size = new Size(169, 23);
            lblNgayGio.Text = "toolStripStatusLabel1";
            // 
            // lblTacGia
            // 
            lblTacGia.Name = "lblTacGia";
            lblTacGia.Size = new Size(169, 23);
            lblTacGia.Text = "toolStripStatusLabel2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(btnSangTraiAll);
            Controls.Add(btnSangPhaiAll);
            Controls.Add(btnSangTrai);
            Controls.Add(btnSangPhai);
            Controls.Add(LstLopB);
            Controls.Add(LstLopA);
            Controls.Add(btnCapNhat);
            Controls.Add(txtTen);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuCapNhat;
        private ToolStripMenuItem mnuChuyenPhai1;
        private ToolStripMenuItem mnuChuyenPhaiAll;
        private ToolStripMenuItem mnuChuyenTrai1;
        private ToolStripMenuItem mnuChuyenTraiAll;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuXoaA;
        private ToolStripMenuItem mnuXoaB;
        private ToolStripMenuItem mnuCapNhatSV;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuThongTin;
        private ToolStripMenuItem mnuThoat;
        private TextBox txtTen;
        private Button btnCapNhat;
        private ListBox LstLopA;
        private ListBox LstLopB;
        private Button btnSangPhai;
        private Button btnSangTrai;
        private Button btnSangPhaiAll;
        private Button btnSangTraiAll;
        private Button button5;
        private Button button6;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblNgayGio;
        private ToolStripStatusLabel lblTacGia;
    }
}