using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
  public class ScoreController
  {
    //member die view opvangt
    ScoreView view;
    public ScoreModel scoreModel = new ScoreModel();

    public ScoreController()
    {
      //maak nieuwe instantie aan van view
      view = new ScoreView(this);

    }

    //methode die de view van teerling returnt
    public ScoreView GetView()
    {
      return view;
    }

    public void UpdateScore()
    {
      //scoreModel.CurrentScore = 

      if(scoreModel.CurrentScore > scoreModel.HiScore)
      {
        scoreModel.HiScore = scoreModel.CurrentScore;
      }
    }

    public void UpdateUI()
    {
      view.UpdateUI();
    }
  }
}
