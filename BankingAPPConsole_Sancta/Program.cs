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
                accType = "cheching",
                accBalance = 1000,
                accIsActive = true,
                accEmail = "annick12@gmail.com"
            };
            
            #endregion
            User.getAccountDetails();
            Console.WriteLine(User.Withdraw(200)); 
            Console.WriteLine(User.deposit(2000));
            Console.WriteLine(User.CheckBalance());

            

            


          
    }
}}
