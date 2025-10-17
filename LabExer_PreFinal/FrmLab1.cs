using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExer_PreFinal
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            {
                
                FrmFileName fileNameForm = new FrmFileName();
                fileNameForm.ShowDialog();

                string getInput = txtInput.Text;              
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string fullPath = System.IO.Path.Combine(docPath, FrmFileName.SetFileName);
                try
                {
                    using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter(fullPath))
                    {
                        outputFile.WriteLine(getInput);
                        MessageBox.Show("Text successfully written to file!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error writing to file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistration reg = new FrmRegistration();
            reg.Show();
            this.Hide();
        }
    }
}
