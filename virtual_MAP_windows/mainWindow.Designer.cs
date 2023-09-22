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
            diel = new Button();
            tei = new Button();
            zoz = new Button();
            pictureBox2 = new PictureBox();
            podk = new Button();
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
            button200 = new Label();
            button700 = new Label();
            dielneButton = new Label();
            teiButton = new Label();
            pictureBox4 = new PictureBox();
            tabPage2 = new TabPage();
            label3 = new Label();
            tabPage3 = new TabPage();
            label1 = new Label();
            tabPage4 = new TabPage();
            label6 = new Label();
            tabPage5 = new TabPage();
            label7 = new Label();
            tabPage6 = new TabPage();
            label5 = new Label();
            tabPage7 = new TabPage();
            label2 = new Label();
            tabPage8 = new TabPage();
            label4 = new Label();
            tabPage9 = new TabPage();
            clearSearch = new Button();
            textBox1 = new TextBox();
            pictureBox5 = new PictureBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            Nazov = new DataGridViewTextBoxColumn();
            Predmety = new DataGridViewTextBoxColumn();
            Popis = new DataGridViewTextBoxColumn();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeIcon).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage8.SuspendLayout();
            tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(34, 97, 140);
            leftPanel.Controls.Add(pictureBox1);
            leftPanel.Controls.Add(diel);
            leftPanel.Controls.Add(tei);
            leftPanel.Controls.Add(zoz);
            leftPanel.Controls.Add(pictureBox2);
            leftPanel.Controls.Add(podk);
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
            // diel
            // 
            diel.FlatAppearance.BorderSize = 0;
            diel.FlatStyle = FlatStyle.Flat;
            diel.Font = new Font("Bahnschrift SemiBold Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            diel.ForeColor = Color.White;
            diel.Location = new Point(0, 262);
            diel.Margin = new Padding(0);
            diel.Name = "diel";
            diel.Size = new Size(223, 57);
            diel.TabIndex = 13;
            diel.Text = "Dielne";
            diel.UseVisualStyleBackColor = true;
            diel.Click += changeTab;
            // 
            // tei
            // 
            tei.FlatAppearance.BorderSize = 0;
            tei.FlatStyle = FlatStyle.Flat;
            tei.Font = new Font("Bahnschrift SemiBold Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            tei.ForeColor = Color.White;
            tei.Location = new Point(0, 205);
            tei.Margin = new Padding(0);
            tei.Name = "tei";
            tei.Size = new Size(223, 57);
            tei.TabIndex = 12;
            tei.Text = "TEI";
            tei.UseVisualStyleBackColor = true;
            tei.Click += changeTab;
            // 
            // zoz
            // 
            zoz.FlatAppearance.BorderSize = 0;
            zoz.FlatStyle = FlatStyle.Flat;
            zoz.Font = new Font("Bahnschrift SemiBold Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            zoz.ForeColor = Color.White;
            zoz.Image = Properties.Resources.table;
            zoz.ImageAlign = ContentAlignment.MiddleLeft;
            zoz.Location = new Point(0, 722);
            zoz.Margin = new Padding(0);
            zoz.Name = "zoz";
            zoz.Size = new Size(223, 58);
            zoz.TabIndex = 10;
            zoz.Text = "Zoznam učební";
            zoz.TextAlign = ContentAlignment.MiddleRight;
            zoz.UseVisualStyleBackColor = true;
            zoz.Click += changeTab;
            zoz.MouseEnter += button1_MouseEnter;
            zoz.MouseLeave += button1_MouseLeave;
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
            // podk
            // 
            podk.FlatAppearance.BorderSize = 0;
            podk.FlatStyle = FlatStyle.Flat;
            podk.Font = new Font("Bahnschrift SemiBold Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            podk.ForeColor = Color.White;
            podk.Location = new Point(0, 547);
            podk.Margin = new Padding(0);
            podk.Name = "podk";
            podk.Size = new Size(223, 57);
            podk.TabIndex = 9;
            podk.Text = "Podkrovie";
            podk.UseVisualStyleBackColor = true;
            podk.Click += changeTab;
            podk.MouseEnter += button1_MouseEnter;
            podk.MouseLeave += button1_MouseLeave;
            // 
            // p5
            // 
            p5.FlatAppearance.BorderSize = 0;
            p5.FlatStyle = FlatStyle.Flat;
            p5.Font = new Font("Bahnschrift SemiBold Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            p5.ForeColor = Color.White;
            p5.Location = new Point(0, 490);
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
            p4.Location = new Point(0, 433);
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
            p3.Location = new Point(0, 376);
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
            p2.Location = new Point(0, 319);
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
            p1.Text = "Vestibul";
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
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Controls.Add(tabPage9);
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
            tabPage1.Controls.Add(button200);
            tabPage1.Controls.Add(button700);
            tabPage1.Controls.Add(dielneButton);
            tabPage1.Controls.Add(teiButton);
            tabPage1.Controls.Add(pictureBox4);
            tabPage1.Location = new Point(4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1223, 749);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // button200
            // 
            button200.AutoSize = true;
            button200.Cursor = Cursors.PanNorth;
            button200.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            button200.Location = new Point(700, 208);
            button200.Name = "button200";
            button200.Size = new Size(75, 41);
            button200.TabIndex = 8;
            button200.Text = "200";
            button200.Click += zmenaPoschodiaButton_Click;
            // 
            // button700
            // 
            button700.AutoSize = true;
            button700.Cursor = Cursors.PanNorth;
            button700.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            button700.Location = new Point(270, 208);
            button700.Name = "button700";
            button700.Size = new Size(75, 41);
            button700.TabIndex = 7;
            button700.Text = "700";
            button700.Click += zmenaPoschodiaButton_Click;
            // 
            // dielneButton
            // 
            dielneButton.AutoSize = true;
            dielneButton.Cursor = Cursors.PanNorth;
            dielneButton.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            dielneButton.Location = new Point(184, 74);
            dielneButton.Name = "dielneButton";
            dielneButton.Size = new Size(144, 41);
            dielneButton.TabIndex = 6;
            dielneButton.Text = "DIELNE";
            dielneButton.Click += zmenaPoschodiaButton_Click;
            // 
            // teiButton
            // 
            teiButton.AutoSize = true;
            teiButton.Cursor = Cursors.PanWest;
            teiButton.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            teiButton.Location = new Point(39, 314);
            teiButton.Name = "teiButton";
            teiButton.Size = new Size(71, 41);
            teiButton.TabIndex = 5;
            teiButton.Text = "TEI";
            teiButton.Click += zmenaPoschodiaButton_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.vestibul;
            pictureBox4.Location = new Point(3, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1217, 740);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(47, 118, 165);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1223, 749);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Location = new Point(113, 203);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 0;
            label3.Text = "706";
            label3.Click += loadClassroom;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(47, 118, 165);
            tabPage3.Controls.Add(label1);
            tabPage3.Location = new Point(4, 5);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1223, 749);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Location = new Point(599, 367);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 1;
            label1.Text = "306";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(47, 118, 165);
            tabPage4.Controls.Add(label6);
            tabPage4.Location = new Point(4, 5);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1223, 749);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Location = new Point(598, 367);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 3;
            label6.Text = "404";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.FromArgb(47, 118, 165);
            tabPage5.Controls.Add(label7);
            tabPage5.Location = new Point(4, 5);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1223, 749);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Location = new Point(599, 367);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 4;
            label7.Text = "504";
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.FromArgb(47, 118, 165);
            tabPage6.Controls.Add(label5);
            tabPage6.Location = new Point(4, 5);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1223, 749);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tabPage6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Location = new Point(599, 367);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 4;
            label5.Text = "p3";
            // 
            // tabPage7
            // 
            tabPage7.BackColor = Color.FromArgb(47, 118, 165);
            tabPage7.Controls.Add(label2);
            tabPage7.Location = new Point(4, 5);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(1223, 749);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "tabPage7";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Location = new Point(520, 146);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "TEI3";
            // 
            // tabPage8
            // 
            tabPage8.BackColor = Color.FromArgb(47, 118, 165);
            tabPage8.Controls.Add(label4);
            tabPage8.Location = new Point(4, 5);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(1223, 749);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "tabPage8";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Location = new Point(597, 367);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 2;
            label4.Text = "D14";
            // 
            // tabPage9
            // 
            tabPage9.BackColor = Color.FromArgb(47, 118, 165);
            tabPage9.Controls.Add(textBox1);
            tabPage9.Controls.Add(label8);
            tabPage9.Controls.Add(clearSearch);
            tabPage9.Controls.Add(pictureBox5);
            tabPage9.Controls.Add(dataGridView1);
            tabPage9.Location = new Point(4, 5);
            tabPage9.Name = "tabPage9";
            tabPage9.Padding = new Padding(3);
            tabPage9.Size = new Size(1223, 749);
            tabPage9.TabIndex = 8;
            tabPage9.Text = "tabPage9";
            // 
            // clearSearch
            // 
            clearSearch.FlatAppearance.BorderSize = 0;
            clearSearch.FlatStyle = FlatStyle.Flat;
            clearSearch.Font = new Font("Bahnschrift SemiBold Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            clearSearch.ForeColor = Color.White;
            clearSearch.Location = new Point(936, 3);
            clearSearch.Margin = new Padding(0);
            clearSearch.Name = "clearSearch";
            clearSearch.Size = new Size(287, 53);
            clearSearch.TabIndex = 6;
            clearSearch.Text = "Vymazať vyhľadávanie";
            clearSearch.UseVisualStyleBackColor = true;
            clearSearch.Click += clearSearch_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(34, 97, 140);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Bahnschrift SemiBold Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(217, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(578, 39);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.search;
            pictureBox5.Location = new Point(7, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(61, 47);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiBold Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(59, 11);
            label8.Name = "label8";
            label8.Size = new Size(162, 39);
            label8.TabIndex = 2;
            label8.Text = "Vyhľadávanie:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(47, 118, 165);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nazov, Predmety, Popis });
            dataGridView1.GridColor = Color.FromArgb(39, 103, 148);
            dataGridView1.Location = new Point(0, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1223, 693);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellClick;
            // 
            // Nazov
            // 
            Nazov.HeaderText = "Nazov";
            Nazov.Name = "Nazov";
            Nazov.ReadOnly = true;
            // 
            // Predmety
            // 
            Predmety.HeaderText = "Predmety";
            Predmety.Name = "Predmety";
            Predmety.ReadOnly = true;
            Predmety.Width = 200;
            // 
            // Popis
            // 
            Popis.HeaderText = "Popis";
            Popis.Name = "Popis";
            Popis.ReadOnly = true;
            Popis.Width = 879;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            tabPage9.ResumeLayout(false);
            tabPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button zoz;
        private Button podk;
        private Button p5;
        private Button p4;
        private Button p3;
        private Button p2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private Label label3;
        private Button diel;
        private Button tei;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private PictureBox pictureBox4;
        private Label teiButton;
        private Label button200;
        private Label button700;
        private Label dielneButton;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nazov;
        private DataGridViewTextBoxColumn Predmety;
        private DataGridViewTextBoxColumn Popis;
        private TextBox textBox1;
        private Label label8;
        private PictureBox pictureBox5;
        private Button clearSearch;
    }
}