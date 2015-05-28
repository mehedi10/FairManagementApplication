using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using FairManagementApplication.Model;

namespace FairManagementApplication.DAL
{
    public class VisitorZoneTypeGateway
    {
        private string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public void Insert(VisitorZoneType myVisitorZoneType)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "INSERT INTO VisitorZoneType_T VALUES('" + myVisitorZoneType.VisitorId + "', '" + myVisitorZoneType.ZoneTypeId + "')";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
