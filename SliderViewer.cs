using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhotoOrganizer
{
    public partial class SliderViewer : Form
    {
        private int m_position;
        private List<string> m_pictureFiles;
        private int m_picturesLoaded = 0;
        private int m_maxNumPicturesLoaded = 20;
        private int m_selection;
        private Dictionary<int, int> indexLookup = new Dictionary<int, int>(); 

        public SliderViewer(List<string> pictureFiles, int position)
        {
            m_position = position;
            m_pictureFiles = pictureFiles;

            InitializeComponent();

            tbImageSelector.SetRange(1, m_pictureFiles.Count);
            tbImageSelector.TickFrequency = 1;
            tbImageSelector.Value = m_position + 1;

            lbImageInformation.Text = String.Format("{0}/{1} : {2}", m_position + 1, m_pictureFiles.Count, m_pictureFiles[m_position]);

            UpdateThumbNail();
        }

        public int SliderPosition
        {
            get { return m_position; }
        }

        public List<string> PictureList
        {
            get { return m_pictureFiles; }
        }

        private void UpdateThumbNail()
        {
            //Cleanup/dispose previous images
            foreach (Control control in flowPanel.Controls)
            {
                Panel picturePanel = (Panel)control;
                PictureBox picture = (PictureBox)picturePanel.Controls[0];
                picture.Dispose();
            }

            GC.Collect();

            flowPanel.Controls.Clear();

            //Get the number of requested pictures to display
            int numRequestedPictures = Convert.ToInt32(numPictures.Value);

            //Get the first half of the number of requested pictures, rounded down.
            int firstHalfRequestedPictures = Convert.ToInt32(Math.Floor((double)numRequestedPictures / 2));
            int secondHalfRequestedPictures = numRequestedPictures - firstHalfRequestedPictures;

            //The first half are *before* the selected image.
            //If we can't show them all, add the ones we can't show to the second half.
            if (m_position - firstHalfRequestedPictures < 0)
            {
                int picturesToAddToSecondHalf = (m_position - firstHalfRequestedPictures) * -1;

                secondHalfRequestedPictures += picturesToAddToSecondHalf;
                firstHalfRequestedPictures = firstHalfRequestedPictures - picturesToAddToSecondHalf;
            }

            //Now we know how many pictures we can show before this picture. Figure out how many we can show after.
            if (m_position + secondHalfRequestedPictures > m_pictureFiles.Count)
            {
                int numberOfImagesOver = (m_pictureFiles.Count - (m_position + secondHalfRequestedPictures)) * -1;
                secondHalfRequestedPictures -= numberOfImagesOver;

                //How many can we add to the first half of requested pictures?
                int firstHalfImageCount = (m_position - (firstHalfRequestedPictures + numberOfImagesOver));

                //If we're below zero at this point, only add images until we get to zero.
                //Otherwise, add all of them.
                if (firstHalfImageCount < 0)
                {
                    firstHalfRequestedPictures += numberOfImagesOver - firstHalfImageCount;
                }
                else
                {
                    firstHalfRequestedPictures += numberOfImagesOver;
                }               
            }


            int start = m_position - firstHalfRequestedPictures;
            int end = m_position + secondHalfRequestedPictures;

            indexLookup.Clear();

            if (end - start > 0)
            {
                int numImagesShown = 0;

                for (int i = start; i < end; i++)
                {
                    AddPicture(i);
                    indexLookup.Add(numImagesShown, i);
                    numImagesShown++;
                }

                m_picturesLoaded += numImagesShown;
            }
        }

        private void AddPicture(int position)
        {
            Panel highlightPanel = new Panel();
            PictureBox thumbnailBox = new PictureBox();
            Image.GetThumbnailImageAbort thumbnailCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
            thumbnailBox.Image = Image.FromFile(m_pictureFiles[position]).GetThumbnailImage(175, 175, thumbnailCallback, IntPtr.Zero);
            thumbnailBox.Width = 175;
            thumbnailBox.Height = 175;
            thumbnailBox.Location = new Point(12, 8);
            thumbnailBox.MouseClick += new MouseEventHandler(thumbnailBox_Click);
            thumbnailBox.MouseDown += new MouseEventHandler(thumbnailBoxDrag);

            highlightPanel.Controls.Add(thumbnailBox);

            highlightPanel.Width = 200;
            highlightPanel.Height = 200;

            highlightPanel.MouseClick += new MouseEventHandler(highlightPanel_MouseClick);

            //Add right click 'swap with selected' menu
            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add(new MenuItem("Swap with selected picture", SwapClick));
            highlightPanel.ContextMenu = menu;
            thumbnailBox.ContextMenu = menu;

            if (position == m_position)
            {
                highlightPanel.BackColor = Color.LightBlue;
            }

            flowPanel.Controls.Add(highlightPanel);
        }

        private void DeSelect()
        {
            foreach (Control control in flowPanel.Controls)
            {
                Panel highlightPanel = (Panel) control;

                highlightPanel.BackColor = default(Color);             
            }
        }

        private void thumbnailBoxDrag(object sender, MouseEventArgs e)
        {
            //PictureBox picture = (PictureBox)sender;

            //if (DoDragDrop(picture, DragDropEffects.Move) == DragDropEffects.Move)
            //{
                //pictureBox1.Image = null;
            //}
        }

        void thumbnailBox_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DeSelect();

                PictureBox picture = (PictureBox)sender;
                picture.Parent.BackColor = Color.LightBlue;
                m_selection = picture.Parent.TabIndex;

                if (indexLookup.ContainsKey(picture.Parent.TabIndex))
                {
                    m_position = indexLookup[picture.Parent.TabIndex];
                }
            }
        }

        void highlightPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DeSelect();

                Panel panel = (Panel)sender;
                panel.BackColor = Color.LightBlue;

                m_selection = panel.TabIndex;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbImageSelector_ValueChanged(object sender, EventArgs e)
        {
            m_position = tbImageSelector.Value - 1;
            lbImageInformation.Text = String.Format("{0}/{1} : {2}", m_position + 1, m_pictureFiles.Count, m_pictureFiles[m_position]);
            UpdateThumbNail();
        }

        private bool ThumbnailCallback()
        {
            return false;
        }

        private void SwapClick(object sender, EventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;
            Panel parentPanel = null;

            if (menuItem != null)
            {
                ContextMenu parentMenu = menuItem.Parent as ContextMenu;

                if (parentMenu.SourceControl != null)
                {
                    if (parentMenu.SourceControl is PictureBox)
                    {
                        parentPanel = (Panel)((PictureBox)parentMenu.SourceControl).Parent;
                    }
                    else
                    {
                        parentPanel = ((Panel)parentMenu.SourceControl);
                    }

                    int swapIndex = parentPanel.TabIndex;

                    if (indexLookup.ContainsKey(swapIndex))
                    {
                        int realIndex = indexLookup[swapIndex];

                        if (realIndex != m_position)
                        {
                            string tempImage = m_pictureFiles[m_position];

                            m_pictureFiles[m_position] = m_pictureFiles[realIndex];
                            m_pictureFiles[realIndex] = tempImage;

                            //Repaint all images after the swap
                            UpdateThumbNail();
                        }
                    }  
                }
            }      
        }
    }
}
