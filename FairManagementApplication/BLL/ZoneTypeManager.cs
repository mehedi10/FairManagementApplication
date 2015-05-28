using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FairManagementApplication.DAL;
using FairManagementApplication.Model;

namespace FairManagementApplication.BLL
{
    public class ZoneTypeManager
    {
        ZoneTypeGateway gatewayZoneType = new ZoneTypeGateway();

        public bool InsertMethods(ZoneType myZoneType)
        {
            try
            {
                return gatewayZoneType.Insert(myZoneType) > 0;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<ZoneType> GetAllZone()
        {
            try
            {
                return gatewayZoneType.GetAllZone();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
