/***********************************************************
* BANK CLASS
* The Bank Class will manage the accounts and help
* direct the actions that will happen to each account 
* or transaction.
************************************************************/
class Bank
{
    //Member Variables
   string transactionSelection = "";
   int accountLocation = 0;
   List<Account> accounts;

   Transactions transaction = new Transactions();  




/*************************************************
* CHOOSE TRANSACTION
* Let the user choose what will happen to the account
**************************************************/
   public void chooseTransaction(int accountLocation, AccountList accountList)
   {
    bool done = false;
    while(!done)
    {
    //Display the User's Options
    Console.WriteLine();
    Console.WriteLine("Please Choose what Transaction you would like to do: Enter a number between 1 to 3.");
    Console.WriteLine("1) Show Account Amount");
    Console.WriteLine("2) Deposit Cash");
    Console.WriteLine("3) Withdraw Cash");
    Console.WriteLine("4) Show Recent Transactions");
    Console.WriteLine("5) Produce Bank Report");
    Console.WriteLine("6) Exit");

    //Read the User's Input into a variable.
    string transactionSelection = Console.ReadLine();

    //Send the User to Where they need to go.
    switch(transactionSelection)
    {
        case "1":
            transaction.displayAccountAmount(accounts, accountLocation, accountList);
        break;

        case "2":
            transaction.depositAmount(accounts, accountLocation, accountList);
        break;

        case "3":
            transaction.withdrawlAmount(accounts, accountLocation, accountList);
        break;

        case "4":
        transaction.getRecentTrasactions(accounts, accountLocation, accountList);
        break;

        case "5":
        transaction.getReport(accounts, accountLocation, accountList);
        break;
                
        case "6":
        done = true;
        break;
    }
    }
   }
}

