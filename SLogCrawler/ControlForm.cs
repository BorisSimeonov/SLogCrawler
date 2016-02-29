using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLogCrawler
{
    public partial class MainForm : Form
    {
        private string filePath = "";
        private string fileName = "";
        private string resultDestination = "";
        private string defaultPathErrorString =
            "Invalid or missing input data.\n" +
            "Check the log file path and save location.";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TXT|*.txt;*.doc;*.docx;*.rtf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                fileName = ofd.SafeFileName;
                tbFilePath.Text = filePath;
            }
            else
            {
                filePath = "";
                tbFilePath.Text = "";
            }
        }

        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                resultDestination = fbd.SelectedPath;
                tbResultDestination.Text = resultDestination;
            }
            else
            {
                resultDestination = "";
                tbResultDestination.Text = "";
            }
        }

        private void btnStartLogCrawl_Click(object sender, EventArgs e)
        {
            if (checkFilePaths())
            {

            }
            else
            {
                tbResultBox.Text = defaultPathErrorString;
            }
        }

        private bool checkFilePaths()
        {
            if (!String.IsNullOrWhiteSpace(filePath) &&
                !String.IsNullOrWhiteSpace(resultDestination))
            {
                tbResultBox.Text =
                    " - Setting file and destination paths...";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
