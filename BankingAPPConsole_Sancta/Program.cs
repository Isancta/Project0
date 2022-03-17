using System;

namespace BankingAPPConsole_Sancta
{
    class Program
    {
        static void Main(string[] args)
        {
          #region collecte user informations 
            Accounts User = new Accounts()
            {
                accNumber = 77,
                accName = "Annick",
                accType = "checking",
                accBalance = 1000,
                accIsActive = true,
                accEmail = "annick12@gmail.com"
            };
            
            #endregion
            User.getAccountDetails();
            Console.WriteLine(User.Withdraw(200)); 
            Console.WriteLine(User.deposit(2000));
            Console.WriteLine(User.CheckBalance());
         bool Banking = true;
 while (Banking ){
            #region Menu
            Console.ReadLine("");
            Console.WriteLine(" Choose option below");
            Console.WriteLine("");
            Console.WriteLine("1. Create new account");
            Console.WriteLine("2. Check Balance");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Deposit");
            Console.WriteLine("5. Get details");
            Console.WriteLine("6. Exit");
            
            

            int option = Convert.ToInt32(Console.ReadLine());
            
            switch(option)
            {
              case 1: 
                      Console.WriteLine( "please enter your name");
                      User.accName = Console.ReadLine();
                      Console.WriteLine("Please enter the type of account you wish to open");
                      User.accType= Console.ReadLine();
                      Console.WriteLine("Please enter your account balance.");
                      User.accBalance = Convert.ToDouble(Console.ReadLine());
                      Console.WriteLine("Is the account active?");
                      User.accIsActive = Convert.ToBoolean(Console.ReadLine());
                      Console.WriteLine("Please enter your email");
                      User.accEmail = Console.ReadLine();
                      break;

              case 2:  
                      Console.WriteLine( " Your balance is :" + User.CheckBalance());
                      break;

              case 3:
                      Console.WriteLine("How much would you like to withdraw?");
                      double Withdraw_Amount= Convert.ToDouble(Console.ReadLine( ));
                      Console.WriteLine(User.Withdraw( Withdraw_Amount));
                      
                      break;

              case 4:
                      Console.WriteLine("How much would you like to deposit?");
                      double Deposit_Amount= Convert.ToDouble(Console.ReadLine( ));
                      Console.WriteLine(User.deposit(Deposit_Amount));
                      break;

              case 5: 
                      User.getAccountDetails();
                      break;
                     
              case 6:
                     Banking=false;
                     Console.WriteLine("Exit");
                     break;

            }      



            }
           
           
           
           
           
            #endregion

            


          
    }
}}
