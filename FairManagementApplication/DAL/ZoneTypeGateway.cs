using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using FairManagementApplication.Model;

namespace FairManagementApplication.DAL
{
    public class ZoneTypeGateway
    {
        private string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public int Insert(ZoneType myZoneType)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "INSERT INTO ZoneType_T VALUES('"+myZoneType.ZoneName+"')";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            con.Close();

            return rowAffected;
        }

        public List<ZoneType> GetAllZone()
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "SELECT * FROM ZoneType_T";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            List<ZoneType> zoneTypes = new List<ZoneType>();

            while (rdr.Read())
            {
                ZoneType myZoneType = new ZoneType();

                myZoneType.ZoneId = Convert.ToInt32(rdr["Id"]);
                myZoneType.ZoneName = rdr["ZoneName"].ToString();

                zoneTypes.Add(myZoneType);
            }

            return zoneTypes;
        }
    }
}
