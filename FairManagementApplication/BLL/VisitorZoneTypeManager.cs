using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FairManagementApplication.DAL;

namespace FairManagementApplication.BLL
{
    public class VisitorZoneTypeManager
    {
        VisitorZoneTypeGateway gatewayvVisitorZoneType = new VisitorZoneTypeGateway();

        public void InsertMethods(Model.VisitorZoneType myVisitorZoneType)
        {
            try
            {
                gatewayvVisitorZoneType.Insert(myVisitorZoneType);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
