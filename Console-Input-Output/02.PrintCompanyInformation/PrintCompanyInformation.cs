using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Company phone number: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Company fax number: ");
        string companyFax = Console.ReadLine();
        Console.Write("Company website: ");
        string companyWebsite = Console.ReadLine();

        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        ushort managerAge = ushort.Parse(Console.ReadLine());
        Console.Write("Manager phone number: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("\n{0}", companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", companyPhone);
        Console.WriteLine("Fax: {0}", companyFax);
        Console.WriteLine("Web site: {0}", companyWebsite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
    }
}
