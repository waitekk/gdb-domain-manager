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
            // get domain list for original workspace
            DomainList domainsA = getDomainList(geodatabasePathA);
            
            // populate dataGridView
            dgA.Rows.Clear();
            foreach (IDomain domain in domainsA)
            {
                int index = dgA.Rows.Add();
                DataGridViewRow row = dgA.Rows[index];
                row.Cells["DomainA"].Value = domain.Name.ToString();
                row.Cells["DescriptionA"].Value = domain.Description.ToString();
            }
        }

        private void btnRefreshDomainListB_Click(object sender, EventArgs e)
        {
            // get domain list for target workspace
            DomainList domainsB = getDomainList(geodatabasePathB);

            // populate dataGridView
            dgB.Rows.Clear();
            foreach (IDomain domain in domainsB)
            {
                int index = dgB.Rows.Add();
                DataGridViewRow row = dgB.Rows[index];
                row.Cells["DomainB"].Value = domain.Name.ToString();
                row.Cells["DescriptionB"].Value = domain.Description.ToString();
            }
        }

        /// <summary>
        /// Returns domain list in DomainList format
        /// </summary>
        /// <param name="workspacePath"></param>
        /// <returns>DomainList domains</returns>
        private DomainList getDomainList(string workspacePath)
        {
            // init domain list
            DomainList domains = new DomainList();

            // open workspace 
            IWorkspace workspace = workspacePath.ToWorkspace();

            // read domain list from workspace A
            IWorkspaceDomains2 workspaceDomains = workspace as IWorkspaceDomains2;

            // add to list
            try
            {
                domains = workspaceDomains.Domains.ToDomainList();
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't read domain info from workspace - probably not ArcGIS GDB?");
                
            }

            return domains;
        }
    }
}