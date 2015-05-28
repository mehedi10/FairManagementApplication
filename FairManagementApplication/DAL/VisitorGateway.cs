using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using FairManagementApplication.Model;

namespace FairManagementApplication.DAL
{
    public class VisitorGateway
    {
        private string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public int Insert(Visitor myVisitor)
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "INSERT INTO Visitor_T VALUES('"+myVisitor.Name+"', '"+myVisitor.Email+"', '"+myVisitor.PhoneNum+"')";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            con.Close();

            return rowAffected;
        }

        public int GetVisitorId()
        {
            SqlConnection con = new SqlConnection(cs);

            string query = "SELECT ID FROM visitor_T";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            int id = 0;
            while (rdr.Read())
            {
                Visitor visitor = new Visitor();

                visitor.Id = Convert.ToInt32(rdr["ID"]);
                id = visitor.Id;
            }

            return id;
        }
    }
}
