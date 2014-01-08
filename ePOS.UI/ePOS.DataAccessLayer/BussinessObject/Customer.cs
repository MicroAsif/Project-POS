using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ePOS.DataAccessLayer.BussinessObject
{
   public class Customer
    {
       private int _CustomerCode;
       private string _CustomerName;
       private string _CustomerAddress;
       private string _CustomerEmail;
       private string _CustomerPhoneNumber;
       private string _CustomerWeb;
       private string _CustomerAccountNumber;
       private bool _CustomerTaxable;
       private string _CustomerRemark;
       private string _CustomerCity;
       private int _CustomerZip;
       

       public Customer()
       {
           _CustomerCode = 0; 
           _CustomerName = string.Empty;
           _CustomerAddress = string.Empty;
           _CustomerEmail = string.Empty;
           _CustomerPhoneNumber = string.Empty;
           _CustomerWeb = string.Empty;
           _CustomerAccountNumber = string.Empty;
           _CustomerTaxable = false;
           _CustomerZip = 0;
           _CustomerCity = string.Empty;
           _CustomerRemark = string.Empty;

       }

      
        public int CustomerCode
        {
            get { return _CustomerCode; }
            set { _CustomerCode = value; }
        }

        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        public string CustomerAddress
        {
            get { return _CustomerAddress; }
            set { _CustomerAddress = value; }
        }

        public string CustomerEmail
        {
            get { return _CustomerEmail; }
            set { _CustomerEmail = value; }
        }

       
        public string CustomerPhoneNumber
        {
            get { return _CustomerPhoneNumber; }
            set { _CustomerPhoneNumber = value; }
        }

        public string CustomerWeb 
        {
            get { return _CustomerWeb; }
            set { _CustomerWeb = value; }
        }

        public string AccountNumber
        {
            get { return _CustomerAccountNumber; }
            set { _CustomerAccountNumber = value; }
        }

        public bool CustomerTaxable
        {
            get { return _CustomerTaxable; }
            set { _CustomerTaxable = value; }
        }

        public string CustomerRemark
        {
            get { return _CustomerRemark; }
            set { _CustomerRemark = value; }
        }


        public string CustomerCity
        {
            get { return _CustomerCity; }
            set { _CustomerCity = value; }
        }


        public int CustomerZip
        {
            get { return _CustomerZip; }
            set { _CustomerZip = value; }
        }
        
        
        
        

    }


}
