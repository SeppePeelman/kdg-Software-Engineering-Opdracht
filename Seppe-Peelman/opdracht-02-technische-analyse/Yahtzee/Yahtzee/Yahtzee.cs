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
    int aantalTeerlingen = 3;
    int maxAantalWorpen = 3;
    int aantalWorpen;
    List<TeerlingController> teerlingen = new List<TeerlingController>();
    ScoreController scoreController = new ScoreController();

    public Yahtzee()
    {
      InitializeComponent();
    }

    private void Yahtzee_Load(object sender, EventArgs e)
    {
      for (int i = 0; i < aantalTeerlingen; i++)
      {
        TeerlingController tijdelijkeTeerling = new TeerlingController();
        teerlingen.Add(tijdelijkeTeerling);

        TeerlingView tView = teerlingen[i].GetView();

        int horizontalPosition = i * tView.Width;
        tView.Location = new System.Drawing.Point(horizontalPosition, 0);
        Controls.Add(tView);
      }

      ScoreView sView = scoreController.GetView();

      int scoreHorizontalPosition = aantalTeerlingen * sView.Width;
      sView.Location = new System.Drawing.Point(scoreHorizontalPosition, 0);
      Controls.Add(sView);
    }

    private void AlgemeneWerpBtn_Click(object sender, EventArgs e)
    {
      if ( aantalWorpen < maxAantalWorpen )
      {
        for (int i = 0; i < aantalTeerlingen; i++)
        {
          teerlingen[i].Werp();
          teerlingen[i].UpdateUI();
          scoreController.scoreModel.CurrentScore += teerlingen[i].teerlingModel.AantalOgen;
        }
        aantalWorpen++;
      }
      scoreController.UpdateScore();
      scoreController.UpdateUI();
      scoreController.scoreModel.CurrentScore = 0;
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBox1.Checked)
      {
        for (int i = 0; i < aantalTeerlingen; i++)
        {
          teerlingen[i].ShowWerpBtn();
        }
      }
      else
      {
        for (int i = 0; i < aantalTeerlingen; i++)
        {
          teerlingen[i].HideWerpBtn();
        }
      }
    }

    private void RetryBtn_Click(object sender, EventArgs e)
    {
      aantalWorpen = 0;
      scoreController.scoreModel.CurrentScore = 0;
      for (int i = 0; i < aantalTeerlingen; i++)
      {
        teerlingen[i].ClearText();
      }
      scoreController.UpdateScore();
      scoreController.UpdateUI();
    }
  }
}
