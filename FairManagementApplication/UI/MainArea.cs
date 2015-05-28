using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FairManagementApplication.UI;

namespace FairManagementApplication
{
    public partial class MainArea : Form
    {
        public MainArea()
        {
            InitializeComponent();
        }

        private void MainArea_Load(object sender, EventArgs e)
        {

        }

        private void zoneTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeEntry zoneTypeEntry = new ZoneTypeEntry();
            zoneTypeEntry.Show();
        }

        private void visitorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorEntry visitorEntry = new VisitorEntry();
            visitorEntry.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zoneSpecificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneSpecificVisitorInformationReport zoneSpecific = new ZoneSpecificVisitorInformationReport();
            zoneSpecific.Show();
        }

        private void zoneWiseVisitorNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeWiseVisitorNumberReport zoneTypeWise = new ZoneTypeWiseVisitorNumberReport();
            zoneTypeWise.Show();
        }
    }
}
