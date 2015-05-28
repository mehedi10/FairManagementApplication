using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FairManagementApplication.DAL;
using FairManagementApplication.Model;

namespace FairManagementApplication.BLL
{
    public class VisitorManager
    {
        VisitorGateway gatewayVisitor = new VisitorGateway();

        public bool InsertMethods(Visitor myVisitor)
        {
            try
            {
                return gatewayVisitor.Insert(myVisitor) > 0;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int GetVisitorId()
        {
            try
            {
                return gatewayVisitor.GetVisitorId();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
