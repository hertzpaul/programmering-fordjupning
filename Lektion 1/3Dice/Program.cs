
        Random random = new Random();

        int result1 = random.Next(1, 7);
        int result2 = random.Next(1, 7);
        int result3 = random.Next(1, 7);

        if(result1 == result2)
        {
            Console.WriteLine("Du fick två " + GetDiceWord(result1)+"or" + " och en " + GetDiceWord(result3)+"a");
        } else if(result1 == result3){
            Console.WriteLine("Du fick två " + GetDiceWord(result1)+"or" + " och en " + GetDiceWord(result2)+"a");
        } else if (result2 == result3){
            Console.WriteLine("Du fick två " + GetDiceWord(result1)+"or" + " och en " + GetDiceWord(result1)+"a");
        } else if (result1 == result2 && result2 == result3){
            Console.WriteLine("Du fick tre " + GetDiceWord(result1)+"or");
        } else {
            Console.WriteLine("Du fick en " + GetDiceWord(result1)+"a" + ", en " + GetDiceWord(result2)+"a" + " och en " + GetDiceWord(result3)+"a");
        }

    static string GetDiceWord(int diceResult)
    {
        switch (diceResult)
        {
            case 1:
                return "ett";
            case 2:
                return "två";
            case 3:
                return "tre";
            case 4:
                return "fyr";
            case 5:
                return "femm";
            case 6:
                return "sex";
            default:
                return "Nej tack";
        }
    }