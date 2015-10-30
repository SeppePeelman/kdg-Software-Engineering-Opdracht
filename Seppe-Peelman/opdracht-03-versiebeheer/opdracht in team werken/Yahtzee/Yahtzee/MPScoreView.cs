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
  public partial class MPScoreView : UserControl
  {
    private MPScoreController controller;

    // Defining rows and cols for scoreboard
    const int ARRAYHEIGHT = 2;
    const int ARRAYLENGTH = 7;
        
    public MPScoreView(MPScoreController c)
    {
      InitializeComponent();
      controller = c;
    }

    Label[,] scoreLabels;

    private void MPScoreView_Load(object sender, EventArgs e)
    {
      scoreLabels = new Label[ARRAYHEIGHT, ARRAYLENGTH]
      {
          {P1G1, P1G2, P1G3, P1G4, P1G5, P1G6, P1G7 },
          { P2G1, P2G2, P2G3, P2G4, P2G5, P2G6, P2G7}
      };

      ShowBestOf(3);
    }
    
    public void ShowBestOf(int i)
    {
       for (int x = 0; x < ARRAYHEIGHT; x++)
       {
          for (int y = 0; y < i; y++)
              scoreLabels[x, y].Show();
       }

       for (int x = 0; x < ARRAYHEIGHT; x++)
       {
           for (int y = i; y < ARRAYLENGTH; y++)
               scoreLabels[x, y].Hide();
       }
    }

    private void bestOf3Radio_CheckedChanged(object sender, EventArgs e)
    {
      if ( bestOf3Radio.Checked )
      {
        ShowBestOf(3);
        controller.mpScoreModel.MaxScore = 2;
      }
    }

    private void bestOf5Radio_CheckedChanged(object sender, EventArgs e)
    {
      if (bestOf5Radio.Checked)
      {
        ShowBestOf(5);
        controller.mpScoreModel.MaxScore = 3;
      }
    }

    private void bestOf7Radio_CheckedChanged(object sender, EventArgs e)
    {
      if (bestOf7Radio.Checked)
      {
        ShowBestOf(7);
        controller.mpScoreModel.MaxScore = 4;
      }
    }

    public void UpdateScoreP1Win()
    {
            scoreLabels[0, controller.mpScoreModel.GameNumber].Text = "1";
            scoreLabels[1, controller.mpScoreModel.GameNumber].Text = "0";
      //P1Labels[controller.mpScoreModel.GameNumber].Text = "1";
      //P2Labels[controller.mpScoreModel.GameNumber].Text = "0";
    }
    public void UpdateScoreP2Win()
    {
            scoreLabels[0, controller.mpScoreModel.GameNumber].Text = "0";
            scoreLabels[1, controller.mpScoreModel.GameNumber].Text = "1";
      //P1Labels[controller.mpScoreModel.GameNumber].Text = "0";
      //P2Labels[controller.mpScoreModel.GameNumber].Text = "1";
    }
  }
}
