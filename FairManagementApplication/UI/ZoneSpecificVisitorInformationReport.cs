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
using Excel = Microsoft.Office.Interop.Excel;


namespace FairManagementApplication.UI
{
    public partial class ZoneSpecificVisitorInformationReport : Form
    {
        List<ZoneType> zoneTypes = new List<ZoneType>();
        ZoneTypeManager managerZoneType = new ZoneTypeManager();
        List<VisitorAndZoneInformation> visitorAndZoneInformations = new List<VisitorAndZoneInformation>(); 
        VisitorAndZoneInformationManager managervVisitorAndZoneInformation = new VisitorAndZoneInformationManager();

        public ZoneSpecificVisitorInformationReport()
        {
            InitializeComponent();
        }

        private void ZoneSpecificVisitorInformationReport_Load(object sender, EventArgs e)
        {
            LoadAllZoneIntoComboBox();
        }

        private void LoadAllZoneIntoComboBox()
        {
            zoneTypes = managerZoneType.GetAllZone();

            cmbAllZone.DisplayMember = "ZoneName";
            cmbAllZone.ValueMember = "ZoneId";
            cmbAllZone.DataSource = zoneTypes;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int selectedZodeId = Convert.ToInt32(cmbAllZone.SelectedValue);

            visitorAndZoneInformations = managervVisitorAndZoneInformation.GetAllVisitorByZone(selectedZodeId);
            lstVisitorByZoneType.Items.Clear();

            foreach (var visitorAndZoneInformation in visitorAndZoneInformations)
            {
                ListViewItem item = new ListViewItem(visitorAndZoneInformation.VisitorName);
                item.SubItems.Add(visitorAndZoneInformation.VisitorEmail);
                item.SubItems.Add(visitorAndZoneInformation.VisitorContactNumber);

                lstVisitorByZoneType.Items.Add(item);
            }

            txtTotalVisitorByZone.Text = GetTotalVisitor();
        }

        public string GetTotalVisitor()
        {
            int count = 0;

            foreach (var item in lstVisitorByZoneType.Items)
            {
                count++;
            }

            return count.ToString();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            app.Visible = true;
            Excel.Workbook wb = app.Workbooks.Add(1);
            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];
            Excel.Range chartRange;
            
            int lstItem = 1;
            int lstSubItem = 3;
            foreach (ListViewItem item in lstVisitorByZoneType.Items)
            {
                lstItem = 1;
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    ws.Cells[lstSubItem, lstItem] = subItem.Text;
                    lstItem++;
                }
                lstSubItem++;

                ws.get_Range("A1", "C1").Merge(false);

                chartRange = ws.get_Range("A1", "C1");
                chartRange.FormulaR1C1 = cmbAllZone.Text;
                chartRange.Font.Bold = true;

                ws.Cells[2, 1] = "Name";
                ws.Cells[2, 2] = "Email";
                ws.Cells[2, 3] = "Contact Number";
                ws.Cells[lstSubItem, 2] = "Total Visitor";
                ws.Cells[lstSubItem, 3] = txtTotalVisitorByZone.Text;
            }

        }
    }
}
