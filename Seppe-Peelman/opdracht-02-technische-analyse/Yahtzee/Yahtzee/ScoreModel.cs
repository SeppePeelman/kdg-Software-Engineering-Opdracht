using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
  public class ScoreModel
  {
    private int currentScore;
    private int hiScore;

    public int CurrentScore
    {
      get
      {
        return currentScore;
      }
      set
      {
        currentScore = value;
      }
    }

    public int HiScore
    {
      get
      {
        return hiScore;
      }
      set
      {
        hiScore = value;
      }
    }

  }
}
