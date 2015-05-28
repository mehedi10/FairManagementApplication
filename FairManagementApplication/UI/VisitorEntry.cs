using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using FairManagementApplication.BLL;
using FairManagementApplication.Model;

namespace FairManagementApplication.UI
{
    public partial class VisitorEntry : Form
    {
        List<Visitor> visitors = new List<Visitor>();
 
        public VisitorEntry()
        {
            InitializeComponent();
        }

        private List<ZoneType> myZoneTypes = new List<ZoneType>();
        private ZoneTypeManager managerZoneType = new ZoneTypeManager();

        VisitorManager managerVisitor = new VisitorManager();
        VisitorZoneTypeManager managerVisitorZoneType = new VisitorZoneTypeManager();

        private void VisitorEntry_Load(object sender, EventArgs e)
        {
            PopulateZoneTypeIntoGroupBox();
        }

        private void PopulateZoneTypeIntoGroupBox()
        {
            myZoneTypes = managerZoneType.GetAllZone();
            chkLstZoneTypeByVisitor.Items.Clear();

            chkLstZoneTypeByVisitor.DisplayMember = "ZoneName";
            chkLstZoneTypeByVisitor.ValueMember = "ZoneId";

            foreach (var zoneType in myZoneTypes)
            {
                chkLstZoneTypeByVisitor.Items.Add(zoneType, CheckState.Checked);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Visitor myVisitor = new Visitor();
            VisitorZoneType myVisitorZoneType = new VisitorZoneType();

            var zoneTypId = ZoneTId();

            myVisitor.Name = txtName.Text;
            myVisitor.Email = txtEmail.Text;
            myVisitor.PhoneNum = txtContactNumber.Text;

            bool IsSuccess = managerVisitor.InsertMethods(myVisitor);

            if (IsSuccess)
            {
                ClearTextBox();
                insertVisitorIdAndZoneTypeId(zoneTypId, myVisitorZoneType);
                PopulateZoneTypeIntoGroupBox();
                MessageBox.Show("Saved Successfully");
            }
            else
            {
                MessageBox.Show("Insertion Failed....");
            }
        }

        private void insertVisitorIdAndZoneTypeId(List<int> zoneTypId, VisitorZoneType myVisitorZoneType)
        {
            int visitorId = managerVisitor.GetVisitorId();

            foreach (int id in zoneTypId)
            {
                myVisitorZoneType.VisitorId = visitorId;
                myVisitorZoneType.ZoneTypeId = id;

                managerVisitorZoneType.InsertMethods(myVisitorZoneType);
            }
        }

        private List<int> ZoneTId()
        {
            List<int> zoneID = new List<int>();
            int zId = 0;

            for (int i = 0; i < chkLstZoneTypeByVisitor.CheckedItems.Count; i++)
            {
                zId = ((ZoneType) chkLstZoneTypeByVisitor.CheckedItems[i]).ZoneId;
                zoneID.Add(zId);
            }
            return zoneID;
        }

        private void ClearTextBox()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtContactNumber.Text = "";
        }
    }
}
