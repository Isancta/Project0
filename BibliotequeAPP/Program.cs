using System;
using System.Collections.Generic;

namespace BibliotequeAPP
{
    class Program
    {

       
        static void Main(string[] args)
        {
            
          Cart myLibrary = new Cart(); 
          BookInfo MyCatalogue = new BookInfo();
            bool continueShopping  = true;
            bool isLoggedIn = false;

            if (isLoggedIn == false)
            {
                System.Console.WriteLine("Enter Your User Name");
                string username = Console.ReadLine();
                System.Console.WriteLine("Enter Your Password");
                string password = Console.ReadLine();
                Key user = new Key();
                
                bool loginContent = user.SignIn(username,password);
                if(loginContent == false)
                {   
                        System.Console.WriteLine("Invalid username and/or password");
                }
                else
                {
                
                    isLoggedIn = true;
               
                    while (continueShopping)
                    {

                       #region MENU

                       

                             Console.WriteLine("  \n WELCOME TO YOUR LIBRARY");
                             Console.WriteLine("  \n Please choose from the Menu");

                             Console.WriteLine("1. Explore Catalogue");
                             Console.WriteLine("2. Add Book in catalogue ");
                             Console.WriteLine("3. Search Book By Title");
                             Console.WriteLine("4. Edit Book");
                             Console.WriteLine("5. Delete Book");
                             Console.WriteLine("6. Log out");
                      
                       int choice = Convert.ToInt32(Console.ReadLine());

                       #endregion

                           switch (choice)
                           {
                              case 1: 
                              #region EXPLORE CATALOGUE
                         
                                   MyCatalogue.GetBooksList();

                                    break;
                              #endregion
                               
                             case 2: 

                             #region ADD BOOK TO CATALOGUE

                                      BookInfo pickedB = new BookInfo();
                                      
                                      
                                      Console.WriteLine("Enter Book Title ");
                                      pickedB.bookTitle  = Convert.ToString(Console.ReadLine());

                                      //Console.WriteLine("Enter Book Code ");
                                     // pickedB.bookCode  = Convert.ToInt32(Console.ReadLine());

                                      Console.WriteLine("Enter Product Category");
                                      pickedB.bookSection = Convert.ToString(Console.ReadLine());

                                      Console.WriteLine("Enter book is available");
                                      pickedB.bookIsAvailable = Convert.ToBoolean(Console.ReadLine());

                                      Console.WriteLine("Enter Product Price");
                                      pickedB.unitPrice = Convert.ToDouble(Console.ReadLine());

                                      Console.WriteLine("Enter Number of book");
                                      pickedB.quantityInStore = Convert.ToInt32(Console.ReadLine());

                                      pickedB.AddNewBook();

                                       break;
                                #endregion
                                    
                             case 3:
                             #region SEARCH BOOK BY TITLE IN CATALOGUE

                                      System.Console.WriteLine("Enter Book title to search");
                                      string wantedB = Console.ReadLine();
                                      BookInfo yourBook = MyCatalogue.GetBookByTitle(wantedB);

                                      Console.WriteLine("Book Code " + yourBook.bookCode);
                                      Console.WriteLine("Book Title " + yourBook.bookTitle);
                                      Console.WriteLine("Book Section " + yourBook.bookSection);
                                      Console.WriteLine("Book Is Available " + yourBook.bookIsAvailable);
                                      Console.WriteLine("Quantity available " + yourBook.quantityInStore);
                                      Console.WriteLine("Price per Unit " + yourBook.unitPrice);
                                      Console.ReadLine();
                                      
                                break;
                               
                                #endregion

                                 
                                case 4: 
                                #region EDIT BOOK FROM Catalogue

                                 BookInfo ediBook = new BookInfo();

                                      Console.WriteLine("Enter book Code to edit");
                                      ediBook.bookCode = Convert.ToInt32 (Console.ReadLine());

                                      Console.WriteLine("Enter Book Name ");
                                      ediBook.bookTitle = Console.ReadLine();

                                       Console.WriteLine("Enter quantity");
                                      ediBook.quantityInStore = Convert.ToInt32(Console.ReadLine());

                                      ediBook.EditBook();
                                      
                                break;
                                #endregion

                                case 5: 
                                #region DELETE BOOK FROM CART
                                BookInfo bookdelete=new BookInfo();

                                System.Console.WriteLine("Enter book Code to delete");
                                 
                                bookdelete.bookCode = Convert.ToInt32(Console.ReadLine());

                                bookdelete.DeleteBook();
                
                                break;
                                #endregion

                                case 6:
                                #region LOG OUT

                                continueShopping = false;
                                isLoggedIn = false;
                                
                                break;

                                default:
                                System.Console.WriteLine("Please enter the correct number from Menu");
                                break;
                                #endregion
                           }

                    }
                }
            }     
            
        }    
    
    }

}
