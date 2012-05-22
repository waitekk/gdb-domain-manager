using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gdb_domain_manager
{
    public partial class GeodatabaseSelector : UserControl
    {
        private int selectedGeodatabaseType = 1;
        private string path;
        
        public GeodatabaseSelector()
        {
            InitializeComponent();
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            switch (selectedGeodatabaseType)
            {
                case 1:
                    // file                    
                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        path = fbd.SelectedPath;
                    }
                    else
                    {
                        return;
                    }

                    this.ParentForm.Close();

                    break;
                case 2:
                    // personal
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Multiselect = false;
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        path = ofd.FileName;
                    }
                    else
                    {
                        return;
                    }

                    this.ParentForm.Close();

                    break;
                case 3:
                    // SDE
                    OpenFileDialog ofdSde = new OpenFileDialog();
                    ofdSde.Multiselect = false;
                    if (ofdSde.ShowDialog() == DialogResult.OK)
                    {
                        path = ofdSde.FileName;
                    }
                    else
                    {
                        return;
                    }

                    this.ParentForm.Close();

                    break;
            }
        }

        private void rbFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFile.Checked)
            {
                selectedGeodatabaseType = 1;
            }
        }

        private void rbPersonal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPersonal.Checked)
            {
                selectedGeodatabaseType = 2;
            }
        }

        private void rbSDE_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSDE.Checked)
            {
                selectedGeodatabaseType = 3;
            }
        }

        public string Path
        {
            get { return path; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
