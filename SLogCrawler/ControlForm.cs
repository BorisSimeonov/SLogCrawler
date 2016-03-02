using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SLogCrawler
{
    public partial class MainForm : Form
    {
        private string filePath = "";
        private string fileName = "";
        private string resultFileName = "";
        private string resultDestination = "";
        private string defaultPathErrorString =
            "Invalid or missing input data.\n" +
            "Check the log file path and save location.";
        private Dictionary<string, List<string>> extractedFileData =
            new Dictionary<string, List<string>>();

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
                /*check the files in the destination folder and
                generate unique file neme for the process result*/
                resultFileName = GenerateUniqueFileName(
                    fileName, resultDestination);
                ProcessFile();
                PrintData();
            }
            else
            {
                tbResultBox.Text = defaultPathErrorString;
            }
        }

        private void PrintData()
        {
            List<string> ipKeyList = extractedFileData.Keys.ToList();
            ipKeyList.Sort((fKey, sKey) =>
            extractedFileData[sKey].Count
            .CompareTo(extractedFileData[fKey].Count));
            //
            string newFile = resultDestination + @"\" + resultFileName;
            using (StreamWriter sr = new StreamWriter(
                newFile))
            {
                int sumChecker = 0;
                tbResultBox.Text += String.Format("Creating file -> {0}", newFile);
                sr.WriteLine("=>{0} unique IP adresses.{1}=>IP/Count List:",
                    ipKeyList.Count,
                    Environment.NewLine);
                foreach (string ip in ipKeyList)
                {
                    sr.WriteLine("\t{0} / {1}", ip, extractedFileData[ip].Count);
                }
                sr.WriteLine();
                sr.WriteLine("=>Full Data View:");

                string ipBuffer = "";
                for (int ipIdx = 0; ipIdx < ipKeyList.Count; ipIdx++)
                {
                    ipBuffer = ipKeyList[ipIdx];
                    sr.WriteLine(ipBuffer);
                    for (int dataIdx = 0; dataIdx < extractedFileData[ipBuffer].Count; dataIdx++)
                    {
                        sr.WriteLine("\t{0}", extractedFileData[ipBuffer][dataIdx]);
                        sumChecker++;
                    }
                }
                tbResultBox.Text += Environment.NewLine + sumChecker;
            }
        }

        private void ProcessFile()
        {
            string lineBuffer = "";
            int counter = 0;
            using (StreamReader sr = new StreamReader(filePath))
            {
                tbResultBox.Text += " - Analizing file data ..." +
                    Environment.NewLine;
                while ((lineBuffer = sr.ReadLine()) != null)
                {
                    counter++;
                    ExtractData(lineBuffer);
                }
                tbResultBox.Text += string.Format(" - {0} lines processed.{1}",
                    counter, Environment.NewLine);
            }
        }

        private void ExtractData(string lineBuffer)
        {
            string defaultMessage = "Missing Data...";
            string ipPattern =
                @"(.*?)\s*([\d]{1,3}\.[\d]{1,3}\.[\d]{1,3}\.[\d]{1,3})\s*(.*)";
            Match matchIp = Regex.Match(lineBuffer, ipPattern);
            var ipCurrentBuffer = matchIp.Groups[2].Value;
            if (String.IsNullOrWhiteSpace(ipCurrentBuffer))
            {
                return;
            }

            //populate dictionary with unique ip/details data
            string detailBuffer = matchIp.Groups[0].Value;
            if (!extractedFileData.ContainsKey(ipCurrentBuffer))
            {
                List<string> blankList = new List<string>();
                extractedFileData.Add(ipCurrentBuffer, blankList);
                if (!String.IsNullOrWhiteSpace(detailBuffer))
                {
                    extractedFileData[ipCurrentBuffer].Add(detailBuffer);
                }
                else
                {
                    extractedFileData[ipCurrentBuffer].Add(defaultMessage);
                }
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(detailBuffer))
                {
                    extractedFileData[ipCurrentBuffer].Add(detailBuffer);
                }
                else
                {
                    extractedFileData[ipCurrentBuffer].Add(defaultMessage);
                }
            }
        }

        private bool checkFilePaths()
        {
            if (!String.IsNullOrWhiteSpace(filePath) &&
                !String.IsNullOrWhiteSpace(resultDestination))
            {
                tbResultBox.Text =
                    " - Setting file and destination paths..." +
                    Environment.NewLine;
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string GenerateUniqueFileName(string sourceFileName,
            string destinationPath)
        {
            int counter = 0;
            string buffer = ""; 
            while (true)
            {
                buffer = string.Format("({0}-done){1}",
                    counter, sourceFileName);
                counter++;
                if (!File.Exists(destinationPath + "\\" + buffer))
                {
                    return buffer;
                }
            }
        }
    }
}
