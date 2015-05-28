using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Windows.Forms;
using FairManagementApplication.BLL;
using FairManagementApplication.Model;

namespace FairManagementApplication.UI
{
    public partial class ZoneTypeEntry : Form
    {
        List<ZoneType> myZoneTypes = new List<ZoneType>(); 
        ZoneTypeManager managerZoneType = new ZoneTypeManager();

        public ZoneTypeEntry()
        {
            InitializeComponent();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            ZoneType myZoneType = new ZoneType();

            myZoneType.ZoneName = txtTypeName.Text;

            bool IsSuccess = managerZoneType.InsertMethods(myZoneType);

            if (IsSuccess)
            {
                txtTypeName.Text = "";
                LoadAllZoneIntoListview();
                MessageBox.Show("Saved Successfully");
            }
            else
            {
                MessageBox.Show("Insertion Failed....");
            }
        }

        private void ZoneTypeEntry_Load(object sender, EventArgs e)
        {
            LoadAllZoneIntoListview();
        }

        private void LoadAllZoneIntoListview()
        {
            myZoneTypes = managerZoneType.GetAllZone();
            lstZoneType.Items.Clear();

            foreach (var zoneType in myZoneTypes)
            {
                ListViewItem item = new ListViewItem(zoneType.ZoneName);

                lstZoneType.Items.Add(item);
            }
        }
    }
}
