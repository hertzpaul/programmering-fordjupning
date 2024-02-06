using System.Text.RegularExpressions;

Console.Write("Mata in registeringsnummer: ");
string userInput = Console.ReadLine();
        
     if(IsValidInput(userInput))   
     {
        Console.WriteLine("JA, det är giltigt!");
     } else
     {
        Console.WriteLine("Nej, inte giltigt :(");
     }


    static bool IsValidInput(string input)
    {
        Regex regex = new Regex(@"^[a-zA-Z]{3}\d{3}|[a-zA-Z]{3}\d{2}[a-zA-Z]$");

        return regex.IsMatch(input);
    }


