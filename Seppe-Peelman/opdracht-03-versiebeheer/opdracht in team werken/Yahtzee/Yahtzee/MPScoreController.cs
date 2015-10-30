using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    public void UpdateScore(string player)
    {
      if (player == "P1")
      {
          view.UpdateScoreP1Win();
          mpScoreModel.P1Score++;
      }
      else
      {
          view.UpdateScoreP2Win();
          mpScoreModel.P2Score++;
      }
      if (mpScoreModel.P1Score == mpScoreModel.MaxScore)
      {
        //P1Wins
        MessageBox.Show("P1 Wins the game!");
        Application.Restart();
      }
      if (mpScoreModel.P2Score == mpScoreModel.MaxScore)
      {
        //P2Wins
        MessageBox.Show("P2 Wins the game!");
        Application.Restart();
      }
      NextGame();
    }
  }
}
