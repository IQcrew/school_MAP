using System.Reflection.PortableExecutable;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Text.Json;

namespace virtual_MAP_windows
{
    public partial class mainWindow : Form
    {

        //variables

        private Point dragStartPoint;
        public List<infoWindow> openWindows = new();

        public mainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataManager.innit();
        }



        private void loadClassroom(object sender, EventArgs e)
        {
            string selectedLabel = sender is Label ? (sender as Label).Text : sender.ToString();
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
        private void zmenaPoschodiaButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch ((sender as Label).Text)
                {
                    case "VESTIBUL":
                        tabControl1.SelectedIndex = 0;
                        break;
                    case "200":
                    case "700":
                        tabControl1.SelectedIndex = 1;
                        break;
                    case "300":
                    case "800":
                        tabControl1.SelectedIndex = 2;
                        break;
                    case "400":
                    case "900":
                        tabControl1.SelectedIndex = 3;
                        break;
                    case "1000":
                    case "500":
                        tabControl1.SelectedIndex = 4;
                        break;
                    case "PODKROVIE":
                        tabControl1.SelectedIndex = 5;
                        break;
                    case "TEI":
                        tabControl1.SelectedIndex = 6;
                        break;
                    case "DIELNE":
                        tabControl1.SelectedIndex = 7;
                        break;
                }
            }
            catch (Exception ex) { }
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
                    case "podk":
                        tabControl1.SelectedIndex = 5;
                        break;
                    case "tei":
                        tabControl1.SelectedIndex = 6;
                        break;
                    case "diel":
                        tabControl1.SelectedIndex = 7;
                        break;
                    case "zoz":
                        tabControl1.SelectedIndex = 8;
                        dataGridView1.Rows.Clear();
                        foreach (var key in dataManager.data.Keys)
                        {
                            dataGridView1.Rows.Add(key, dataManager.data[key]["predmety"], dataManager.data[key]["popis"]);
                        }
                        break;
                }
            }
            catch (Exception ex) { }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row and cell is clicked (not the header or empty row)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the data from a specific column (e.g., column with index 1)
                string rowData = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                loadClassroom(rowData, null);
            }
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
            dataManager.writeData();
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