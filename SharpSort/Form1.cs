using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace SharpSort
{
    public partial class Form1 : Form
    {
        Manager sessionMan;
        public Form1()
        {
            sessionMan = new Manager();
            InitializeComponent();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fIleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fldDlg = new FolderBrowserDialog();
            DialogResult chosen_dir = fldDlg.ShowDialog();
            if (chosen_dir == DialogResult.OK)
            {
                sessionMan.setDir(fldDlg.SelectedPath);
                //Environment.SpecialFolder root = folderDlg.RootFolder;
            }
            Debug.Print("Form dir set: " + fldDlg.SelectedPath);
            Debug.Print("Form after chdir: " + Directory.GetCurrentDirectory());
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult quitConf = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo);
            if (quitConf == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
