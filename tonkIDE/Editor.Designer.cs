namespace tonkIDE
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveAstxtToolStripMenuItem = new ToolStripMenuItem();
            opentxtToolStripMenuItem = new ToolStripMenuItem();
            newtxtToolStripMenuItem = new ToolStripMenuItem();
            cFIlesToolStripMenuItem = new ToolStripMenuItem();
            saveAscppToolStripMenuItem = new ToolStripMenuItem();
            opencppToolStripMenuItem = new ToolStripMenuItem();
            newcppFileToolStripMenuItem = new ToolStripMenuItem();
            runCToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            backgroundToolStripMenuItem = new ToolStripMenuItem();
            darkToolStripMenuItem = new ToolStripMenuItem();
            whiteToolStripMenuItem = new ToolStripMenuItem();
            obsidianToolStripMenuItem = new ToolStripMenuItem();
            brainHurtToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            pictureBox6 = new PictureBox();
            highlight = new Button();
            pictureBox7 = new PictureBox();
            save_txt = new Button();
            pictureBox8 = new PictureBox();
            open_txt = new Button();
            pictureBox9 = new PictureBox();
            new_txt = new Button();
            pictureBox10 = new PictureBox();
            pictureBox5 = new PictureBox();
            run_cpp = new Button();
            pictureBox4 = new PictureBox();
            save_cpp = new Button();
            pictureBox3 = new PictureBox();
            open_cpp = new Button();
            pictureBox2 = new PictureBox();
            new_cpp = new Button();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            fontDialog1 = new FontDialog();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveAstxtToolStripMenuItem, opentxtToolStripMenuItem, newtxtToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(66, 20);
            fileToolStripMenuItem.Text = "Text Files";
            // 
            // saveAstxtToolStripMenuItem
            // 
            saveAstxtToolStripMenuItem.Name = "saveAstxtToolStripMenuItem";
            saveAstxtToolStripMenuItem.Size = new Size(137, 22);
            saveAstxtToolStripMenuItem.Text = "Save as .txt";
            saveAstxtToolStripMenuItem.Click += saveAstxtToolStripMenuItem_Click;
            // 
            // opentxtToolStripMenuItem
            // 
            opentxtToolStripMenuItem.Name = "opentxtToolStripMenuItem";
            opentxtToolStripMenuItem.Size = new Size(137, 22);
            opentxtToolStripMenuItem.Text = "Open .txt";
            opentxtToolStripMenuItem.Click += opentxtToolStripMenuItem_Click;
            // 
            // newtxtToolStripMenuItem
            // 
            newtxtToolStripMenuItem.Name = "newtxtToolStripMenuItem";
            newtxtToolStripMenuItem.Size = new Size(137, 22);
            newtxtToolStripMenuItem.Text = "New .txt file";
            newtxtToolStripMenuItem.Click += newtxtToolStripMenuItem_Click;
            // 
            // cFIlesToolStripMenuItem
            // 
            cFIlesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveAscppToolStripMenuItem, opencppToolStripMenuItem, newcppFileToolStripMenuItem });
            cFIlesToolStripMenuItem.Name = "cFIlesToolStripMenuItem";
            cFIlesToolStripMenuItem.Size = new Size(69, 20);
            cFIlesToolStripMenuItem.Text = "C++ Files";
            // 
            // saveAscppToolStripMenuItem
            // 
            saveAscppToolStripMenuItem.Name = "saveAscppToolStripMenuItem";
            saveAscppToolStripMenuItem.Size = new Size(145, 22);
            saveAscppToolStripMenuItem.Text = "Save as .cpp";
            saveAscppToolStripMenuItem.Click += saveAscppToolStripMenuItem_Click;
            // 
            // opencppToolStripMenuItem
            // 
            opencppToolStripMenuItem.Name = "opencppToolStripMenuItem";
            opencppToolStripMenuItem.Size = new Size(145, 22);
            opencppToolStripMenuItem.Text = "Open .cpp";
            opencppToolStripMenuItem.Click += opencppToolStripMenuItem_Click;
            // 
            // newcppFileToolStripMenuItem
            // 
            newcppFileToolStripMenuItem.Name = "newcppFileToolStripMenuItem";
            newcppFileToolStripMenuItem.Size = new Size(145, 22);
            newcppFileToolStripMenuItem.Text = "New .cpp File";
            newcppFileToolStripMenuItem.Click += newcppFileToolStripMenuItem_Click;
            // 
            // runCToolStripMenuItem
            // 
            runCToolStripMenuItem.Name = "runCToolStripMenuItem";
            runCToolStripMenuItem.Size = new Size(67, 20);
            runCToolStripMenuItem.Text = "Run C++";
            runCToolStripMenuItem.Click += runCToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, cFIlesToolStripMenuItem, runCToolStripMenuItem, backgroundToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1673, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // backgroundToolStripMenuItem
            // 
            backgroundToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darkToolStripMenuItem, whiteToolStripMenuItem, obsidianToolStripMenuItem, brainHurtToolStripMenuItem });
            backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            backgroundToolStripMenuItem.Size = new Size(83, 20);
            backgroundToolStripMenuItem.Text = "Background";
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new Size(180, 22);
            darkToolStripMenuItem.Text = "Dark";
            darkToolStripMenuItem.Click += darkToolStripMenuItem_Click;
            // 
            // whiteToolStripMenuItem
            // 
            whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            whiteToolStripMenuItem.Size = new Size(180, 22);
            whiteToolStripMenuItem.Text = "White";
            whiteToolStripMenuItem.Click += whiteToolStripMenuItem_Click;
            // 
            // obsidianToolStripMenuItem
            // 
            obsidianToolStripMenuItem.Name = "obsidianToolStripMenuItem";
            obsidianToolStripMenuItem.Size = new Size(180, 22);
            obsidianToolStripMenuItem.Text = "Obsidian";
            obsidianToolStripMenuItem.Click += obsidianToolStripMenuItem_Click;
            // 
            // brainHurtToolStripMenuItem
            // 
            brainHurtToolStripMenuItem.Name = "brainHurtToolStripMenuItem";
            brainHurtToolStripMenuItem.Size = new Size(180, 22);
            brainHurtToolStripMenuItem.Text = "BrainHurt";
            brainHurtToolStripMenuItem.Click += brainHurtToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(35, 35, 35);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(highlight);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(save_txt);
            groupBox1.Controls.Add(pictureBox8);
            groupBox1.Controls.Add(open_txt);
            groupBox1.Controls.Add(pictureBox9);
            groupBox1.Controls.Add(new_txt);
            groupBox1.Controls.Add(pictureBox10);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(run_cpp);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(save_cpp);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(open_cpp);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(new_cpp);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 890);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.None;
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(12, 791);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(46, 46);
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            // 
            // highlight
            // 
            highlight.BackColor = Color.FromArgb(64, 64, 64);
            highlight.FlatStyle = FlatStyle.Flat;
            highlight.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            highlight.ForeColor = SystemColors.ButtonFace;
            highlight.Location = new Point(64, 791);
            highlight.Name = "highlight";
            highlight.Size = new Size(159, 46);
            highlight.TabIndex = 23;
            highlight.Text = "Highlight ";
            highlight.TextAlign = ContentAlignment.MiddleRight;
            highlight.UseVisualStyleBackColor = false;
            highlight.Click += highlight_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.None;
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(12, 349);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(46, 46);
            pictureBox7.TabIndex = 22;
            pictureBox7.TabStop = false;
            // 
            // save_txt
            // 
            save_txt.BackColor = Color.FromArgb(64, 64, 64);
            save_txt.FlatStyle = FlatStyle.Flat;
            save_txt.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            save_txt.ForeColor = SystemColors.ButtonFace;
            save_txt.Location = new Point(64, 349);
            save_txt.Name = "save_txt";
            save_txt.Size = new Size(159, 46);
            save_txt.TabIndex = 21;
            save_txt.Text = "Save Text File";
            save_txt.TextAlign = ContentAlignment.MiddleRight;
            save_txt.UseVisualStyleBackColor = false;
            save_txt.Click += button2_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.None;
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Location = new Point(12, 297);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(46, 46);
            pictureBox8.TabIndex = 20;
            pictureBox8.TabStop = false;
            // 
            // open_txt
            // 
            open_txt.BackColor = Color.FromArgb(64, 64, 64);
            open_txt.FlatStyle = FlatStyle.Flat;
            open_txt.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            open_txt.ForeColor = SystemColors.ButtonFace;
            open_txt.Location = new Point(64, 297);
            open_txt.Name = "open_txt";
            open_txt.Size = new Size(159, 46);
            open_txt.TabIndex = 19;
            open_txt.Text = "Open Text File";
            open_txt.TextAlign = ContentAlignment.MiddleRight;
            open_txt.UseVisualStyleBackColor = false;
            open_txt.Click += open_txt_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = AnchorStyles.None;
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox9.Location = new Point(12, 245);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(46, 46);
            pictureBox9.TabIndex = 18;
            pictureBox9.TabStop = false;
            // 
            // new_txt
            // 
            new_txt.BackColor = Color.FromArgb(64, 64, 64);
            new_txt.FlatStyle = FlatStyle.Flat;
            new_txt.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            new_txt.ForeColor = SystemColors.ButtonFace;
            new_txt.Location = new Point(64, 245);
            new_txt.Name = "new_txt";
            new_txt.Size = new Size(159, 46);
            new_txt.TabIndex = 16;
            new_txt.Text = "New Text File";
            new_txt.TextAlign = ContentAlignment.MiddleRight;
            new_txt.UseVisualStyleBackColor = false;
            new_txt.Click += new_txt_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImage = (Image)resources.GetObject("pictureBox10.BackgroundImage");
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox10.Location = new Point(46, 102);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(123, 123);
            pictureBox10.TabIndex = 17;
            pictureBox10.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(12, 739);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(46, 46);
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // run_cpp
            // 
            run_cpp.BackColor = Color.FromArgb(64, 64, 64);
            run_cpp.FlatStyle = FlatStyle.Flat;
            run_cpp.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            run_cpp.ForeColor = SystemColors.ButtonFace;
            run_cpp.Location = new Point(64, 739);
            run_cpp.Name = "run_cpp";
            run_cpp.Size = new Size(159, 46);
            run_cpp.TabIndex = 14;
            run_cpp.Text = "Run C++ File";
            run_cpp.TextAlign = ContentAlignment.MiddleRight;
            run_cpp.UseVisualStyleBackColor = false;
            run_cpp.Click += run_cpp_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(12, 687);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 46);
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // save_cpp
            // 
            save_cpp.BackColor = Color.FromArgb(64, 64, 64);
            save_cpp.FlatStyle = FlatStyle.Flat;
            save_cpp.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            save_cpp.ForeColor = SystemColors.ButtonFace;
            save_cpp.Location = new Point(64, 687);
            save_cpp.Name = "save_cpp";
            save_cpp.Size = new Size(159, 46);
            save_cpp.TabIndex = 12;
            save_cpp.Text = "Save C++ File";
            save_cpp.TextAlign = ContentAlignment.MiddleRight;
            save_cpp.UseVisualStyleBackColor = false;
            save_cpp.Click += save_cpp_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(12, 635);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 46);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // open_cpp
            // 
            open_cpp.BackColor = Color.FromArgb(64, 64, 64);
            open_cpp.FlatStyle = FlatStyle.Flat;
            open_cpp.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            open_cpp.ForeColor = SystemColors.ButtonFace;
            open_cpp.Location = new Point(64, 635);
            open_cpp.Name = "open_cpp";
            open_cpp.Size = new Size(159, 46);
            open_cpp.TabIndex = 10;
            open_cpp.Text = "Open C++ File";
            open_cpp.TextAlign = ContentAlignment.MiddleRight;
            open_cpp.UseVisualStyleBackColor = false;
            open_cpp.Click += open_cpp_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(12, 583);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 46);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // new_cpp
            // 
            new_cpp.BackColor = Color.FromArgb(64, 64, 64);
            new_cpp.FlatStyle = FlatStyle.Flat;
            new_cpp.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            new_cpp.ForeColor = SystemColors.ButtonFace;
            new_cpp.Location = new Point(64, 583);
            new_cpp.Name = "new_cpp";
            new_cpp.Size = new Size(159, 46);
            new_cpp.TabIndex = 5;
            new_cpp.Text = "New C++ File";
            new_cpp.TextAlign = ContentAlignment.MiddleRight;
            new_cpp.UseVisualStyleBackColor = false;
            new_cpp.Click += new_cpp_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.terminal_24dp_E8EAED_FILL0_wght400_GRAD0_opsz24;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(46, 440);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 123);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(35, 35, 35);
            richTextBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            richTextBox1.ForeColor = Color.Silver;
            richTextBox1.Location = new Point(241, 49);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1420, 881);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Editor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(1673, 958);
            Controls.Add(richTextBox1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Editor";
            Text = "Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveAstxtToolStripMenuItem;
        private ToolStripMenuItem opentxtToolStripMenuItem;
        private ToolStripMenuItem newtxtToolStripMenuItem;
        private ToolStripMenuItem cFIlesToolStripMenuItem;
        private ToolStripMenuItem saveAscppToolStripMenuItem;
        private ToolStripMenuItem opencppToolStripMenuItem;
        private ToolStripMenuItem newcppFileToolStripMenuItem;
        private ToolStripMenuItem runCToolStripMenuItem;
        private MenuStrip menuStrip1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button new_cpp;
        private PictureBox pictureBox5;
        private Button run_cpp;
        private PictureBox pictureBox4;
        private Button save_cpp;
        private PictureBox pictureBox3;
        private Button open_cpp;
        private PictureBox pictureBox2;
        private PictureBox pictureBox7;
        private Button save_txt;
        private PictureBox pictureBox8;
        private Button open_txt;
        private PictureBox pictureBox9;
        private Button new_txt;
        private PictureBox pictureBox10;
        private RichTextBox richTextBox1;
        private FontDialog fontDialog1;
        private PictureBox pictureBox6;
        private Button highlight;
        private ToolStripMenuItem backgroundToolStripMenuItem;
        private ToolStripMenuItem darkToolStripMenuItem;
        private ToolStripMenuItem whiteToolStripMenuItem;
        private ToolStripMenuItem obsidianToolStripMenuItem;
        private ToolStripMenuItem brainHurtToolStripMenuItem;
    }
}