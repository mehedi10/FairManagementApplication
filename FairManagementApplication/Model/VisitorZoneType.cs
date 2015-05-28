using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FairManagementApplication.Model
{
    public class VisitorZoneType
    {
        private int visitorZoneTypeId;
        private int visitorId;
        private int zoneTypeId;

        public int ZoneTypeId
        {
            get { return zoneTypeId; }
            set { zoneTypeId = value; }
        }

        public int VisitorZoneTypeId
        {
            get { return visitorZoneTypeId; }
            set { visitorZoneTypeId = value; }
        }

        public int VisitorId
        {
            get { return visitorId; }
            set { visitorId = value; }
        }
    }
}
