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
    public partial class frmLab1 : Form
    {
        public frmLab1()
        {
            InitializeComponent();
        }

        private void frmLab1_Load(object sender, EventArgs e) { }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            FrmFileName frmFileName = new FrmFileName();    
            frmFileName.ShowDialog();
            

            string getInput = txtInput.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }
        }
    }
}
