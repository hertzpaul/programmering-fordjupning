
        Random random = new Random();

        int result1 = random.Next(1, 7);
        int result2 = random.Next(1, 7);
        if(result1 == result2)
        {
            Console.WriteLine("Du fick två " + GetDiceWord(result1));
        } else {
            Console.WriteLine("Du fick en " + GetDiceWord(result1) + " och en " + GetDiceWord(result2));
        }

    static string GetDiceWord(int diceResult)
    {
        switch (diceResult)
        {
            case 1:
                return "etta";
            case 2:
                return "tvåa";
            case 3:
                return "trea";
            case 4:
                return "fyra";
            case 5:
                return "fema";
            case 6:
                return "sexa";
            default:
                return "Nej tack";
        }
    }





