namespace tonkIDE
{
    partial class TonkIDE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TonkIDE));
            label1 = new Label();
            new_txt = new Button();
            open_txt = new Button();
            open_cpp = new Button();
            new_cpp = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 48F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(248, 86);
            label1.TabIndex = 0;
            label1.Text = "TonkIDE";
            // 
            // new_txt
            // 
            new_txt.BackColor = Color.FromArgb(64, 64, 64);
            new_txt.FlatStyle = FlatStyle.Flat;
            new_txt.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            new_txt.ForeColor = SystemColors.ButtonFace;
            new_txt.Location = new Point(657, 221);
            new_txt.Name = "new_txt";
            new_txt.Size = new Size(257, 66);
            new_txt.TabIndex = 1;
            new_txt.Text = "New Text File";
            new_txt.TextAlign = ContentAlignment.MiddleRight;
            new_txt.UseVisualStyleBackColor = false;
            new_txt.Click += new_txt_Click;
            // 
            // open_txt
            // 
            open_txt.BackColor = Color.FromArgb(64, 64, 64);
            open_txt.FlatStyle = FlatStyle.Flat;
            open_txt.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            open_txt.ForeColor = SystemColors.ButtonFace;
            open_txt.Location = new Point(657, 313);
            open_txt.Name = "open_txt";
            open_txt.Size = new Size(257, 66);
            open_txt.TabIndex = 2;
            open_txt.Text = "Open Text File";
            open_txt.TextAlign = ContentAlignment.MiddleRight;
            open_txt.UseVisualStyleBackColor = false;
            open_txt.Click += open_txt_Click;
            // 
            // open_cpp
            // 
            open_cpp.BackColor = Color.FromArgb(64, 64, 64);
            open_cpp.FlatStyle = FlatStyle.Flat;
            open_cpp.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            open_cpp.ForeColor = SystemColors.ButtonFace;
            open_cpp.Location = new Point(367, 313);
            open_cpp.Name = "open_cpp";
            open_cpp.Size = new Size(257, 66);
            open_cpp.TabIndex = 4;
            open_cpp.Text = "Open C++ File";
            open_cpp.TextAlign = ContentAlignment.MiddleRight;
            open_cpp.UseVisualStyleBackColor = false;
            open_cpp.Click += open_cpp_Click;
            // 
            // new_cpp
            // 
            new_cpp.BackColor = Color.FromArgb(64, 64, 64);
            new_cpp.FlatStyle = FlatStyle.Flat;
            new_cpp.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            new_cpp.ForeColor = SystemColors.ButtonFace;
            new_cpp.Location = new Point(367, 221);
            new_cpp.Name = "new_cpp";
            new_cpp.Size = new Size(257, 66);
            new_cpp.TabIndex = 3;
            new_cpp.Text = "New C++ File";
            new_cpp.TextAlign = ContentAlignment.MiddleRight;
            new_cpp.UseVisualStyleBackColor = false;
            new_cpp.Click += new_cpp_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(26, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 320);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // TonkIDE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(1001, 611);
            Controls.Add(pictureBox1);
            Controls.Add(open_cpp);
            Controls.Add(new_cpp);
            Controls.Add(open_txt);
            Controls.Add(new_txt);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TonkIDE";
            Text = "TonkIDE";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button new_txt;
        private Button open_txt;
        private Button open_cpp;
        private Button new_cpp;
        private PictureBox pictureBox1;
    }
}
