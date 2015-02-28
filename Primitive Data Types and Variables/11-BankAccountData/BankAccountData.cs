using System;

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
class BankAccountData
{
    static void Main()
    {
        string firstName = "Amaro";
        string middleName = "Ivanov";
        string lastName = "Shakur";
        decimal money = 653245435.57m;
        string bankName = "SIBANK";
        string iban = "BG98 BBGT 0012 1231 8921 47";
        long cardNumber1 = 387196538611304;
        long cardNumber2 = 866391209147205;
        long cardNumber3 = 017424819620850;
        Console.WriteLine("First Name: "+ firstName);
        Console.WriteLine("Middle Name: "+ middleName);
        Console.WriteLine("Last Name: "+ lastName);
        Console.WriteLine("Money: "+ money);
        Console.WriteLine("Bank Name: "+ bankName);
        Console.WriteLine("Iban: "+ iban);
        Console.WriteLine("Card Number1: "+ cardNumber1);
        Console.WriteLine("Card Number2: "+ cardNumber2);
        Console.WriteLine("Card Number3: "+ cardNumber3);
    } 
}

