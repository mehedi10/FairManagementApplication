using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FairManagementApplication.Model
{
    public class Visitor
    {
        private int ID;
        private string name;
        private string email;
        private string phoneNum;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }
    }
}
