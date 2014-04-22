using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows.Media;

namespace PhotoOrganizer
{
    public partial class ExifDataDisplay : Form
    {
        public ExifDataDisplay(string currentImagePath)
        {
            InitializeComponent();
            LoadExifData(currentImagePath);
        }

        private void LoadExifData(string currentImagePath)
        {
            DataTable data = new DataTable();
            data.Columns.Add(new DataColumn("Key", typeof(string)));
            data.Columns.Add(new DataColumn("Value", typeof(string)));

            using (FileStream fs = new FileStream(currentImagePath, FileMode.Open))
            {
                BitmapFrame bitmapFrame = BitmapFrame.Create(fs,
                    BitmapCreateOptions.DelayCreation,
                    BitmapCacheOption.None);

                ListViewItem width = new ListViewItem("Width");
                width.SubItems.Add(bitmapFrame.PixelWidth.ToString());
                ListViewItem height = new ListViewItem("Height");
                height.SubItems.Add(bitmapFrame.PixelHeight.ToString());

                DataRow widthRow = data.NewRow();
                widthRow["Key"] = "Width";
                widthRow["Value"] = bitmapFrame.PixelWidth.ToString();

                DataRow heightRow = data.NewRow();
                heightRow["Key"] = "Height";
                heightRow["Value"] = bitmapFrame.PixelHeight.ToString();

                data.Rows.Add(widthRow);
                data.Rows.Add(heightRow);

                BitmapMetadata metadata = (BitmapMetadata)bitmapFrame.Metadata;

                ParseMetadata(metadata, data);
            }

            dgImageMetadata.DataSource = data;
            dgImageMetadata.Sort(dgImageMetadata.Columns["Key"], ListSortDirection.Ascending);

            foreach (DataGridViewColumn column in dgImageMetadata.Columns)
            {
                column.Width = 200;
            }
        }

        private void ParseMetadata(BitmapMetadata metadata, DataTable dataTable)
        {
            foreach (string dataFormatString in metadata)
            {
                object data = metadata.GetQuery(dataFormatString);

                if (data is BitmapMetadata)
                {
                    ParseMetadata((BitmapMetadata)data, dataTable);
                }
                else
                {
                    DataRow row = dataTable.NewRow();
                    row["Key"] = EnumHelper.GetEnumValueFromDescription<SharedConstants.EXIFData>(dataFormatString).ToString();

                    ListViewItem lvi = new ListViewItem(EnumHelper.GetEnumValueFromDescription<SharedConstants.EXIFData>(dataFormatString).ToString());

                    if (lvi.Text.Contains("Unknown"))
                    {
                        lvi.Text = String.Format("{0}: {1}", lvi.Text, dataFormatString);
                    }

                    if (data is BitmapMetadataBlob)
                    {
                        lvi.SubItems.Add(Encoding.Default.GetString(((BitmapMetadataBlob)data).GetBlobValue()));

                        row["Value"] = Encoding.Default.GetString(((BitmapMetadataBlob)data).GetBlobValue());
                    }
                    else
                    {
                        lvi.SubItems.Add(Convert.ToString(data));

                        row["Value"] = Convert.ToString(data);
                    }

                    dataTable.Rows.Add(row);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
