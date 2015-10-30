using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class ScoreBoardController
    {
        ScoreBoardView view;
        public ScoreBoardModel model;

        public ScoreBoardController()
        {
            view = new ScoreBoardView(this);
            model = new ScoreBoardModel();
        }

        // return the view of scoreboardview
        public ScoreBoardView GetView()
        {
            return view;
        }

        public void CountSum()
        {
            view.CountSum();
        }

        public void CountOccurence()
        {
            view.CountOccurence();
        }
        
        public void HoldScore()
        {
            view.HoldScore();
        }

        public void CountTotalScore(int row)
        {
            view.CountTotalScore(row);
        }
    }
}
