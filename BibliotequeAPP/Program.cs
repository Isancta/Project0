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

                                case 3:
                                #region BORROW/LEASE/BUY-ADD BOOK TO CART

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
                                     

                                      

                                      

            
                                    
                                   
                                case 4: 
                                #region EDIT BOOK FROM CART

                                      System.Console.WriteLine("Enter Product title to edit");
                                      string newTitle = Console.ReadLine();

                                      System.Console.WriteLine("Enter Product Section");
                                      string newSection = Console.ReadLine();

                                      System.Console.WriteLine("Enter quantity");
                                      int newQuantity = Convert.ToInt32(Console.ReadLine());

                                      System.Console.WriteLine("Enter book is available");
                                      bool newIsAvailable = Convert.ToBoolean(Console.ReadLine());

                                      System.Console.WriteLine("Enter Product Price");
                                      Double newPrice = Convert.ToDouble(Console.ReadLine());

                                      
                                      Cart bookChange = new Cart();

                                      newTitle = bookChange.bookTitle;
                                      newSection = bookChange.bookSection;
                                      newQuantity =bookChange.quantity;
                                      newIsAvailable = bookChange.bookIsAvailable;
                                      newPrice = bookChange.unitPrice ;
                   
                                      System.Console.WriteLine(myLibrary.EditBook(bookChange));
                          
                                break;
                                #endregion

                                case 5: 
                                #region DELETE BOOK FROM CART

                                System.Console.WriteLine("Enter book title to delete");
                                 string bookToDelete = Console.ReadLine();

                                 System.Console.WriteLine(myLibrary.DeleteBook(bookToDelete));
                
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
