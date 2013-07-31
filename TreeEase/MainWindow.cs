using System;
using System.IO;
using System.Windows.Forms;
using 

namespace TreeEase
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        //On form load 
        private void Form1_Load(object sender, EventArgs e)
        {
            //Setup program elements:
            this.Text = "TreeEase v" + TreeEaseGlobal.__verison;


        }

        /*
         * Exit the program with message prompt
         */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to exit?", "Close TreeEase?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        /*
         *  Clears the text within the file location text box
         */
        private void btnClear_Click(object sender, EventArgs e)
        {
            Text = "";
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            opnBrowseFile.ShowDialog();
        }

        private void opnBrowseFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Path.GetExtension(opnBrowseFile.FileName) == ".csv")
            {
                tbxFileToLoad.Text = opnBrowseFile.FileName;
            } else
            {
                MessageBox.Show("Now a valid CSV file", "Filetype Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }

        
    }
}
