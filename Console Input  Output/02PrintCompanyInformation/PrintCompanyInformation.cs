using System;

class PrintCompanyInformation
{
    static void Main()
    {
        string CompanyName = "SoftWare University";
        string CompanyAddress = "26 V. Kanchev, Sofia";
        string PhoneNumber = "+359 899 55 55 92";
        string FAxNumber = "(No fax)";
        string WebSite = "http://softuni.bg";
        string ManagerFirtsName = "Svetlin";
        string ManagerLastName = "Nakov";
        string ManagerAge = "25";
        string ManagerPhone = "+359 2 981 981";

        Console.WriteLine(CompanyName);
        Console.WriteLine("Address: " + CompanyAddress);
        Console.WriteLine("Tel. " + PhoneNumber);
        Console.WriteLine("Fax: " + FAxNumber);
        Console.WriteLine("Web site: " + WebSite);
        Console.WriteLine("Manager: " + ManagerFirtsName + " " + ManagerLastName + " " + "(age: " + ManagerAge + ", " + "tel. " + ManagerPhone + ")");

        Console.WriteLine();
    }

}

