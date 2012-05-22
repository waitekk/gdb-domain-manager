using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gdb_domain_manager
{
    using ESRI.ArcGIS.esriSystem;
    using ESRI.ArcGIS.Geodatabase;
    using DomainList = System.Collections.Generic.List<ESRI.ArcGIS.Geodatabase.IDomain>;

    public partial class MainForm : Form
    {
        private string geodatabasePathA;
        private string geodatabasePathB;

        public MainForm()
        {
            InitializeComponent();
        }

        #region menu
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show();
        } 
        #endregion

        private void btnChangeGDB_A_Click(object sender, EventArgs e)
        {
            // open form
            GeodatabaseSelectorForm frmGDB_A = new GeodatabaseSelectorForm();
            // wait for closing
            frmGDB_A.ShowDialog();

            geodatabasePathA = frmGDB_A.geodatabaseSelector1.Path;
            gdbA.Text = geodatabasePathA;
        }

        private void btnChangeGDB_B_Click(object sender, EventArgs e)
        {
            // open form
            GeodatabaseSelectorForm frmGDB_B = new GeodatabaseSelectorForm();
            // wait for closing
            frmGDB_B.ShowDialog();

            geodatabasePathB = frmGDB_B.geodatabaseSelector1.Path;
            gdbB.Text = geodatabasePathB;
        }

        private void btnRefreshDomainInfoA_Click(object sender, EventArgs e)
        {
            DomainList domains = new DomainList();

            IWorkspace originalWorkspace = geodatabasePathA.ToWorkspace();
            IWorkspace targetWorkspace = geodatabasePathB.ToWorkspace();

            IWorkspaceDomains2 originalWorkspaceDomains = originalWorkspace as IWorkspaceDomains2;
            IWorkspaceDomains2 targetWorkspaceDomains = targetWorkspace as IWorkspaceDomains2;

            domains = originalWorkspaceDomains.Domains.ToDomainList();

            dgA.Rows.Clear();
            
            foreach (IDomain domain in domains)
            {
                int index = dgA.Rows.Add();
                DataGridViewRow row = dgA.Rows[index];
                row.Cells["DomainA"].Value = domain.Name.ToString();
                row.Cells["DescriptionA"].Value = domain.Description.ToString();
            }
        }

        private void btnRefreshDomainListB_Click(object sender, EventArgs e)
        {

        }
    }
}