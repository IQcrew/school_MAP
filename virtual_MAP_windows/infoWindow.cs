using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace virtual_MAP_windows
{
    public partial class infoWindow : Form
    {
        bool editTextMode = false;
        private Point dragStartPoint;
        List<infoWindow> openedWindows;
        string constantPath = @"src\rooms";
        string textPath;
        string imagePath;
        Image tempImage;
        public infoWindow(string number, List<infoWindow> opendW)
        {
            InitializeComponent();
            Location = Point.Add(Cursor.Position, new Size(18, 10));
            Text = number;
            label1.Text = number;
            openedWindows = opendW;
            textPath = @$"{constantPath}\{this.Text}.txt";
            imagePath = @$"{constantPath}\{this.Text}.jpg";
        }
        private void infoWindow_Load(object sender, EventArgs e)
        {
            editText.Focus();
            if (File.Exists(textPath))
            { 
                richTextBox1.Text = File.ReadAllText(textPath);
            }
            else
            {
                File.Create(textPath).Close();
            }

            if (File.Exists(imagePath))
            {
                tempImage = Image.FromFile(imagePath);
                pictureBox1.Image = tempImage;
            }

        }
        private void editText_Click(object sender, EventArgs e)
        {
            editTextMode = !editTextMode;
            if (editTextMode)
            {
                editText.BackColor = Color.Black;
                richTextBox1.ReadOnly = false;
                richTextBox1.Focus();
            }
            else
            {
                editText.BackColor = Color.FromArgb(39, 103, 148);
                richTextBox1.ReadOnly = true;
                editText.Focus();
                File.WriteAllText(textPath, richTextBox1.Text);
            }
        }

        private void changePicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JPEG Images (*.jpg)|*.jpg|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    pictureBox1.Image = null;
                    if (File.Exists(imagePath)) {
                        pictureBox1.Image = null;
                        tempImage.Dispose();
                        File.Delete(imagePath);
                    }
                    File.Copy(openFileDialog.FileName, imagePath);
                    pictureBox1.ImageLocation = openFileDialog.FileName;
                }
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
            openedWindows.Remove(this);
            this.Close();
        }

        private void minimizewindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Icon_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.FromArgb(25, 82, 121);
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
            if (!editTextMode) { (sender as Button).BackColor = Color.FromArgb(20, 76, 113); }

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (!editTextMode) { (sender as Button).BackColor = Color.FromArgb(39, 103, 148); }
        }

        #endregion



    }
}
