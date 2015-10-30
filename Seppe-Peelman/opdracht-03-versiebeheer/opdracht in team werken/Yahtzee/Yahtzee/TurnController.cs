using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
  public class TurnController
  {
    TurnView view;
    public TurnModel turnModel = new TurnModel();

    public TurnController()
    {
      //maak nieuwe instantie aan van view
      view = new TurnView(this);

    }

    //methode die de view van teerling returnt
    public TurnView GetView()
    {
      return view;
    }

    public void UpdateTurn()
    {
      //scoreModel.CurrentScore = 

      if (turnModel.Turn == "P1")
      {
        turnModel.Turn = "P2";
      }
      else
      {
        turnModel.Turn = "P1";
      }
    }

    public void UpdateUI()
    {
      view.UpdateUI();
    }
  }
}
