using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FairManagementApplication.BLL;
using FairManagementApplication.Model;

namespace FairManagementApplication.UI
{
    public partial class ZoneTypeWiseVisitorNumberReport : Form
    {
        List<ZoneType> zoneTypes = new List<ZoneType>();
        ZoneTypeManager managerZoneType = new ZoneTypeManager();
        VisitorAndZoneInformationManager managervVisitorAndZoneInformation = new VisitorAndZoneInformationManager();

        public ZoneTypeWiseVisitorNumberReport()
        {
            InitializeComponent();
        }

        private void ZoneTypeWiseVisitorNumberReport_Load(object sender, EventArgs e)
        {
            LoadAllZoneIntoComboBox();
            txtTotalVisitor.Text = GetTotalVisitor();
        }

        private string GetTotalVisitor()
        {
            int totalVisitor = 0;

            foreach (ListViewItem itemValue in lstTotalVisitorByZone.Items)
            {
                totalVisitor += int.Parse(itemValue.SubItems[1].Text);
            }

            return totalVisitor.ToString();
        }

        private void LoadAllZoneIntoComboBox()
        {
            zoneTypes = managerZoneType.GetAllZone();

            foreach (var zoneType in zoneTypes)
            {
                ListViewItem item = new ListViewItem(zoneType.ZoneName);
                int TotalNumber = managervVisitorAndZoneInformation.TotalVisitorById(zoneType.ZoneId);
                item.SubItems.Add(TotalNumber.ToString());

                lstTotalVisitorByZone.Items.Add(item);
            }
        }
    }
}
