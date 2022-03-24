using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace BibliotequeAPP 
{
   class BookInfo
   {
        #region Library Catalogue Variables
   
          public int bookCode{get;set;}
          public string bookTitle {get;set;}
          public string bookSection {get;set;}
          public bool bookIsAvailable {get;set;}
          public double unitPrice {get;set;}
          public int quantityInStore {get;set;}
          
        #endregion
        
         SqlConnection connection = new SqlConnection(@"Data source=SANCTA-MARIE\ISPM_TRAINING;Initial Catalog=BibliothequeAPP;integrated security=true");

        #region CATALOGUE CONTENT

        public  void  GetBooksList()
           {

            SqlCommand command = new SqlCommand("select * from LibraryCatalogues",connection);
            SqlDataReader readCatalogue;
                try
                   {
                     connection.Open();
                     readCatalogue = command.ExecuteReader();
                     
                     while(readCatalogue.Read())
                        
                             {
                                  Console.WriteLine("Book Code: "  +readCatalogue[0]);
                                  Console.WriteLine("Book Titke: " +readCatalogue[1]);

                                  Console.WriteLine("Book Section: " +readCatalogue[2]);
                                 Console.WriteLine("Book Is Available: " +readCatalogue[3]); 
                                 Console.WriteLine("Book Price : $" +readCatalogue[4]);
                                 Console.WriteLine("Quantity in Store: " + readCatalogue[5]); 
       
                             }
                          
                   }
                 catch(SqlException se)
                    {
                        throw new Exception(se.Message);
                    } 
                 finally
                    {
                        
                       connection.Close();
                    }  

            
            }
     
        #endregion
        
        #region SEARCH BOOKS
    
        public  BookInfo GetBookByTitle(string title )
        {
            BookInfo myBook=new BookInfo();
            SqlCommand cmd_search = new SqlCommand("select * from LibraryCatalogues where bookTitle = @bookTitle" ,connection);
            cmd_search.Parameters.AddWithValue("@bookTitle",title);
            SqlDataReader readTable = null;
            try
            {
                connection.Open();
                readTable = cmd_search.ExecuteReader();
                   
                   if(readTable.Read())
                   {
                       myBook.bookCode = Convert.ToInt32(readTable[0]);
                       myBook.bookTitle =title;
                       myBook.bookSection = Convert.ToString(readTable[2]); 
                       myBook.bookIsAvailable = Convert.ToBoolean(readTable[3]);
                       myBook.unitPrice = Convert.ToDouble(readTable[4]);
                       myBook.quantityInStore = Convert.ToInt32(readTable[5]);

                       return myBook;

                   }
                   else
                   {
                       System.Console.WriteLine (" Sorry, Book Not Found in Catalogue");
                   }

            }
            catch (System.Exception es)
            {
                System.Console.WriteLine(es.Message);
            }
            finally
            {
                readTable.Close();
                connection.Close();
            }

        return myBook;

        }

        #endregion
        
        #region 

         public void AddNewBook()
         {
            SqlCommand cmd_addBook = new SqlCommand("insert into LibraryCatalogues values(@bookTitle,@bookSection,@bookIsAvailable,@unitPrice,@quantityInStore)" ,connection);
            //cmd_addBook.Parameters.AddWithValue("@bookCode", bookCode);
            cmd_addBook.Parameters.AddWithValue("@bookTitle", bookTitle);
            cmd_addBook.Parameters.AddWithValue("@bookSection", bookSection);
            cmd_addBook.Parameters.AddWithValue("@quantityInStore", quantityInStore);
            cmd_addBook.Parameters.AddWithValue("@bookIsAvailable", bookIsAvailable);
            cmd_addBook.Parameters.AddWithValue("@unitPrice", unitPrice);
            

            try
            {
                connection.Open();
                cmd_addBook.ExecuteNonQuery();
                Console.WriteLine(" Book added Successfully");
            }
            catch(SqlException ex)
            {
               Console.WriteLine(ex.Message);
               Console.ReadLine();
            }
            finally
            {
               connection.Close();

            }
           

         } 
        
        #endregion

    }

}    

