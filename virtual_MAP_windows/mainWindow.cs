using System.Reflection.PortableExecutable;
using System.Collections.Generic;
using System.CodeDom.Compiler;

namespace virtual_MAP_windows
{
    public partial class mainWindow : Form
    {

        //variables

        private Point dragStartPoint;
        public List<infoWindow> openWindows = new List<infoWindow>(); 



        public mainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }










        private void loadClassroom(object sender, EventArgs e)
        {
            string selectedLabel = (sender as Label).Text;
            infoWindow findExisting = openWindows.Find(win => win.Text == selectedLabel);
            if (findExisting == default)
            {
                infoWindow openedWindow = new infoWindow(selectedLabel, openWindows);
                openedWindow.Show();
                openWindows.Add(openedWindow);
            }
            else
            {
                findExisting.BringToFront();
            }
        }

        private void changeTab(object sender, EventArgs e)
        {
            try
            {
                switch ((sender as Button).Name)
                {
                    case "p1":
                        tabControl1.SelectedIndex = 0;
                        break;
                    case "p2":
                        tabControl1.SelectedIndex = 1;
                        break;
                    case "p3":
                        tabControl1.SelectedIndex = 2;
                        break;
                    case "p4":
                        tabControl1.SelectedIndex = 3;
                        break;
                    case "p5":
                        tabControl1.SelectedIndex = 4;
                        break;
                    case "p6":
                        tabControl1.SelectedIndex = 5;
                        break;
                    case "table":
                        tabControl1.SelectedIndex = 6;
                        break;
                }
            }
            catch (Exception ex) { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }


        #region design
        private void DraggableWindow_MouseDown(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button is pressed
            if (e.Button == MouseButtons.Left)
            {
                // Store the starting point of the drag
                dragStartPoint = new Point(e.X, e.Y);
            }
        }

        private void DraggableWindow_MouseMove(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button is pressed and the form is movable
            if (e.Button == MouseButtons.Left && FormBorderStyle != FormBorderStyle.FixedDialog)
            {
                // Calculate the change in position (delta) since the drag started
                int deltaX = e.X - dragStartPoint.X;
                int deltaY = e.Y - dragStartPoint.Y;

                // Calculate the new position of the form
                int newX = Location.X + deltaX;
                int newY = Location.Y + deltaY;

                // Set the new position of the form
                Location = new Point(newX, newY);
            }
        }

        private void closeWindow(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizewindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Icon_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.FromArgb(20, 76, 113);
        }

        private void closeIcon_MouseEnter(object sender, EventArgs e)
        {
            closeIcon.BackColor = Color.Red;
        }

        private void minimizeIcon_MouseEnter(object sender, EventArgs e)
        {
            minimizeIcon.BackColor = Color.Gray;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(20, 76, 113);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(34, 97, 140);
        }


        #endregion

    }
}