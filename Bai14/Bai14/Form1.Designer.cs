namespace Bai14
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
            menuStrip1 = new MenuStrip();
            cậpNhậtToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            this.txtTen = new TextBox();
            button1 = new Button();
            this.lstLopA = new ListBox();
            lstLopB = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cậpNhậtToolStripMenuItem, hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            cậpNhậtToolStripMenuItem.Size = new Size(99, 29);
            cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(103, 29);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 68);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 1;
            label1.Text = "Tên SV: ";
            // 
            // txtTen
            // 
            this.txtTen.Location = new Point(170, 68);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new Size(286, 31);
            this.txtTen.TabIndex = 2;
            this.txtTen.TextChanged += this.txtTen_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(493, 58);
            button1.Name = "button1";
            button1.Size = new Size(125, 51);
            button1.TabIndex = 3;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lstLopA
            // 
            this.lstLopA.FormattingEnabled = true;
            this.lstLopA.Location = new Point(44, 138);
            this.lstLopA.Name = "lstLopA";
            this.lstLopA.SelectionMode = SelectionMode.MultiExtended;
            this.lstLopA.Size = new Size(180, 204);
            this.lstLopA.TabIndex = 4;
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(358, 138);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(180, 204);
            lstLopB.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(262, 138);
            button2.Name = "button2";
            button2.Size = new Size(53, 42);
            button2.TabIndex = 6;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(262, 186);
            button3.Name = "button3";
            button3.Size = new Size(53, 42);
            button3.TabIndex = 7;
            button3.Text = ">>";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(262, 234);
            button4.Name = "button4";
            button4.Size = new Size(53, 42);
            button4.TabIndex = 8;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(262, 282);
            button5.Name = "button5";
            button5.Size = new Size(53, 42);
            button5.TabIndex = 9;
            button5.Text = "<<";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(62, 373);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 10;
            button6.Text = "Xóa Lớp A";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(226, 373);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 11;
            button7.Text = "Kết thúc";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(386, 373);
            button8.Name = "button8";
            button8.Size = new Size(112, 34);
            button8.TabIndex = 12;
            button8.Text = "Xóa Lớp B";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(lstLopB);
            Controls.Add(this.lstLopA);
            Controls.Add(button1);
            Controls.Add(this.txtTen);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private Label label1;
        private TextBox txtTen;
        private TextBox textBox1;
        private Button button1;
        private ListBox lstLopA;
        private ListBox listBox1;
        private ListBox lstLopB;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}
