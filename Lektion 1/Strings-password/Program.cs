
using System.Text.RegularExpressions;
    {
        bool isValid = false;

        while (!isValid)
        {
            Console.Write("Testa ditt lösenord: ");
            string password = Console.ReadLine();

            if (IsValidPassword(password))
            {
                Console.WriteLine("True, det är giltigt!");
                isValid = true;
            }
            else
            {
                Console.WriteLine("False, det är inte giltigt! Försök igen.");
            }
        }

        Console.ReadLine();
    }

    static bool IsValidPassword(string input)
    {
        Regex regex = new Regex("^(?=.*?[A-Z]{2,})(?=.*?[a-z]{2,})(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
        return regex.IsMatch(input);
    }



