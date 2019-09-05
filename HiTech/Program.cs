using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace HiTech
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayHeader();
            guessingGame();
        }
        public static void DisplayHeader()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"#=============================================#");
            Console.WriteLine($"|                                             |");
            Console.WriteLine($"|                                             |");
            Console.WriteLine($"|                  BLACKJACK                  |");
            Console.WriteLine($"|                                             |");
            Console.WriteLine($"|                                             |");
            Console.WriteLine($"#=============================================#");
            Console.WriteLine($"");
            Console.ForegroundColor = ConsoleColor.White;



        }
        public static void guessingGame()
        {
            List<int> HouseVal = new List<int>();
            List<int> blackjack1 = new List<int>();
            Random random = new Random();
            int blackjack = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hit to recive a card, or stand to stand!");
                string Hit;
                Console.ForegroundColor = ConsoleColor.Green;
                Hit = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();

                if (Hit.ToLower() == "hit")
                {
                    int randomNR1 = random.Next(1, 11);
                    int value = blackjack + randomNR1;
                    blackjack1.Add(value);
                    int total = blackjack1.Sum(item => item);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Current value: {total}");


                    if (total == 21)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"*******************************");
                        Console.WriteLine($"*                             *");
                        Console.WriteLine($"*          JACKPOT            *");
                        Console.WriteLine($"*                             *");
                        Console.WriteLine($"*******************************");
                        MakeSund();
                        Console.ForegroundColor = ConsoleColor.White;
                        PlayAgain();
                        break;
                    }
                    if (total > 21)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"£££££££££££££££££££££££££££££££");
                        Console.WriteLine($"£                             £");
                        Console.WriteLine($"£            BUST             £");
                        Console.WriteLine($"£                             £");
                        Console.WriteLine($"£££££££££££££££££££££££££££££££");
                        PlayAgain();
                        break;

                    }
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Hit again? Or stand?");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                if (Hit.ToLower() == "stand")
                {
                    int randomNr2 = random.Next(3, 11);
                    Console.WriteLine($"House card 1: {randomNr2}");
                    Thread.Sleep(1000);
                    int randomNr3 = random.Next(3, 11);
                    Console.WriteLine($"House card 2: {randomNr3}");

                    Thread.Sleep(1000);
                    int HouseValue = randomNr2 + randomNr3;
                    Console.WriteLine($"House got: {HouseValue}");

                    int total = blackjack1.Sum(item => item);

                    if (HouseValue > total)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"*******************************");
                        Console.WriteLine($"*                             *");
                        Console.WriteLine($"*          You Loose          *");
                        Console.WriteLine($"*                             *");
                        Console.WriteLine($"*******************************");
                        Console.WriteLine($"You got {total} vs house {HouseValue}");
                        MakeSund();
                        Console.ForegroundColor = ConsoleColor.White;
                        PlayAgain();
                        break;
                    }
                    else if (total > HouseValue)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"*******************************");
                        Console.WriteLine($"*                             *");
                        Console.WriteLine($"*          JACKPOT            *");
                        Console.WriteLine($"*                             *");
                        Console.WriteLine($"*******************************");
                        Console.WriteLine($"You got {total} vs house {HouseValue}");
                        MakeSund();
                        Console.ForegroundColor = ConsoleColor.White;
                        PlayAgain();
                        break;
                    }


                }
            } while (blackjack < 21);

        }
        public static void PlayAgain()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to play again or Quit to exit!");
            string enter = Console.ReadLine();
            if (enter == "")
            {
                guessingGame();
            }
            else if (enter.ToLower() == "Quit")
            {
                Console.WriteLine("Coward!");
            }

        }
        public static void MakeSund()
        {
            Console.Beep(440, 300);
            Console.Beep(330, 300);
            Console.Beep(440, 300);
            Console.Beep(330, 300);
            Console.Beep(440, 300);
            Console.Beep(415, 300);
            Console.Beep(415, 300);
            Thread.Sleep(600);
            Console.Beep(415, 300);
            Console.Beep(330, 300);
            Console.Beep(415, 300);
            Console.Beep(330, 300);
            Console.Beep(415, 300);
            Console.Beep(440, 300);
            Console.Beep(440, 300);
            Thread.Sleep(600);
            Console.Beep(440, 300);
            Console.Beep(494, 300);
            Console.Beep(494, 100);
            Console.Beep(494, 100);
            Console.Beep(494, 300);
            Console.Beep(494, 300);
            Console.Beep(523, 300);
            Console.Beep(523, 100);
            Console.Beep(523, 100);
            Console.Beep(523, 300);
            Console.Beep(523, 300);
            Console.Beep(523, 300);
            Console.Beep(494, 300);
            Console.Beep(440, 300);
            Console.Beep(415, 300);
            Console.Beep(440, 800);

        }
    }

}
