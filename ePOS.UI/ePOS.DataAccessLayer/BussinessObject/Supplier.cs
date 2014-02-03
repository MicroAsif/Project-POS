using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ePOS.DataAccessLayer.BussinessObject
{
   public class Supplier
    {

       private string _CompanyName;
       private string _SupplierFirstName;
       private string _SupplierLastName;
       private string _SupplierEmail;
       private string _SupplierPhoneNumber;
       private string _SupplierAddress;
       private string _SupplierCity;
       private int _SupplierZip;
       private string _SupplierAccountNumber;
       private string _SupplierRemark;

       public Supplier()
       {
           _CompanyName = string.Empty;
           _SupplierFirstName = string.Empty;
           _SupplierLastName = string.Empty;
           _SupplierEmail = string.Empty;
           _SupplierPhoneNumber = string.Empty;
           _SupplierAddress = string.Empty;
           _SupplierCity = string.Empty;
           _SupplierZip = 0;
           _SupplierAccountNumber = string.Empty;
           _SupplierRemark = string.Empty;
       }


       public string CompanyName
       {
           get { return _CompanyName; }
           set { _CompanyName = value; }
       }

       public string SupplierFirstname
       {
           get { return _SupplierFirstName; }
           set { _SupplierFirstName = value; }
       }

       public string SupplierLastName
       {
           get { return _SupplierLastName; }
           set { _SupplierLastName = value; }
       }


       public string SupplierEmail
       {
           get { return _SupplierEmail; }
           set { _SupplierEmail = value; }
       }  

       public string SupplierPhoneNumber
       {
           get { return _SupplierPhoneNumber; }
           set { _SupplierPhoneNumber = value; }
       }

       public string Supplieraddress
       {
           get { return _SupplierAddress; }
           set { _SupplierAddress = value; }
       }

      
       public string SupplierCity
       {
           get { return _SupplierCity; }
           set { _SupplierCity = value; }
       }
       
       public int Supplierip
       {
           get { return _SupplierZip; }
           set { _SupplierZip = value; }
       }

      
       public string SupplierAccountNumber
       {
           get { return _SupplierAccountNumber; }
           set { _SupplierAccountNumber = value; }
       }

      
       public string SupplierRemark
       {
           get { return _SupplierRemark; }
           set { _SupplierRemark = value; }
       }

      

        

    }
}
