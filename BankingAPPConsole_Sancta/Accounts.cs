using System;

class Accounts 
{
#region My Variables
    static int autoAccNumber; 
    public int accNumber {get;set;}
    public string accName {get;set;}
    public string accType {get;set;}
    public double accBalance {get;set;}
    public bool accIsActive {get;set;}
    public string accEmail {get;set;} 
    
#endregion
public Accounts(){
autoAccNumber++;
accNumber=autoAccNumber;
}
#region My Methods

public double CheckBalance()
{
    return accBalance;
}

public double Withdraw(double Amount)
{ accBalance -= Amount;
return accBalance;


}
public double deposit(double Amount)
{
    accBalance += Amount;
    return accBalance;
    //Console.WriteLine( " your accBalance is : "+accBalance);
}

public void getAccountDetails()
{
    Console.WriteLine( "Account No :"+accNumber);
    Console.WriteLine( "Name :"+ accName);
    Console.WriteLine( " Type :"+accType);
    Console.WriteLine( "Balance :"+accBalance);
    Console.WriteLine( "Email :"+accEmail);
    
}




}
#endregion




