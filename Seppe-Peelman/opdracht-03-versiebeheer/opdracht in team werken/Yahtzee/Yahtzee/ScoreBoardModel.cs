using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public class ScoreBoardModel
    {
        private int totalScore;
        private int currentScore;
        private Label[,] pointsLabels;
        
        public int TotalScore
        {
            get { return totalScore; }
            set { totalScore = value; }
        }

        public int CurrentScore {
            get { return currentScore; }
            set { currentScore = value; }
        }

        public Label[,] PointsLabels
        {
            get { return pointsLabels; }
            set { pointsLabels = value; }
        }
    }
}
