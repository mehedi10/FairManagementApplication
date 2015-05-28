using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FairManagementApplication.Model
{
    public class ZoneType
    {
        private int zoneId;
        private string zoneName;

        public int ZoneId
        {
            get { return zoneId; }
            set { zoneId = value; }
        }

        public string ZoneName
        {
            get { return zoneName; }
            set { zoneName = value; }
        }
    }
}
