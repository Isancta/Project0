using System;
using System.Data.SqlClient;

namespace BibliotequeAPP
{
    class Key 
    {
       public string username {get;set;}
       public string password {get;set;}
        
        
           
        public bool SignIn(string userN,string passW)
          {
           
             SqlConnection connection = new SqlConnection(@"server=SANCTA-MARIE\ISPM_TRAINING;database=BibliothequeAPP;integrated security=true");
           
             SqlCommand cmd_SignIn = new SqlCommand("select count(*) from UserInfo where username=@userN and password=@passW",connection);

             cmd_SignIn.Parameters.AddWithValue("@userN",userN);
             cmd_SignIn.Parameters.AddWithValue("@passW",passW);

             try
               {
                 connection.Open();
                 int record =(int) cmd_SignIn.ExecuteScalar();
                 
                 if (record > 0)
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }
               } 
             
             catch (System.Exception es)
             {
                 
                 throw new Exception(es.Message);
             }
             finally
             {
                 connection.Close();
             }
        }
    }
}
