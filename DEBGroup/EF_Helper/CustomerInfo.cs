using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEBGroup.EF
{
    public partial class CustomerInfo
    {
        public CustomerInfo(string companyname, string contactperson, int phonenumber, string email)
        {
            this.CompanyName = companyname;
            this.ContactPerson = contactperson;
            this.PhoneNumber = phonenumber;
            this.Email = email;
        }
    }
}