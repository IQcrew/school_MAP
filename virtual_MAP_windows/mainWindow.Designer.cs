namespace virtual_MAP_windows
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            leftPanel = new Panel();
            pictureBox1 = new PictureBox();
            button7 = new Button();
            pictureBox2 = new PictureBox();
            table = new Button();
            p5 = new Button();
            p4 = new Button();
            p3 = new Button();
            p2 = new Button();
            p1 = new Button();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            minimizeIcon = new PictureBox();
            closeIcon = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeIcon).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(34, 97, 140);
            leftPanel.Controls.Add(pictureBox1);
            leftPanel.Controls.Add(button7);
            leftPanel.Controls.Add(pictureBox2);
            leftPanel.Controls.Add(table);
            leftPanel.Controls.Add(p5);
            leftPanel.Controls.Add(p4);
            leftPanel.Controls.Add(p3);
            leftPanel.Controls.Add(p2);
            leftPanel.Controls.Add(p1);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(227, 780);
            leftPanel.TabIndex = 0;
            leftPanel.MouseDown += DraggableWindow_MouseDown;
            leftPanel.MouseMove += DraggableWindow_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(160, 230, 60);
            pictureBox1.Location = new Point(222, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(5, 746);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Bahnschrift SemiBold Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Image = Properties.Resources.table;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 722);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(223, 58);
            button7.TabIndex = 10;
            button7.Text = "Zoznam učební";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseVisualStyleBackColor = true;
            button7.Click += changeTab;
            button7.MouseEnter += button1_MouseEnter;
            button7.MouseLeave += button1_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.spsit;
            pictureBox2.Location = new Point(12, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // table
            // 
            table.FlatAppearance.BorderSize = 0;
            table.FlatStyle = FlatStyle.Flat;
            table.Font = new Font("Bahnschrift SemiBold Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            table.ForeColor = Color.White;
            table.Location = new Point(0, 433);
            table.Margin = new Padding(0);
            table.Name = "table";
            table.Size = new Size(223, 57);
            table.TabIndex = 9;
            table.Text = "Podkrovie";
            table.UseVisualStyleBackColor = true;
            table.Click += changeTab;
            table.MouseEnter += button1_MouseEnter;
            table.MouseLeave += button1_MouseLeave;
            // 
            // p5
            // 
            p5.FlatAppearance.BorderSize = 0;
            p5.FlatStyle = FlatStyle.Flat;
            p5.Font = new Font("Bahnschrift SemiBold Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            p5.ForeColor = Color.White;
            p5.Location = new Point(0, 376);
            p5.Margin = new Padding(0);
            p5.Name = "p5";
            p5.Size = new Size(223, 57);
            p5.TabIndex = 8;
            p5.Text = "Poschodie 5";
            p5.UseVisualStyleBackColor = true;
            p5.Click += changeTab;
            p5.MouseEnter += button1_MouseEnter;
            p5.MouseLeave += button1_MouseLeave;
            // 
            // p4
            // 
            p4.FlatAppearance.BorderSize = 0;
            p4.FlatStyle = FlatStyle.Flat;
            p4.Font = new Font("Bahnschrift SemiBold Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            p4.ForeColor = Color.White;
            p4.Location = new Point(0, 319);
            p4.Margin = new Padding(0);
            p4.Name = "p4";
            p4.Size = new Size(223, 57);
            p4.TabIndex = 7;
            p4.Text = "Poschodie 4";
            p4.UseVisualStyleBackColor = true;
            p4.Click += changeTab;
            p4.MouseEnter += button1_MouseEnter;
            p4.MouseLeave += button1_MouseLeave;
            // 
            // p3
            // 
            p3.FlatAppearance.BorderSize = 0;
            p3.FlatStyle = FlatStyle.Flat;
            p3.Font = new Font("Bahnschrift SemiBold Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            p3.ForeColor = Color.White;
            p3.Location = new Point(0, 262);
            p3.Margin = new Padding(0);
            p3.Name = "p3";
            p3.Size = new Size(223, 57);
            p3.TabIndex = 6;
            p3.Text = "Poschodie 3";
            p3.UseVisualStyleBackColor = true;
            p3.Click += changeTab;
            p3.MouseEnter += button1_MouseEnter;
            p3.MouseLeave += button1_MouseLeave;
            // 
            // p2
            // 
            p2.FlatAppearance.BorderSize = 0;
            p2.FlatStyle = FlatStyle.Flat;
            p2.Font = new Font("Bahnschrift SemiBold Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            p2.ForeColor = Color.White;
            p2.Location = new Point(0, 205);
            p2.Margin = new Padding(0);
            p2.Name = "p2";
            p2.Size = new Size(223, 57);
            p2.TabIndex = 5;
            p2.Text = "Poschodie 2";
            p2.UseVisualStyleBackColor = true;
            p2.Click += changeTab;
            p2.MouseEnter += button1_MouseEnter;
            p2.MouseLeave += button1_MouseLeave;
            // 
            // p1
            // 
            p1.FlatAppearance.BorderSize = 0;
            p1.FlatStyle = FlatStyle.Flat;
            p1.Font = new Font("Bahnschrift SemiBold Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            p1.ForeColor = Color.White;
            p1.Location = new Point(0, 148);
            p1.Margin = new Padding(0);
            p1.Name = "p1";
            p1.Size = new Size(223, 57);
            p1.TabIndex = 0;
            p1.Text = "Poschodie 1";
            p1.UseVisualStyleBackColor = true;
            p1.Click += changeTab;
            p1.MouseEnter += button1_MouseEnter;
            p1.MouseLeave += button1_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 74, 110);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(minimizeIcon);
            panel2.Controls.Add(closeIcon);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1593, 36);
            panel2.TabIndex = 1;
            panel2.MouseDown += DraggableWindow_MouseDown;
            panel2.MouseMove += DraggableWindow_MouseMove;
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
            minimizeIcon.Location = new Point(1377, 0);
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
            closeIcon.Location = new Point(1413, 0);
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
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.Location = new Point(222, 26);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(0, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1231, 758);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(47, 118, 165);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1223, 749);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Location = new Point(387, 285);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "204";
            label1.Click += loadClassroom;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(47, 118, 165);
            tabPage2.Location = new Point(4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1223, 749);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(47, 118, 165);
            tabPage3.Location = new Point(4, 5);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1223, 749);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(47, 118, 165);
            tabPage4.Location = new Point(4, 5);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1223, 749);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.FromArgb(47, 118, 165);
            tabPage5.Location = new Point(4, 5);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1223, 749);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.FromArgb(47, 118, 165);
            tabPage6.Location = new Point(4, 5);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1223, 749);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tabPage6";
            // 
            // tabPage7
            // 
            tabPage7.BackColor = Color.FromArgb(47, 118, 165);
            tabPage7.Location = new Point(4, 5);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(1223, 749);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "tabPage7";
            // 
            // mainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 118, 165);
            ClientSize = new Size(1449, 780);
            Controls.Add(panel2);
            Controls.Add(leftPanel);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainWindow";
            Text = "MAP";
            Load += Form1_Load;
            MouseDown += DraggableWindow_MouseDown;
            MouseMove += DraggableWindow_MouseMove;
            leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeIcon).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel leftPanel;
        private Panel panel2;
        private PictureBox minimizeIcon;
        private PictureBox closeIcon;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private PictureBox pictureBox1;
        private Button p1;
        private Button button7;
        private Button table;
        private Button p5;
        private Button p4;
        private Button p3;
        private Button p2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
    }
}