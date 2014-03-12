using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Ivan";
        string lastName = "Ivanov";
        byte age = 45;
        char gender = 'm';
        long personalID = 8306112507;
        ulong employeeNumber = 34532453225345;

        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("personal ID: " + personalID);
        Console.WriteLine("Unique employee number: " + employeeNumber);
    }
}