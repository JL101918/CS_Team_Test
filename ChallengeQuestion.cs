using System;
using System.Formats.Asn1;

namespace Question
{
    class League
    {
        static void Main(string[] args)
        {
            string [] TeamNames = {"Xanadu", "Blerp", "Meticulous-Mike", "USA"};
            int [,] TeamPoints = //2D array! :D
            {
                {3,2,1},
                {0,1,2},
                {0,1,0},
                {2,1,1}
            };
            int LeagueSize = 4;
            int MatchNo = 12;
            int [,] NumOfStyle = new int[4,4];
            int [] tot = new int[4];
            int Max = System.Math.Max(Math.Max(Math.Max(tot[0], tot[1]), tot[2]), tot[3]);
            int Min = System.Math.Min(Math.Min(Math.Min(tot[0], tot[1]), tot[2]), tot[3]); //Simplify repeating parts for optimization and simplicity
            for (int j = 0; j < 4; j++) //rows
            {
                tot[j] = TeamPoints[j, 0] + TeamPoints[j, 1] + TeamPoints[j, 2]; //calcuates the team points for each team
                for (int x = 0; x < 3; x++) //columns
                {
                    if (TeamPoints[j,x] == 0) //you get the idea, each row for each team, documents amount of 0s 1s 2s or 3s.
                    {
                        NumOfStyle[j,0]++;
                    }
                    else if (TeamPoints[j,x] == 1)
                    {
                        NumOfStyle[j,1]++;
                    }
                    else if (TeamPoints[j,x] == 2)
                    {
                        NumOfStyle[j,2]++;
                    }
                    else if (TeamPoints[j,x] == 3)
                    {
                        NumOfStyle[j,3]++;
                    }
                }
            }
            for (int i = 0; i < 4; i++) //the repetition part for each team
            {    
                Console.WriteLine(TeamNames[i]);
                Console.WriteLine($"Total Score: {Convert.ToString(tot[i])}");
                Console.WriteLine($"Lost Matches: {NumOfStyle[i,0]} Drawn Matches: {NumOfStyle[i,1]} Home Wins: {NumOfStyle[i,2]} Away Wins: {NumOfStyle[i,3]}");

                 
                /*learned two things
            1. Max and Min only takes groups of 2, 2. If I dont specify Math.Max for each bracket it turns into byte? idk. */
            }
            for (int z = 0; z < 4; z++)
            {
                if (tot[z] == Max)
                {
                    Console.WriteLine($"{TeamNames[z]} is the highest scoring team with a total points collection of {Max}"); //I hate this part with all my passion and heart
                }
                else if (tot[z] == Min)
                {
                    Console.WriteLine($"{TeamNames[z]} is the lowest scoring team with a total points collection of {Min}"); //It took me WAY too long to figure this part out :/
                }
                else
                {
                    continue;
                }
            }
        }   
    }
}