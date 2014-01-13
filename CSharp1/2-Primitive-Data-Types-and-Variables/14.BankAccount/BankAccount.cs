using System;

class BankAccount
{
    static void Main()
    {
        // Account holder information
        string firstName = "Ivan";
        string secondName = "Peshov";
        string lastName = "Geshev";
        
        // Bank information
        string bankName = "ProCredit Bank";
        string bankID = "PRCBBGSF";

        // Account information
        decimal accBalance = 1526.27M;
        string accIBAN = "BG80BNBG96611020345678";
        
        // Cretit cards information
        long accCreditCard1 = 4012222222221881;
        long accCreditCard2 = 5105105105105100;
        long accCreditCard3 = 5500000000000004;

        Console.WriteLine("Account holder: {0} {1} {2}", firstName, secondName, lastName );
        Console.WriteLine("Bankname: {0}. BIC: {1}", bankName, bankID);
        Console.WriteLine("Bank account number: {0} has balance: {1}", accIBAN, accBalance);
        Console.WriteLine("Credit card numbers associated with this bank account are:\r\n{0}\r\n{1}\r\n{2}",accCreditCard1, accCreditCard2, accCreditCard3);
    }
}
