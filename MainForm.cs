using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using Ookii.Dialogs;
using System.Reflection;

namespace PhotoOrganizer
{
    public partial class MainForm : Form
    {
        private RenameDialog m_renameDialog = new RenameDialog();
        private StripExifDataDialog m_stripExifDataDialog = new StripExifDataDialog();
        private string m_folderPath = null;
        private int m_position = 0;
        private List<string> m_pictureFiles = new List<string>();
        private bool m_mouseDown = false;
        private Point m_mouseHeldPoint;

        public MainForm()
        {
            InitializeComponent();
            SetDefaultPicture();
            SetFormsIcon();
        }

        private void SetFormsIcon()
        {
            typeof(Form).GetField("defaultIcon",
                BindingFlags.NonPublic | BindingFlags.Static)
                .SetValue(null, Properties.Resources.gnome_mime_image);
        }

        private void SetDefaultPicture()
        {
            pictureBox1.Image = Properties.Resources.nofolderloaded;
        }

        private void RepaintPictureBox()
        {
            if (m_pictureFiles.Count == 0)
            {
                DisableUIItems();
                SetDefaultPicture();

                return;
            }

            pictureBox1.ImageLocation = m_pictureFiles[m_position];
            lblImagePosition.Text = String.Format("{0}/{1}", m_position + 1, m_pictureFiles.Count);
            lblName.Text = Path.GetFileName(m_pictureFiles[m_position]);
            this.Text = m_pictureFiles[m_position] + " - Photo Organizer";
        }

        private void EnableUIItems()
        {
            recycleImageToolStripMenuItem.Enabled = true;
            nextImageToolStripMenuItem.Enabled = true;
            previousImageToolStripMenuItem.Enabled = true;
            deleteToolStripMenuItem.Enabled = true;
            moveToSubFolderToolStripMenuItem.Enabled = true;
            renameAllFilesInFolderToolStripMenuItem.Enabled = true;
            rotateRightToolStripMenuItem.Enabled = true;
            rotateLeftToolStripMenuItem.Enabled = true;
            stripExifDataFromAllFilesInFolderToolStripMenuItem.Enabled = true;
            lblImagePosition.Visible = true;
            lblName.Visible = true;
            pictureBox1.Enabled = true;
            fitWidthToolStripMenuItem.Enabled = true;
            sliderToolStripMenuItem.Enabled = true;
            tiledToolStripMenuItem.Enabled = true;

            groupBox1.Enabled = true;
        }

        private void DisableUIItems()
        {
            recycleImageToolStripMenuItem.Enabled = false;
            nextImageToolStripMenuItem.Enabled = false;
            previousImageToolStripMenuItem.Enabled = false;
            deleteToolStripMenuItem.Enabled = false;
            moveToSubFolderToolStripMenuItem.Enabled = false;
            renameAllFilesInFolderToolStripMenuItem.Enabled = false;
            rotateRightToolStripMenuItem.Enabled = false;
            rotateLeftToolStripMenuItem.Enabled = false;
            stripExifDataFromAllFilesInFolderToolStripMenuItem.Enabled = false;
            lblImagePosition.Visible = false;
            lblName.Visible = false;
            pictureBox1.Enabled = false;
            fitWidthToolStripMenuItem.Enabled = false;
            sliderToolStripMenuItem.Enabled = false;
            tiledToolStripMenuItem.Enabled = false;

            groupBox1.Enabled = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (VistaFolderBrowserDialog browserDialog = new VistaFolderBrowserDialog())
            {
                if (browserDialog.ShowDialog() == DialogResult.OK)
                {
                    m_folderPath = browserDialog.SelectedPath;

                    LoadFiles();
                }
            }
        }

        private void LoadFiles()
        {
            string[] pictures = Directory.GetFiles(m_folderPath, "*.jpg");

            if (pictures.Length > 0)
            {
                m_pictureFiles = new List<string>(pictures);
                m_position = 0;

                RepaintPictureBox();
                EnableUIItems();

                pictureBox1.MouseDown += new MouseEventHandler(pictureBoxPanel_MouseDown);
                pictureBox1.MouseUp += new MouseEventHandler(pictureBoxPanel_MouseUp);
                pictureBox1.MouseMove += new MouseEventHandler(pictureBoxPanel_MouseMove);
            }
        }

        void pictureBoxPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Enabled)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Point currentPoint = pictureBox1.PointToScreen(e.Location);
                    int xDelta = currentPoint.X - m_mouseHeldPoint.X;
                    int yDelta = currentPoint.Y - m_mouseHeldPoint.Y;

                    pictureBox1.Location = new Point(pictureBox1.Location.X + xDelta, pictureBox1.Location.Y + yDelta);
                    m_mouseHeldPoint = currentPoint;
                }
            }
        }

        void pictureBoxPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Enabled)
            {
                m_mouseDown = false;

                pictureBox1.Cursor = Cursors.Default;
            }
        }

        void pictureBoxPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Enabled)
            {
                if (e.Button == MouseButtons.Left)
                {
                    m_mouseDown = true;
                    m_mouseHeldPoint = pictureBox1.PointToScreen(e.Location);

                    pictureBox1.Cursor = Cursors.SizeAll;
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (m_pictureFiles.Count == 0)
            {
                return;
            }

            if (m_position - 1 >= 0)
            {
                m_position--;
            }
            else
            {
                m_position = m_pictureFiles.Count - 1;
            }

            RepaintPictureBox();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (m_pictureFiles.Count == 0)
            {
                return;
            }

            if (m_position + 1 < m_pictureFiles.Count)
            {
                m_position++;
            }
            else
            {
                m_position = 0;
            }

            RepaintPictureBox();
        }

        private void nextPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNext_Click(null, null);
        }

        private void previousPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPrevious_Click(null, null);
        }


        //Keyboard shortcuts
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.N || keyData == Keys.Right || keyData == Keys.Up)
            {
                btnNext_Click(null, null);
            }

            if (keyData == Keys.P || keyData == Keys.M || keyData == Keys.Down || keyData == Keys.Left)
            {
                btnPrevious_Click(null, null);
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        //Mouse shortcuts
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (pictureBox1.Enabled)
            {
                if (e.Delta > 0)
                {
                    //Zoom
                    if (pictureBox1.Width > 5000)
                    {
                        return;
                    }
                }
                else
                {
                    //Unzoom
                    if (pictureBox1.Width < 100)
                    {
                        return;
                    }
                }

                pictureBox1.Width += (pictureBox1.Width * e.Delta) / 1000;
                pictureBox1.Height += (pictureBox1.Height * e.Delta) / 1000;

                base.OnMouseWheel(e);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.XButton2)
            {
                btnNext_Click(null, null);
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.XButton2)
            {
                btnPrevious_Click(null, null);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.XButton2)
            {
                btnNext_Click(null, null);
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.XButton1)
            {
                btnPrevious_Click(null, null);
            }
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.XButton2)
            {
                btnNext_Click(null, null);
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.XButton1)
            {
                btnPrevious_Click(null, null);
            }
        }

        private void btnMoveToSubFolder_Click(object sender, EventArgs e)
        {
            string folderName = tbFolderToMove.Text;

            string badImagePath = Path.Combine(m_folderPath, folderName);

            if (!Directory.Exists(badImagePath))
            {
                Directory.CreateDirectory(badImagePath);
            }

            //Moves file to the specified folder
            File.Move(m_pictureFiles[m_position], Path.Combine(badImagePath, Path.GetFileName(m_pictureFiles[m_position])));

            //Clean up our pointers and our list of images
            m_pictureFiles.RemoveAt(m_position);

            if (m_position == m_pictureFiles.Count)
            {
                m_position = 0;
            }

            RepaintPictureBox();
        }

        private void btnRecycle_Click(object sender, EventArgs e)
        {
            //Moves file to recycle bin - why the heck is this in the visual basic DLL? Thanks Microsoft.
            FileSystem.DeleteFile(m_pictureFiles[m_position], UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);

            //Clean up our pointers and our list of images
            m_pictureFiles.RemoveAt(m_position);

            if (m_position == m_pictureFiles.Count)
            {
                m_position = 0;
            }

            RepaintPictureBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this image?", "Confirm delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                File.Delete(m_pictureFiles[m_position]);

                //Clean up our pointers and our list of images
                m_pictureFiles.RemoveAt(m_position);

                if (m_position == m_pictureFiles.Count)
                {
                    m_position = 0;
                }

                RepaintPictureBox();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelete_Click(null, null);
        }

        private void nextImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNext_Click(null, null);
        }

        private void previousImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPrevious_Click(null, null);
        }

        private void recycleImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRecycle_Click(null, null);
        }

        private void moveToSubFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMoveToSubFolder_Click(null, null);
        }

        private void renameAllFilesInFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_renameDialog.PictureList = m_pictureFiles;
            m_renameDialog.StartPosition = FormStartPosition.CenterParent;
            m_renameDialog.ShowDialog(this);

            //Reset pictures, as the current folder could have completely differently renamed files.
            LoadFiles();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Refresh();
        }

        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox1.Refresh();
        }

        private void rotateRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRotateRight_Click(sender, e);
        }

        private void rotateLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRotateLeft_Click(sender, e);
        }

        private void stripExifDataFromAllFilesInFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_stripExifDataDialog.FolderPath = m_folderPath;
            m_stripExifDataDialog.StartPosition = FormStartPosition.CenterParent;
            m_stripExifDataDialog.ShowDialog(this);

            //Reset pictures, as the exif metadata is now destroyed
            LoadFiles();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutPhotoOrganizer about = new AboutPhotoOrganizer();
            about.StartPosition = FormStartPosition.CenterParent;
            about.ShowDialog(this);
        }

        private void btnViewExifData_Click(object sender, EventArgs e)
        {
            ExifDataDisplay dataDisplay = new ExifDataDisplay(m_pictureFiles[m_position]);
            dataDisplay.StartPosition = FormStartPosition.CenterParent;
            dataDisplay.ShowDialog(this);
        }

        private void btnFitWidth_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = this.Width - 40;
            pictureBox1.Height = this.Height - 140;

            pictureBoxPanel.Width = this.Width - 30;
            pictureBoxPanel.Height = this.Height - 130;

            pictureBox1.Location = new Point(0, 0);
        }

        private void fitWidthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFitWidth_Click(null, null);
        }

        private void sliderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SliderViewer sliderViewer = new SliderViewer(m_pictureFiles, m_position);

            sliderViewer.StartPosition = FormStartPosition.CenterParent;
            sliderViewer.ShowDialog(this);

            m_position = sliderViewer.SliderPosition;
            m_pictureFiles = sliderViewer.PictureList;

            RepaintPictureBox();
        }

        private void menuStrip1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Width = this.Width - 40;
            pictureBox1.Height = this.Height - 140;

            pictureBoxPanel.Width = this.Width - 30;
            pictureBoxPanel.Height = this.Height - 130;

            pictureBox1.Location = new Point(0, 0);
        }
    }
}
