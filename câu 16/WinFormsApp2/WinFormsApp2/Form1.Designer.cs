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
            components = new System.ComponentModel.Container();
            mnuMainMenu = new MenuStrip();
            fToolStripMenuItem = new ToolStripMenuItem();
            nToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saverToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripSeparator();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            mnuContext = new ContextMenuStrip(components);
            cutToolStripMenuItem = new ToolStripMenuItem();
            coppyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            dlgOpenfile = new OpenFileDialog();
            dlgSaveFile = new SaveFileDialog();
            dlgFont = new FontDialog();
            dlgColor = new ColorDialog();
            mnuMainMenu.SuspendLayout();
            mnuContext.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMainMenu
            // 
            mnuMainMenu.ImageScalingSize = new Size(24, 24);
            mnuMainMenu.Items.AddRange(new ToolStripItem[] { fToolStripMenuItem, formatToolStripMenuItem, helpToolStripMenuItem });
            mnuMainMenu.Location = new Point(0, 0);
            mnuMainMenu.Name = "mnuMainMenu";
            mnuMainMenu.Size = new Size(800, 33);
            mnuMainMenu.TabIndex = 0;
            mnuMainMenu.Text = "menuStrip1";
            // 
            // fToolStripMenuItem
            // 
            fToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nToolStripMenuItem, openToolStripMenuItem, saverToolStripMenuItem, exitToolStripMenuItem, exitToolStripMenuItem1 });
            fToolStripMenuItem.Name = "fToolStripMenuItem";
            fToolStripMenuItem.Size = new Size(54, 29);
            fToolStripMenuItem.Text = "File";
            // 
            // nToolStripMenuItem
            // 
            nToolStripMenuItem.Name = "nToolStripMenuItem";
            nToolStripMenuItem.Size = new Size(185, 34);
            nToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(185, 34);
            openToolStripMenuItem.Text = "Open...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saverToolStripMenuItem
            // 
            saverToolStripMenuItem.Name = "saverToolStripMenuItem";
            saverToolStripMenuItem.Size = new Size(185, 34);
            saverToolStripMenuItem.Text = "Save as...";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(182, 6);
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(185, 34);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(85, 29);
            formatToolStripMenuItem.Text = "Format";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // mnuContext
            // 
            mnuContext.ImageScalingSize = new Size(24, 24);
            mnuContext.Items.AddRange(new ToolStripItem[] { cutToolStripMenuItem, coppyToolStripMenuItem, pasteToolStripMenuItem });
            mnuContext.Name = "contextMenuStrip1";
            mnuContext.Size = new Size(127, 100);
            mnuContext.Text = "Context Menu";
            mnuContext.Opening += contextMenuStrip1_Opening;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(126, 32);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click_1;
            // 
            // coppyToolStripMenuItem
            // 
            coppyToolStripMenuItem.Name = "coppyToolStripMenuItem";
            coppyToolStripMenuItem.Size = new Size(126, 32);
            coppyToolStripMenuItem.Text = "Copy";
            coppyToolStripMenuItem.Click += coppyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(126, 32);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click_1;
            // 
            // richTextBox1
            // 
            richTextBox1.ContextMenuStrip = mnuContext;
            richTextBox1.Location = new Point(0, 36);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 416);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // dlgOpenfile
            // 
            dlgOpenfile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = mnuContext;
            Controls.Add(richTextBox1);
            Controls.Add(mnuMainMenu);
            HelpButton = true;
            MainMenuStrip = mnuMainMenu;
            Name = "Form1";
            Text = "Cập nhật";
            Load += Form1_Load;
            mnuMainMenu.ResumeLayout(false);
            mnuMainMenu.PerformLayout();
            mnuContext.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMainMenu;
        private ToolStripMenuItem fToolStripMenuItem;
        private ToolStripMenuItem nToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saverToolStripMenuItem;
        private ToolStripSeparator exitToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ContextMenuStrip mnuContext;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem coppyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private RichTextBox richTextBox1;
        private OpenFileDialog dlgOpenfile;
        private SaveFileDialog dlgSaveFile;
        private FontDialog dlgFont;
        private ColorDialog dlgColor;
    }
}
