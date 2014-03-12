using System;

class CalculateAge
{
    static void Main()
    {
        byte years = 10;
        DateTime birthDate;
        DateTime currentDate = DateTime.Now;
        int currentAge;
        int ageAfter;

        Console.WriteLine("Enter your birth date (Format: dd/mm/yyyy):");
        birthDate = Convert.ToDateTime(Console.ReadLine());

        // Check if input date is not in the future.
        if(birthDate.Year > currentDate.Year || 
            (birthDate.Year >= currentDate.Year && birthDate.Month > currentDate.Month) || 
            (birthDate.Year >= currentDate.Year && birthDate.Month >= currentDate.Month && birthDate.Day > currentDate.Day))
        {
            do
            {
                Console.WriteLine("Please enter a valid date:");
                birthDate = Convert.ToDateTime(Console.ReadLine());
            } while (birthDate.Year > currentDate.Year ||
            (birthDate.Year >= currentDate.Year && birthDate.Month > currentDate.Month) ||
            (birthDate.Year >= currentDate.Year && birthDate.Month >= currentDate.Month && birthDate.Day > currentDate.Day));
        }

        if(currentDate.Month < birthDate.Month)
        {
            currentAge = (currentDate.Year - birthDate.Year) - 1;
            ageAfter = (currentDate.Year - birthDate.Year) + years - 1;
        }
        else if(currentDate.Month == birthDate.Month)
        {
            if(currentDate.Day < birthDate.Day)
            {
                currentAge = (currentDate.Year - birthDate.Year) - 1;
                ageAfter = (currentDate.Year - birthDate.Year) + years - 1;
            }
            else
            {
                currentAge = currentDate.Year - birthDate.Year;
                ageAfter = (currentDate.Year - birthDate.Year) + years;

                if(currentDate.Day == birthDate.Day)
                {
                    Console.WriteLine("Happy Birthday !");
                }
            }
        }
        else
        {
            currentAge = currentDate.Year - birthDate.Year;
            ageAfter = (currentDate.Year - birthDate.Year) + years;
        }

        Console.WriteLine("You are {0} years old.", currentAge);
        Console.WriteLine("After {0} years you will be {1} years old.", years, ageAfter);
    }
}