using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FairManagementApplication.Model
{
    public class VisitorAndZoneInformation
    {
        private int visitorId;
        private string visitorName;
        private string visitorEmail;
        private string visitorContactNumber;
        private int zoneTypeId;
        private string zoneTypeName;

        public string VisitorName
        {
            get { return visitorName; }
            set { visitorName = value; }
        }

        public string VisitorEmail
        {
            get { return visitorEmail; }
            set { visitorEmail = value; }
        }

        public string VisitorContactNumber
        {
            get { return visitorContactNumber; }
            set { visitorContactNumber = value; }
        }

        public int ZoneTypeId
        {
            get { return zoneTypeId; }
            set { zoneTypeId = value; }
        }

        public string ZoneTypeName
        {
            get { return zoneTypeName; }
            set { zoneTypeName = value; }
        }

        public int VisitorId
        {
            get { return visitorId; }
            set { visitorId = value; }
        }
    }
}
