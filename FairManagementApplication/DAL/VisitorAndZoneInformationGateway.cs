using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using FairManagementApplication.Model;

namespace FairManagementApplication.DAL
{
    public class VisitorAndZoneInformationGateway
    {
        private string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public List<VisitorAndZoneInformation> GetAllVisitorByZone(int selectedZodeId)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "SELECT * FROM VisitorAndZoneInfo WHERE ZoneTypeId = '"+selectedZodeId+"'";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            List<VisitorAndZoneInformation> myVisitorAndZoneInformations = new List<VisitorAndZoneInformation>();

            while (rdr.Read())
            {
                VisitorAndZoneInformation visitorAndZoneInformation = new VisitorAndZoneInformation();

                visitorAndZoneInformation.VisitorId = Convert.ToInt32(rdr["VisitorId"]);
                visitorAndZoneInformation.VisitorName = rdr["Name"].ToString();
                visitorAndZoneInformation.VisitorEmail = rdr["Email"].ToString();
                visitorAndZoneInformation.VisitorContactNumber = rdr["ContactNumber"].ToString();
                visitorAndZoneInformation.ZoneTypeId = Convert.ToInt32(rdr["ZoneTypeId"]);
                visitorAndZoneInformation.ZoneTypeName = rdr["ZoneName"].ToString();

                myVisitorAndZoneInformations.Add(visitorAndZoneInformation);
            }

            return myVisitorAndZoneInformations;
        }

        public int TotalVisitorById(int zoneId)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "SELECT * FROM VisitorAndZoneInfo where ZoneTypeId = '" + zoneId + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            int count = 0;

            while (rdr.Read())
            {
                count++;
            }

            return count;
        }
    }
}
