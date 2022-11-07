
//Checking whether an input – such as an ATM card (a debit/credit card number) – is recorded correctly

//Verifying the user by asking for a PIN

//In case of negative verification, logging out the user????????????????


// In case of positive verification, showing multiple options, including cash availability, the previous five transactions, and cash withdrawal
// Giving the user the ability to withdraw up to $1,000 worth of cash in one transaction, with total transactions limited to ten per day.


//METHOD: VERIFY USER 1
//CHOOSE TRANSCATION (Switch Case?) 2 THEN SEND TO BANK
//HAVE LOOP HERE
/***********************************************************
* PROGRAM
* This is where the program starts.  It will call ATM to start
************************************************************/
class Program
{
  static void Main(string[] args)
  {
    ATM atm = new ATM();
  atm.getUserInput();
  }
}