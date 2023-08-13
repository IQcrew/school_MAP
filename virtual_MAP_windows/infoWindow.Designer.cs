namespace virtual_MAP_windows
{
    partial class infoWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infoWindow));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            minimizeIcon = new PictureBox();
            closeIcon = new PictureBox();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            editText = new Button();
            changePicture = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(25, 82, 121);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(minimizeIcon);
            panel2.Controls.Add(closeIcon);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(606, 36);
            panel2.TabIndex = 2;
            panel2.MouseDown += DraggableWindow_MouseDown;
            panel2.MouseMove += DraggableWindow_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(62, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 33);
            label1.TabIndex = 12;
            label1.MouseDown += DraggableWindow_MouseDown;
            label1.MouseMove += DraggableWindow_MouseMove;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.school;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.MouseDown += DraggableWindow_MouseDown;
            pictureBox3.MouseMove += DraggableWindow_MouseMove;
            // 
            // minimizeIcon
            // 
            minimizeIcon.Image = Properties.Resources.winfo_icon_minimize_64;
            minimizeIcon.Location = new Point(496, 0);
            minimizeIcon.Margin = new Padding(0);
            minimizeIcon.Name = "minimizeIcon";
            minimizeIcon.Padding = new Padding(5);
            minimizeIcon.Size = new Size(36, 36);
            minimizeIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            minimizeIcon.TabIndex = 3;
            minimizeIcon.TabStop = false;
            minimizeIcon.Click += minimizewindow_Click;
            minimizeIcon.MouseEnter += minimizeIcon_MouseEnter;
            minimizeIcon.MouseLeave += Icon_MouseLeave;
            // 
            // closeIcon
            // 
            closeIcon.Image = Properties.Resources.x_close_icon_white;
            closeIcon.Location = new Point(532, 0);
            closeIcon.Margin = new Padding(0);
            closeIcon.Name = "closeIcon";
            closeIcon.Padding = new Padding(5);
            closeIcon.Size = new Size(36, 36);
            closeIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            closeIcon.TabIndex = 2;
            closeIcon.TabStop = false;
            closeIcon.Click += closeWindow;
            closeIcon.MouseEnter += closeIcon_MouseEnter;
            closeIcon.MouseLeave += Icon_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(544, 306);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(39, 103, 148);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Bahnschrift SemiBold SemiConden", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(12, 354);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(544, 204);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // editText
            // 
            editText.FlatAppearance.BorderSize = 0;
            editText.FlatStyle = FlatStyle.Flat;
            editText.Font = new Font("Bahnschrift SemiBold Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            editText.ForeColor = Color.White;
            editText.Location = new Point(0, 570);
            editText.Margin = new Padding(0);
            editText.Name = "editText";
            editText.Size = new Size(223, 57);
            editText.TabIndex = 1;
            editText.Text = "Upraviť text";
            editText.UseVisualStyleBackColor = true;
            editText.Click += editText_Click;
            editText.MouseEnter += button1_MouseEnter;
            editText.MouseLeave += button1_MouseLeave;
            // 
            // changePicture
            // 
            changePicture.FlatAppearance.BorderSize = 0;
            changePicture.FlatStyle = FlatStyle.Flat;
            changePicture.Font = new Font("Bahnschrift SemiBold Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            changePicture.ForeColor = Color.White;
            changePicture.Location = new Point(345, 570);
            changePicture.Margin = new Padding(0);
            changePicture.Name = "changePicture";
            changePicture.Size = new Size(223, 57);
            changePicture.TabIndex = 11;
            changePicture.Text = "Zmeniť obrázok";
            changePicture.UseVisualStyleBackColor = true;
            changePicture.Click += changePicture_Click;
            changePicture.MouseEnter += button1_MouseEnter;
            changePicture.MouseLeave += button1_MouseLeave;
            // 
            // infoWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 103, 148);
            ClientSize = new Size(568, 627);
            Controls.Add(changePicture);
            Controls.Add(editText);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "infoWindow";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            Load += infoWindow_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox minimizeIcon;
        private PictureBox closeIcon;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private Button editText;
        private Button changePicture;
        private Label label1;
    }
}