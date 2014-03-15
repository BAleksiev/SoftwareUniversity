using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter company phone number: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Enter company fax number: ");
        string companyFax = Console.ReadLine();
        Console.Write("Enter company website: ");
        string companyWebsite = Console.ReadLine();
        Console.Write("Enter company manager: ");
        string companyManager = Console.ReadLine();

        Console.Write("Enter manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter manager age: ");
        ushort managerAge = ushort.Parse(Console.ReadLine());
        Console.Write("Enter manager phone number: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine(
            "Company name: {0}\nCompany address: {1}\nCompany phone number: {2}\nCompany fax number: {3}\nCompany website: {4}\nCompany manager: {5}\n", 
            companyName, companyAddress, companyPhone, companyFax, companyWebsite, companyManager);
        Console.WriteLine("Manager first name: {0}\nManager last name: {1}\nManager age: {2}\nManager phone number: {3}", 
            managerFirstName, managerLastName, managerAge, managerPhone);
    }
}