using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ePOS.DataAccessLayer.BussinessObject
{
    public class StoreSetting
    {
        private string _companyname;
        private string _companyaddress;
        private int _compnayphonenumber;
        private string _companyemail;
        private string _companyWebsite;
        private string _returnpolicy;
        private char _currencysymbol;


        public StoreSetting()
        {
            _companyaddress = string.Empty;
            _companyname = string.Empty;
            _compnayphonenumber = 0;
            _companyemail = string.Empty;
            _companyWebsite = string.Empty;
            _returnpolicy = string.Empty;
         


        }

        public string CompanyName
        {
            get { return _companyname; }
            set { _companyname = value; }
        }

        public string CompanyAddress
        {
            get { return _companyaddress; }
            set { _companyaddress = value; }
        }

     
        public int CompanyPhoneNumber
        {
            get { return _compnayphonenumber; }
            set { _compnayphonenumber = value; }
        }

        public string CompanyEmail
        {
            get { return _companyemail; }
            set { _companyemail = value; }
        }

        public string ComapanyWebsite
        {
            get { return _companyWebsite; }
            set { _companyWebsite = value; }
        }

        public string ReturnPolicy
        {
            get { return _returnpolicy; }
            set { _returnpolicy = value; }
        }

        public char CurrencySymbol
        {
            get { return _currencysymbol; }
            set { _currencysymbol = value; }
        }
        
        
        
        
    }
}
