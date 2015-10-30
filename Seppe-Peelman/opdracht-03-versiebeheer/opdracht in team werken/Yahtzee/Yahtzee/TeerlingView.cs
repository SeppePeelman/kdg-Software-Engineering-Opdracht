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
  public partial class TeerlingView : UserControl
  {
    private TeerlingController controller;
    private bool isOnHold = false;

    public TeerlingView(TeerlingController c)
    {
      InitializeComponent();
      controller = c;
      holdBtn.BackColor = SystemColors.Control;
      TeerlingLabel.BackColor = Color.White;
    }

    public bool IsOnHold
    {
      get { return isOnHold; }
      set { isOnHold = value; }
    }

    private void TeerlingView_Load(object sender, EventArgs e)
    {
      HideWerpBtn();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      controller.Werp();
      UpdateUI();
    }

    public void UpdateUI()
    {
      int nieuwAantalOgen = controller.teerlingModel.AantalOgen;
      switch (nieuwAantalOgen)
      {
        case 1:
          TeerlingLabel.Image = Image.FromFile("dice_1.gif");
          break;
        case 2:
          TeerlingLabel.Image = Image.FromFile("dice_2.gif");
          break;
        case 3:
          TeerlingLabel.Image = Image.FromFile("dice_3.gif");
          break;
        case 4:
          TeerlingLabel.Image = Image.FromFile("dice_4.gif");
          break;
        case 5:
          TeerlingLabel.Image = Image.FromFile("dice_5.gif");
          break;
        case 6:
          TeerlingLabel.Image = Image.FromFile("dice_6.gif");
          break;
      }
    }

    public void HideWerpBtn()
    {
      TeerlingWerpBtn.Hide();
    }
    public void ShowWerpBtn()
    {
      TeerlingWerpBtn.Show();
    }

    public void ClearImage()
    {
      TeerlingLabel.Image = null;
    }

    public void ResetHold()
    {
      holdBtn.BackColor = SystemColors.Control;
      isOnHold = false;
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      if(!isOnHold)
      {
        isOnHold = true;
        holdBtn.BackColor = Color.Red;
      }
      else if(isOnHold)
      {
        isOnHold = false;
        holdBtn.BackColor = SystemColors.Control;
      }
    }
  }
}
