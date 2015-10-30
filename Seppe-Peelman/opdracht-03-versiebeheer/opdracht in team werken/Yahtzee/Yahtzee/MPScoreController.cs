using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
  public class MPScoreController
  {
    MPScoreView view;
    public MPScoreModel mpScoreModel = new MPScoreModel();

    public MPScoreController()
    {
      //maak nieuwe instantie aan van view
      view = new MPScoreView(this);
    }

    //methode die de view van teerling returnt
    public MPScoreView GetView()
    {
      return view;
    }

    public void NextGame()
    {
      mpScoreModel.GameNumber++;
    }

    public void UpdateScore()
    {
      //if (player1.totalscore > player2.totalscore)
      //{
          view.UpdateScoreP1Win();
          mpScoreModel.P1Score++;
      //}
      //else
      //{
          view.UpdateScoreP2Win();
          mpScoreModel.P2Score++;
      //}
      if (mpScoreModel.P1Score == mpScoreModel.MaxScore)
      {
        //P1Wins
      }
      if (mpScoreModel.P2Score == mpScoreModel.MaxScore)
      {
        //P2Wins
      }
      NextGame();
    }
  }
}
