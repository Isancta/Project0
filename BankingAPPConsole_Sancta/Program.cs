using System;

namespace BankingAPPConsole_Sancta
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts User1 = new Accounts()
            {
                accNumber = 77,
                accName = "Annick",
                accType = "cheching",
                accBalance = 1000,
                accIsActive = True,
                accEmail = "annick12@gmail.com"
            }
            
        }
    }
}
