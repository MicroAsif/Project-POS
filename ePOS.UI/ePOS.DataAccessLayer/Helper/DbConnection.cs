using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ePOS.DataAccessLayer.Helper
{
    
    public class DbConnection
    {
        #region Class Level Variable
        string connectionstring = string.Empty;
        SqlConnection conn = null;
        public SqlTransaction sqlTrans;
        #endregion

        

        public DbConnection()
        {
            try
            {
                connectionstring ="Data Source=Microasif\\Sqlexpress;Initial Catalog=MyPos;Integrated Security=True;User Id=sa;Password=as";
            }
            catch (Exception)
            {
                MessageBox.Show("Can't connect to Database! ");  
            }
        }

        public SqlConnection Getconnection()
        {
            conn = new SqlConnection(connectionstring);
            conn.Open();
            return conn;
        }

        public void Closeconn()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

        public SqlConnection OpenTransaction()
        {
            if (conn != null)
            {
                sqlTrans = conn.BeginTransaction();

            }
            return conn;
        }

        public void CommitTransaction()
        {
            if (sqlTrans.Connection != null)
            {
                sqlTrans.Commit();
            }
        }

        public string Rollback()
        {
            string errorMessages = "";

            try
            {
                sqlTrans.Rollback();
            }
            catch (SqlException ex)
            {
                if (sqlTrans.Connection != null)
                {
                    errorMessages = GetErrorMessage(ex);
                }
            }
            return errorMessages;
        }

        public string GetErrorMessage(SqlException e)
        {
            string errorMessages = "";

            for (int i = 0; i < e.Errors.Count; i++)
            {
                errorMessages += "Index #" + i + "\n" +
                    "Message: " + e.Errors[i].Message + "\n" +
                    "LineNumber: " + e.Errors[i].LineNumber + "\n" +
                    "Source: " + e.Errors[i].Source + "\n" +
                    "Procedure: " + e.Errors[i].Procedure + "\n";
            }

            return errorMessages;
        }
    }
}
