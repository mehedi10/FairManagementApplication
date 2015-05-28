using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FairManagementApplication.DAL;

namespace FairManagementApplication.BLL
{
    public class VisitorAndZoneInformationManager
    {
        VisitorAndZoneInformationGateway gatewayVisitorAndZoneInformation = new VisitorAndZoneInformationGateway();

        public List<Model.VisitorAndZoneInformation> GetAllVisitorByZone(int selectedZodeId)
        {
            try
            {
                return gatewayVisitorAndZoneInformation.GetAllVisitorByZone(selectedZodeId);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int TotalVisitorById(int zoneId)
        {
            try
            {
                return gatewayVisitorAndZoneInformation.TotalVisitorById(zoneId);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
