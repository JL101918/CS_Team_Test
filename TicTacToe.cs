using System;
using System.Runtime.InteropServices.Marshalling;

namespace ProjectLearn
{
    public static class Fourthcode
    {
        private static string[] tiles = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};

        private static int PlayerTurn = 2;

        public static void TicTacToe()
        {
        
        while (PlayerTurn > 0)
            {if (PlayerTurn % 2 == 0)
            {
                Board();
                Console.WriteLine("Player 1 pick a spot on the board to play");
                string player1 = Console.ReadLine();
                int player1Index = 0;

                while (true)
                {
                    if (!int.TryParse(player1, out player1Index) || player1Index < 1 || player1Index > 9)
                    {
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 9.");
                        player1 = Console.ReadLine();
                        continue;
                    }

                    if (tiles[player1Index] == "X" || tiles[player1Index] == "O")
                    {
                        Console.WriteLine("This spot is already chosen. Please try again");
                        player1 = Console.ReadLine();
                        continue;
                    }

                    break;
                }
                tiles[player1Index] = "X";
            }
            else
            {
                Board();
                Console.WriteLine("Player 2 pick a spot on the board to play");
                string player2 = Console.ReadLine();
                int player2Index = 0;

                while (true)
                {
                    if (!int.TryParse(player2, out player2Index) || player2Index < 1 || player2Index > 9)
                    {
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 9.");
                        player2 = Console.ReadLine();
                        continue;
                    }

                    if (tiles[player2Index] == "X" || tiles[player2Index] == "O")
                    {
                        Console.WriteLine("This spot is already chosen. Please try again");
                        player2 = Console.ReadLine();
                        continue;
                    }

                    break;
                }
                tiles[player2Index] = "O";
            }
            CheckWin();
            PlayerTurn++;
            continue;
            }
        }
        private static void Board()
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine($" {tiles[1]} | {tiles[2]} | {tiles[3]} ");
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine($" {tiles[4]} | {tiles[5]} | {tiles[6]} ");
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine($" {tiles[7]} | {tiles[8]} | {tiles[9]} ");
            Console.WriteLine("   |   |   ");        
        }
        private static void CheckWin()
        {
            // Makes it so Player altenates between 1 and 2 to show who won
            int Player = (PlayerTurn % 2) + 1;
            // Win in rows
            if ((tiles[1] == tiles[2]) && (tiles[2] == tiles[3]))
            {
                Console.WriteLine($"Player {Player} have won the game!");
                System.Environment.Exit(0);
            }
            if ((tiles[4] == tiles[5]) && (tiles[5] == tiles[6]))
            {
                Console.WriteLine($"Player {Player} have won the game!");
                System.Environment.Exit(0);
            }
            if ((tiles[7] == tiles[8]) && (tiles[8] == tiles[9]))
            {
                Console.WriteLine($"Player {Player} have won the game!");
                System.Environment.Exit(0);
            }
            // Win in columns
            if ((tiles[1] == tiles[4]) && (tiles[4] == tiles[7]))
            {
                Console.WriteLine($"Player {Player} have won the game!");
                System.Environment.Exit(0);
            }
            if ((tiles[2] == tiles[5]) && (tiles[5] == tiles[8]))
            {
                Console.WriteLine($"Player {Player} have won the game!");
                System.Environment.Exit(0);
            }
            if ((tiles[3] == tiles[6]) && (tiles[6] == tiles[9]))
            {
                Console.WriteLine($"Player {Player} have won the game!");
                System.Environment.Exit(0);
            }
            // Win in diagonals                
            if ((tiles[1] == tiles[5]) && (tiles[5] == tiles[9]))
            {
                Console.WriteLine($"Player {Player} have won the game!");
                System.Environment.Exit(0);
            }
            if ((tiles[3] == tiles[5]) && (tiles[5] == tiles[7]))
            {
                Console.WriteLine($"Player {Player} have won the game!");
                System.Environment.Exit(0);
            }
            if ((tiles[1] != 1) && (tiles[2] != 2) && (tiles[3] != 3) && (tiles[4] != 4) && (tiles[5] != 5) && (tiles[6] != 6) && (tiles[7] != 7) && (tiles[8] != 8) && (tiles[9] != 9));
            {
                Console.WriteLine("Draw!");
                System.Environment.Exit(0);
            }
        }
    }
}