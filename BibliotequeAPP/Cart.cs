using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace BibliotequeAPP 
{
    class Cart:BookInfo
    {
        #region Variables

        public int quantity  {get;set;}
        public int numberOfDay {get;set;}
        public double purchase{get;set;}
        public double payment {get;set;}
        
        #endregion

        public Cart()
        {
           numberOfDay = 14;
           purchase = 0;
           payment = 0;
        }
       
        SqlConnection connection = new SqlConnection(@"server=SANCTA-MARIE\ISPM_TRAINING;database=BibliothequeAPP;integrated security=true"); 

        #region ADD NEW BOOK IN CART

         public string AddNewBook(Cart newBook)
         {
            SqlCommand cmd_addBook = new SqlCommand("insert into Cart values(@bookCode,@bookTitle,@bookSection,@quantity,@bookIsAvailable,@unitPrice)" ,connection);
            cmd_addBook.Parameters.AddWithValue("@bookCode", newBook.bookCode);
            cmd_addBook.Parameters.AddWithValue("@bookTitle", newBook.bookTitle);
            cmd_addBook.Parameters.AddWithValue("@bookSection", newBook.bookSection);
            cmd_addBook.Parameters.AddWithValue("@quantity", newBook.quantity);
            cmd_addBook.Parameters.AddWithValue("@bookIsAvailable", newBook.bookIsAvailable);
            cmd_addBook.Parameters.AddWithValue("@unitPrice", newBook.unitPrice);
            

            try
            {
                connection.Open();
                cmd_addBook.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
               connection.Close();

            }
            return "Book Added Successfully";

         } 
        
        #endregion

        #region EDIT BOOK IN CART 

         public string EditBook(Cart changeBook)
         {
            
            string Sql_query= "update Cart set bookCode = @changeCode, bookTitle = @changeTitle , bookSection = @changeSection, quantity=@changeQuantity,bookIsAvailable=@changeIsAvailable,unitPrice=@changeUnitPrice where bookTitle = @changeBook";
            SqlCommand cmd_update = new SqlCommand( Sql_query,connection);
            cmd_update.Parameters.AddWithValue("@changeCode",changeBook.bookCode);
            cmd_update.Parameters.AddWithValue("@changeTitle",changeBook.bookTitle);
            cmd_update.Parameters.AddWithValue("@changeSection",changeBook.bookSection);
            cmd_update.Parameters.AddWithValue("@changeQuantity",changeBook.quantity);
            cmd_update.Parameters.AddWithValue("@changeIsAvailable",changeBook.bookIsAvailable);
            cmd_update.Parameters.AddWithValue("@changeUnitPrice",changeBook.unitPrice);

            try
            {
             connection.Open();
             cmd_update.ExecuteNonQuery();
            }
            catch(System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                
            }
            finally
            {
                connection.Close();
            }
            return "Book Updated Successfully";

         }
        #endregion

        #region  DELETE BOOK FROM CART

         public string DeleteBook(string leteBook)
         {
            SqlCommand cmd_deleteBook = new SqlCommand("delete from Cart where bookTitle=@bookTitle",connection);
            cmd_deleteBook.Parameters.AddWithValue("@bookTitle",leteBook);
           
            try
            {
                connection.Open();
                cmd_deleteBook.ExecuteNonQuery();
            }
            catch (System.Exception es)
            {
                
                System.Console.WriteLine(es.Message);
            }
            finally
            {
                connection.Close();
            }
            return "Book deleted Successfully";
         }
    
        #endregion
          

    }
}