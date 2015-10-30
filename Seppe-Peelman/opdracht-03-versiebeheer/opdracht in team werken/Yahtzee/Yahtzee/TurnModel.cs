using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
  public class TurnModel
  {
    private string turn = "P1";

    public string Turn
    {
      get
      {
        return turn;
      }
      set
      {
        turn = value;
      }
    }
  }
}
