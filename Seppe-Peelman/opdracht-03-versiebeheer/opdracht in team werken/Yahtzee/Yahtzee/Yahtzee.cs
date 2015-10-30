using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Yahtzee
{
  public partial class Yahtzee : Form
  {
    public static int aantalTeerlingen = 5;
    public static int maxAantalWorpen = 3;
    int aantalWorpen;
    //List<TeerlingController> teerlingen = new List<TeerlingController>();
    public static TeerlingController teerlingController = new TeerlingController();
    public static TurnController turnController = new TurnController();
    MPScoreController mpScoreController = new MPScoreController();
    CheatController cheatController = new CheatController();
    string throwsText = "Throws: ";
    
    // Make an instance of the scoreboardcontroller to get the view into YATHZEE
    ScoreBoardController scoreBoardController = new ScoreBoardController();

    public Yahtzee()
    {
      InitializeComponent();
    }

    private void Yahtzee_Load(object sender, EventArgs e)
    {

      // Make instances of the dice
      for (int i = 0; i < aantalTeerlingen; i++)
      {
        TeerlingController tijdelijkeTeerling = new TeerlingController();
        teerlingController.teerlingModel.Teerlingen.Add(tijdelijkeTeerling);

        TeerlingView tView = teerlingController.teerlingModel.Teerlingen[i].GetView();
                
        int horizontalPosition = i * tView.Width;
        tView.Location = new Point(horizontalPosition, 0);
        Controls.Add(tView);

        ThrowsLabel.Text = throwsText + aantalWorpen + "/" + maxAantalWorpen;
      }

     
      TurnView turnView = turnController.GetView();
      ScoreBoardView sBView = scoreBoardController.GetView();

      int turnVerticalPosition = turnView.Height + 100;
      turnView.Location = new Point(1, sBView.Height + 280);
      Controls.Add(turnView);

      MPScoreView mpScoreView = mpScoreController.GetView();
      int mpScoreHorizontalPosition = turnView.Width;
      mpScoreView.Location = new Point(mpScoreHorizontalPosition, sBView.Height + 274);
      Controls.Add(mpScoreView);

      int scoreBoardHP = sBView.Width;
      sBView.Location = new Point(1, turnVerticalPosition - 6); 
      Controls.Add(sBView);

      CheatView cheatView = cheatController.GetView();
      int cheatHorizontalPosition = turnView.Width * 4;
      cheatView.Location = new Point(cheatHorizontalPosition-50, turnVerticalPosition +166);
      Controls.Add(cheatView);

    }

    private void UpdateThrowLabel()
    {
      ThrowsLabel.Text = throwsText + aantalWorpen + "/" + maxAantalWorpen;
    }

    private void AlgemeneWerpBtn_Click(object sender, EventArgs e)
    {
      if ( aantalWorpen < maxAantalWorpen )
      {
        for (int i = 0; i < aantalTeerlingen; i++)
        {
          teerlingController.teerlingModel.Teerlingen[i].Werp();
          teerlingController.teerlingModel.Teerlingen[i].UpdateUI();
                    //scoreController.scoreModel.CurrentScore += teerlingen[i].teerlingModel.AantalOgen;
        }
        aantalWorpen++;
        scoreBoardController.view.CountSum();
            }
      UpdateThrowLabel();
            //scoreController.UpdateScore();
            //scoreController.UpdateUI();
            //scoreController.scoreModel.CurrentScore = 0;
            
        }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void RetryBtn_Click(object sender, EventArgs e)
    {
      if (turnController.turnModel.Turn == "P1")
      {
          cheatController.cheatModel.P1CheatPoints++;
      }
      else
      {
          cheatController.cheatModel.P2CheatPoints++;
      }
      turnController.UpdateTurn();
      turnController.UpdateUI();
      aantalWorpen = 0;
      //scoreController.scoreModel.CurrentScore = 0;
      UpdateThrowLabel();
      for (int i = 0; i < aantalTeerlingen; i++)
      {
         teerlingController.teerlingModel.Teerlingen[i].ClearImage();
         teerlingController.teerlingModel.Teerlingen[i].ResetHold();
        teerlingController.teerlingModel.Teerlingen[i].HideWerpBtn();
      }

      cheatController.UpdateUI();
      maxAantalWorpen = 3;
      UpdateThrowLabel();
    }
  }
}
