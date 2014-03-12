using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Ivanov";
        string lastName = "Ivanov";
        decimal balance = 93544353.251m;
        string bankName = "World bank";
        string IBAN = "BG35GP42150194159275";
        long cardNum1 = 1234567891234567;
        long cardNum2 = 4535234573248957;
        long cardNum3 = 1948123478234839;

        Console.WriteLine("First Name: {0}\nMiddle Name: {1}\nLast Name: {2}\nBalance: {3} USD\nBank Name: {4}\nIBAN: {5}\nCredit Card 1: {6}\nCredit Card 2: {7}\nCredit Card 3: {8}",
            firstName, middleName, lastName, balance, bankName, IBAN, cardNum1, cardNum2, cardNum3);
    }
}