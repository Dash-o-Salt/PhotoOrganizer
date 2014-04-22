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

namespace PhotoOrganizer
{
    public partial class RenameDialog : Form
    {
        private List<string> m_pictures;
        private int m_seed = -1;

        public RenameDialog()
        {
            InitializeComponent();
        }

        public List<string> PictureList
        {
            set { m_pictures = value; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Get out the UI set values
            string template = tbTemplate.Text;
            m_seed = Convert.ToInt32(numSeed.Value);

            foreach (string fileName in m_pictures)
            {
                //Renames the file based on the given template and seed
                string newFileName = Regex.Replace(template, "#+", new MatchEvaluator(NumberReplacer));

                //Move the file to its new spot
                File.Move(fileName, Path.Combine(Path.GetDirectoryName(fileName), String.Format("{0}{1}", newFileName, Path.GetExtension(fileName))));

                m_seed++;
            }


            //Complete, close this window
            this.Close();
        }

        //If the template has '#####,' this will return '00001,' where '1' is the seed value
        private string NumberReplacer(Match match)
        {
            return m_seed.ToString().PadLeft(match.Value.Length, '0');
        }

        //Closes form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
