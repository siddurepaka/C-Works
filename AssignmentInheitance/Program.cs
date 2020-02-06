using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInheitance
{
    class Program
    {
        static void Main(string[] args)
        {
           // CricketPlayer c = new CricketPlayer();
           // HockeyPlayer h = new HockeyPlayer();
            Console.WriteLine("Menu \n  1.Cricket PLayer DEtails\n  2.Hockey Details "\n "enter Choice");
            int ch = int.Parse(Console.ReadLine());
            if (ch == 1)
            {
              
            Console.WriteLine("Enter Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter TeamName:");
            string TeamName = Console.ReadLine();
            Console.WriteLine("No.of Matches Played");
            int NoofMatches = int.Parse(Console.ReadLine());
                Console.WriteLine("Noof TotalRunsScored");
                int TotalRunsScored = int.Parse(Console.ReadLine());
                Console.WriteLine("Noof WicketsTaken");
                int WicketsTaken = int.Parse(Console.ReadLine());
                CricketPlayer c = new CricketPlayer(Name,TeamName,NoofMatches,TotalRunsScored,WicketsTaken);
                c.DisplayPlayerStatistics();
                
        }
    else if(ch==2)
            {
                Console.WriteLine("Enter Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter TeamName:");
                string TeamName = Console.ReadLine();
                Console.WriteLine("No.of Matches Played");
                int NoofMatches = int.Parse(Console.ReadLine());
                Console.WriteLine("Position");
                int Position = int.Parse(Console.ReadLine());
                Console.WriteLine("NoofGoals");
                int NoofGoals = int.Parse(Console.ReadLine());
                HockeyPlayer c = new CricketPlayer(Name, TeamName, NoofMatches, Position,NoofGoals);
                h.DisplayPlayerStatistics();
                Console.WriteLine();
            }



}
