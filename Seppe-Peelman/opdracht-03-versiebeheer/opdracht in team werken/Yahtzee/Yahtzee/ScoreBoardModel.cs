using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class ScoreBoardModel
    {
        private int totalScore;
        private int currentScore;

        public int TotalScore
        {
            get { return totalScore; }
            set { totalScore = value; }
        }

        public int CurrentScore {
            get { return currentScore; }
            set { currentScore = value; }
        }
    }
}
