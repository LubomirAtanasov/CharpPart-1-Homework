﻿using System;

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.


class EmployeeData
{
    static void Main()
    {
        string furstName = "Amaro";
        string LastName = "Shakur";
        byte age = 28;
        char gender = 'f';
        long personalID = 8306112507;
        ulong employeeNumber = 27569999;
        Console.WriteLine("Furst Name: "+ furstName);
        Console.WriteLine("Last Name: "+LastName);
        Console.WriteLine("Age: "+age);
        Console.WriteLine("Gender: "+gender);
        Console.WriteLine("Personal ID: "+personalID);
        Console.WriteLine("Employee Number: "+employeeNumber);
    }
}

