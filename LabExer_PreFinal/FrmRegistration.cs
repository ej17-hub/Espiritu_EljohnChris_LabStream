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
    public partial class FrmRegistration : Form
    {
        public static string SetFileRegFormName;
        public FrmRegistration()
        {
            InitializeComponent();
        }
        private void btnReg_Click(object sender, EventArgs e)
        {

            SetFileRegFormName = textBoxStudentNum.Text + ".txt";


            string getStudent = textBoxStudentNum.Text;
            string getLastName = textBoxLastName.Text;
            string getFirstName = textBoxFirstName.Text;
            string getMiddleInitial = textBoxMiddleInitial.Text;
            string getProgram = textBoxProgram.Text;
            string getGender = comboBoxGender.Text;
            string getAge = textBoxAge.Text;
            string getBday = dateTimePickerBday.Text;
            string getContactNum = textBoxContact.Text;
  
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fullPath = System.IO.Path.Combine(docPath, SetFileRegFormName);

            try
            {
                using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter(fullPath))
                {
                    outputFile.WriteLine("Student No.: " + getStudent);
                    outputFile.WriteLine("Full Name: " + getLastName + ", " + getFirstName + ", " + getMiddleInitial + ".");
                    outputFile.WriteLine("Program: " + getProgram);
                    outputFile.WriteLine("Gender: " + getGender);
                    outputFile.WriteLine("Age: " + getAge);
                    outputFile.WriteLine("Birthday: " + getBday);
                    outputFile.WriteLine("Contact No.: " + getContactNum);
                }
                MessageBox.Show("Student information successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
