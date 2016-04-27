using System;
using System.Numerics;

class CardWars
{


    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger Pesho = 0;
        BigInteger Gosho = 0;
        int result = new int();
        int games_won_Pesho = new int();
        int games_won_Gosho = new int();
        int Z_counter = 0;
        int Y_counter = new int();
        int X_counter = new int();
        int X_cards_Pesho = new int();
        int X_cards_Gosho = new int();
        bool X_card_found = false;

        for (int i = 0; i < n; i++)
        {
            string number1 = Console.ReadLine();
            int result1 = card_points_matcher(number1, result, ref Z_counter, ref Y_counter, ref  X_counter);
            string number2 = Console.ReadLine();             
            int result2 = card_points_matcher(number2, result, ref Z_counter, ref Y_counter, ref X_counter);
            string number3 = Console.ReadLine();             
            int result3 = card_points_matcher(number3, result, ref Z_counter, ref Y_counter, ref X_counter);
            result = result1 + result2 + result3;
            Pesho += result;
            if (Z_counter == 1) Pesho *= 2;
            if (Z_counter == 2) Pesho *= 4;
            if (Z_counter == 3) Pesho *= 8;
            if (Y_counter == 1) Pesho -= 200;
            if (Y_counter == 2) Pesho -= 400;
            if (Y_counter == 3) Pesho -= 600;
            X_cards_Pesho = X_counter;
            X_counter = 0;
            Z_counter = 0;
            Y_counter = 0;
            result = 0;

            number1 = Console.ReadLine();
            result1 = card_points_matcher(number1, result, ref Z_counter, ref Y_counter, ref X_counter);
            number2 = Console.ReadLine();
            result2 = card_points_matcher(number2, result, ref Z_counter, ref Y_counter, ref X_counter);
            number3 = Console.ReadLine();
            result3 = card_points_matcher(number3, result, ref Z_counter, ref Y_counter, ref X_counter);
            result = result1 + result2 + result3;
            Gosho += result;
            if (Z_counter == 1) Gosho *= 2;
            if (Z_counter == 2) Gosho *= 4;
            if (Z_counter == 3) Gosho *= 8;
            if (Y_counter == 1) Gosho -= 200;
            if (Y_counter == 2) Gosho -= 400;
            if (Y_counter == 3) Gosho -= 600;
            X_cards_Gosho = X_counter;
            X_counter = 0;

            if (X_cards_Pesho==X_cards_Gosho && X_cards_Gosho > 0)
            {
                Pesho += 50;
                Gosho += 50;
            }
            else if ( (X_cards_Pesho > X_cards_Gosho)  || (X_cards_Gosho> X_cards_Pesho))
            {
                X_card_found = true;
                break;
            }
            else if (Pesho > Gosho)
            {
                games_won_Pesho++;
            }
            else if (Gosho > Pesho)
            {
                games_won_Gosho++;
            }
            else
            {
                Pesho -= result;
                Gosho -= result;
            }
            result = 0;
            Z_counter = 0;
            Y_counter = 0; 
        }


        string player = Pesho>Gosho? "First":"Second";
        string player_one_two = X_cards_Pesho > X_cards_Gosho ? "one" : "two";

        if (X_card_found)
        {
            Console.WriteLine("X card drawn! Player {0} wins the match!", player_one_two);
        }
        else if (Pesho>Gosho || Gosho>Pesho)
        {
            Console.WriteLine("{0} player wins!", player);
            Console.WriteLine("Score: {0}", Pesho > Gosho ? Pesho : Gosho);
            Console.WriteLine("Games won: {0}", Math.Max(games_won_Pesho, games_won_Gosho));
        }
        else
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", Pesho);

        }

        //Console.WriteLine(Pesho);
        //Console.WriteLine(Gosho);

    }
    static int card_points_matcher(string num, int result, ref int Z_counter, ref int Y_counter, ref int X_counter)
    {

        switch (num)
        {
            case "A": result = 1; break;
            case "J": result = 11; break;
            case "Q": result = 12; break;
            case "K": result = 13; break;
            case "Z": Z_counter++; break;
            case "Y": Y_counter++; break;
            case "X": X_counter++; break;
            default: result += 12-int.Parse(num); break;
        }

        return result;
    }

}

