using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
  public partial class ScoreView : UserControl
  {

    private ScoreController controller;

    public ScoreView(ScoreController c)
    {
      InitializeComponent();
      controller = c;
    }

    public void UpdateUI()
    {
      int newHiScore = controller.scoreModel.HiScore;
      HighScoreLabel.Text = newHiScore.ToString();

      int newScore = controller.scoreModel.CurrentScore;
      ScoreLabel.Text = newScore.ToString();
    }

    private void ScoreView_Load(object sender, EventArgs e)
    {

    }
    









    private void ScoreLabel_Click(object sender, EventArgs e)
    {

    }
  }
}
