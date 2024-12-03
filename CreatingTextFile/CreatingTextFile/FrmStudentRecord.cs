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
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void FrmStudentRecord_Load(object sender, EventArgs e)
        {}

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegistration registrationForm = new FrmRegistration();
            registrationForm.Show();
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string filePath = Path.Combine(docPath, FrmFileName.SetFileName);

            if (File.Exists(filePath))
            {
                lvViewRecord.Items.Clear();
              
                string[] fileContent = File.ReadAllLines(filePath);
                foreach (string line in fileContent)
                {
                    lvViewRecord.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("The specified file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!", "Success", MessageBoxButtons.OK);
            lvViewRecord.Items.Clear();
        }
    }
}
