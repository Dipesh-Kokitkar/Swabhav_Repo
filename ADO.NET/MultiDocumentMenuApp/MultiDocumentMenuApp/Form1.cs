using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiDocumentMenuApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("File menu is clicked");
            ChildForm child = new ChildForm();
            child.MdiParent = this;
            child.Text = child.Text + this.MdiChildren.Length;
            child.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeAllChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form form in MdiChildren) {
                form.Close();
            }
        }
    }
}
