
        Random random = new Random();

        Console.WriteLine("Välkommen till Dice Game");
        Console.WriteLine("Tryck enter för att starta");
        Console.ReadLine();
        Console.WriteLine("Välj Sten, Sax eller Påse ");
        Console.WriteLine("1 = Sten");
        Console.WriteLine("2 = Sax");
        Console.WriteLine("3 = Påse");
        
         int playerChoice;
        do
        {
            Console.WriteLine("");
            Console.Write("Ditt val: ");
            playerChoice = Int32.Parse(Console.ReadLine());

        } while (playerChoice < 1 || playerChoice > 3);
        

        int computerChoice = random.Next(1, 5); 

        string computerWord = GetDiceWord(computerChoice);

        Console.WriteLine($"Datorn valde: {computerWord}");

        string winner = DetermineWinner(playerChoice, computerChoice);

        Console.WriteLine(winner);

        Console.ReadKey();
    

    static string GetDiceWord(int diceResult)
    {
        switch (diceResult)
        {
            case 1:
                return "Sten";
            case 2:
                return "Sax";
            case 3:
                return "Påse";
            case 4: 
                return "Lightsaber";
            default:
                return "Nej tack";
        }
    }

    static string DetermineWinner(int playerChoice, int computerChoice)
    {
        if (playerChoice == computerChoice)
        {
            return "Det blev lika! Bra fight!";
        }
        else if (computerChoice == 4) 
        {
            return "Datorn vann! (Lightsaber slår allt!)";
        }
        else if ((playerChoice == 1 && computerChoice == 2) ||
                 (playerChoice == 2 && computerChoice == 3) ||
                 (playerChoice == 3 && computerChoice == 1))
        {
            return "Du vann!";
        }
        else
        {
            return "Datorn vann!";
        }
    }
