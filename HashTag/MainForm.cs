using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HashTag.Properties;

namespace HashTag
{
    public partial class MainForm : Form
    {
        private bool isCalculateFileSelected;
        private bool isCompareFileSelected;
        private OpenFileDialog calculateFileDialog;
        private OpenFileDialog compareFileDialog;
        
        public MainForm()
        {
            InitializeComponent();
            calculateFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            compareFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            isCalculateFileSelected = false;
            isCompareFileSelected = false;

            algorithmCombo.SelectedIndex = 0;
        }

        private void algorithmCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(calculateFileDialog.FileName))
            {
                calculatedHashBox.Text = CalculateHash();
            }
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            isCalculateFileSelected = (calculateFileDialog.ShowDialog() == DialogResult.OK);
            calculatedHashBox.Text = CalculateHash();
        }

        private string CalculateHash()
        {
            if (!isCalculateFileSelected) return String.Empty;           
            try
            {
                using (Stream fileStream = calculateFileDialog.OpenFile())
                {
                    HashAlgorithm algo;
                    switch (algorithmCombo.Text)
                    {
                        case "SHA1":
                            algo = SHA1.Create();
                            break;
                        case "SHA256":
                            algo = SHA256.Create();
                            break;
                        case "SHA512":
                            algo = SHA512.Create();
                            break;
                        default:
                            algo = MD5.Create();
                            break;
                    }
                    using (algo)
                    {
                        return BitConverter.ToString(algo.ComputeHash(fileStream)).Replace("-", "");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format(Resources.CouldNotCalculateHash + ex.Message));
                return String.Empty;
            }
        }

        private void CompareHashes()
        {
            string calculatedHash = calculatedHashBox.Text;
            string compareHash = compareHashBox.Text;

            if (!String.IsNullOrEmpty(calculatedHash) && !String.IsNullOrEmpty(compareHash))
            {
                if (String.Equals(calculatedHash, compareHash))
                {
                    calculatedHashBox.BackColor = compareHashBox.BackColor = Color.GreenYellow;
                }
                else
                {
                    calculatedHashBox.BackColor = compareHashBox.BackColor = Color.OrangeRed;
                }
            }
            else
            {
                calculatedHashBox.BackColor = compareHashBox.BackColor = Color.Empty;
            }
        }

        private void compareFileButton_Click(object sender, EventArgs e)
        {
            if (compareFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader fileStream = new StreamReader(compareFileDialog.OpenFile()))
                    {
                        String content = fileStream.ReadToEnd();
                        string[] words = content.Split(' ');
                        {
                            compareHashBox.Text = words[0].ToUpperInvariant();
                            CompareHashes();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Failed to read hash from file. Exception: " + ex.Message));                    
                }
            }
        }

        private void compareHashBox_TextChanged(object sender, EventArgs e)
        {
            CompareHashes();
        }

        private void calculatedHashBox_TextChanged(object sender, EventArgs e)
        {
            CompareHashes();
        }
    }
}
