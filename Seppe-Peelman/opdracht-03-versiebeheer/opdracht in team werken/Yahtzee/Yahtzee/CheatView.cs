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
    public partial class CheatView : UserControl
    {
        private CheatController controller;

        public CheatView(CheatController c)
        {
            InitializeComponent();

            controller = c;

            UpdateUI();
            Extra_Roll_btn.Text = "Extra Roll ( " + controller.cheatModel.ExtraRollPrice + " )";
            Individual_Roll_btn.Text = "Individual Roll ( " + controller.cheatModel.IndividualRollsPrice + " )";
    }

        private void Extra_Roll_btn_Click(object sender, EventArgs e)
        {
            CheckAvailable();

            if (controller.cheatModel.ExtraRollIsAvailable)
            {
                Yahtzee.maxAantalWorpen++;

                if (controller.P1Turn())
                {
                    controller.cheatModel.P1CheatPoints -= controller.cheatModel.ExtraRollPrice;
                }
                else
                {
                    controller.cheatModel.P2CheatPoints -= controller.cheatModel.ExtraRollPrice;
                }

                UpdateUI();
            }
        }

        private void Individual_Roll_btn_Click(object sender, EventArgs e)
        {
            if (controller.cheatModel.IndividualRollsIsAvailable)
            {
                for (int i = 0; i < Yahtzee.aantalTeerlingen; i++)
                {
                    Yahtzee.teerlingController.teerlingModel.Teerlingen[i].ShowWerpBtn();
                }

                if (controller.P1Turn())
                {
                    controller.cheatModel.P1CheatPoints -= controller.cheatModel.IndividualRollsPrice;
                }
                else
                {
                    controller.cheatModel.P2CheatPoints -= controller.cheatModel.IndividualRollsPrice;
                }

                UpdateUI();
            }
        }

        private void Amount_Cheat_Points_P1_Click(object sender, EventArgs e)
        {

        }

        private void Amount_Cheat_Points_P2_Click(object sender, EventArgs e)
        {

        }

        public void CheckAvailable()
        {
            if (controller.P1Turn())
            {
                if (controller.cheatModel.P1CheatPoints >= controller.cheatModel.ExtraRollPrice)
                {
                    controller.cheatModel.ExtraRollIsAvailable = true;
                }
                else
                {
                    controller.cheatModel.ExtraRollIsAvailable = false;
                }

                if (controller.cheatModel.P1CheatPoints >= controller.cheatModel.IndividualRollsPrice)
                {
                    controller.cheatModel.IndividualRollsIsAvailable = true;
                }
                else
                {
                    controller.cheatModel.IndividualRollsIsAvailable = false;
                }
            }

            if (!controller.P1Turn())
            {
                if (controller.cheatModel.P2CheatPoints == controller.cheatModel.ExtraRollPrice)
                {
                    controller.cheatModel.ExtraRollIsAvailable = true;
                }
                else
                {
                    controller.cheatModel.ExtraRollIsAvailable = false;
                }

                if (controller.cheatModel.P2CheatPoints == controller.cheatModel.IndividualRollsPrice)
                {
                    controller.cheatModel.IndividualRollsIsAvailable = true;
                }
                else
                {
                    controller.cheatModel.IndividualRollsIsAvailable = false;
                }
            }
        }

        public void UpdateUI()
        {
            Amount_Cheat_Points_P1.Text = controller.cheatModel.P1CheatPoints.ToString();
            Amount_Cheat_Points_P2.Text = controller.cheatModel.P2CheatPoints.ToString();
        }

    private void CheatView_Load(object sender, EventArgs e)
    {

    }
  }
}
