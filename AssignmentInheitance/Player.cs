using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInheitance
{
    class Player
    {
        protected string Name;
        protected string TeamName;
        protected int NoofMatches;
        public Player(string n, string Tn, int NoofMat)
        {
            this.Name = n;
            this.TeamName = Tn;
            this.NoofMatches = NoofMat;
        }
        public abstract void DisplayPlayerStatistics();

        class CricketPlayer : Player
        {
            protected int TotalRunsScored;
            protected int NoofWicketsTaken;
            public CricketPlayer(int TRS, int NWT)
            {
                this.TotalRunsScored = TRS;
                this.NoofWicketsTaken = NWT;
            }
            public override void DisplayPlayerStatistics()
            {
                //throw new NotImplementedException();
            }
        }

        class HockeyPlayer : Player
        {
            protected int NoofGoals;
            protected string Position;
            public HockeyPlayer(int NG, string Pos)
            {
                this.NoofGoals = NG;
                this.Position = Pos;
            }
            public override void DisplayPlayerStatistics()
            {
                //throw new NotImplementedException();
            }
        }
    }
}

