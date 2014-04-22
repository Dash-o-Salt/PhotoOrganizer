using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhotoOrganizer
{
    public partial class StripExifDataDialog : Form
    {
        private string m_folderPath = null;

        public StripExifDataDialog()
        {
            InitializeComponent();
        }

        public string FolderPath
        {
            get { return m_folderPath; }
            set { m_folderPath = value; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            btnCancel.Enabled = false;
            lblStatus.Visible = true;

            //Get all files in the current folder
            string[] pictureFileNames = Directory.GetFiles(m_folderPath);

            Task.Factory.StartNew(() =>
            {
                foreach (string file in pictureFileNames)
                {
                    lblStatusPath.SetPropertyThreadSafe(() => lblStatusPath.Visible, true);
                    lblStatusPath.SetPropertyThreadSafe(() => lblStatusPath.Text, file);

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (FileStream fs = new FileStream(file, FileMode.Open))
                        {
                            ExifStripper.PatchAwayExif(fs, memoryStream);
                        }

                        Image imgPhoto = Image.FromStream(memoryStream);
                        File.Delete(file);

                        imgPhoto.Save(file);
                    }
                }

                //Complete, close the main window
                this.Invoke((MethodInvoker)delegate
                {
                    this.Close();
                });
            });
        }

        //Closes form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
