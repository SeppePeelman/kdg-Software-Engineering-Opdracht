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
  public partial class TurnView : UserControl
  {
    private TurnController controller;

    public TurnView(TurnController c)
    {
      InitializeComponent();
      controller = c;
    }

    public void UpdateUI()
    {
      string newTurn = controller.turnModel.Turn;
      TurnLabel.Text = newTurn;
    }

    private void TurnView_Load(object sender, EventArgs e)
    {

    }
  }
}

