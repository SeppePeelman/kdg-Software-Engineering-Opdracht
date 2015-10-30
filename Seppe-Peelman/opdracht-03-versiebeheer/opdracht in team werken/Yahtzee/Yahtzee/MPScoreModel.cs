using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
  public class MPScoreModel
  {
    private int gameNumber = 1;
    private int p1Score = 0;
    private int p2Score = 0;
    private int maxScore = 2;

    public int GameNumber
    {
      get
      {
        return gameNumber;
      }
      set
      {
        gameNumber = value;
      }
    }

    public int P1Score
    {
      get
      {
        return p1Score;
      }
      set
      {
        p1Score = value;
      }
    }

    public int P2Score
    {
      get
      {
        return p2Score;
      }
      set
      {
        p2Score = value;
      }
    }

    public int MaxScore
    {
      get
      {
        return maxScore;
      }
      set
      {
        maxScore = value;
      }
    }
  }
}
