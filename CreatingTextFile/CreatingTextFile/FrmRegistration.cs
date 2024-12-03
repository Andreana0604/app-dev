using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e){}

        private void FrmRegistration_Load(object sender, EventArgs e) 
        {
            string[] ListOfProgram = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS in Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };

            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }

            cbGender.Items.Add("Female");
            cbGender.Items.Add("Male");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string getStuNum = txtStudentNo.Text;
            string getLName = txtLName.Text;
            string getFName = txtFName.Text;
            string getMidInitial = txtMI.Text;
            string getAge = txtAge.Text;    
            string getGender = cbGender.Text;
            string getContactNo = txtContactNo.Text;
            string getBirthday = dtpBirthday.Text;
            string getPrograms = cbPrograms.Text;

            string newDocName = FrmFileName.SetFileName = txtStudentNo.Text + ".txt";

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine("Student No: " + getStuNum);
                outputFile.WriteLine("Last Name: " + getLName);
                outputFile.WriteLine("First Name: " + getFName);
                outputFile.WriteLine("Middle Initial: " + getMidInitial);
                outputFile.WriteLine("Age: " + getAge);
                outputFile.WriteLine("Gender: " + getGender);
                outputFile.WriteLine("Contact No: " + getContactNo);
                outputFile.WriteLine("Birthday: " + getBirthday);
                outputFile.WriteLine("Program: " + getPrograms);
                Console.WriteLine(getStuNum, getLName, getFName, getMidInitial, getAge,
                                  getGender, getContactNo, getBirthday, getPrograms);
            }
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord studentRecordForm = new FrmStudentRecord();
            studentRecordForm.Show();
            this.Hide();
        }
    }
}