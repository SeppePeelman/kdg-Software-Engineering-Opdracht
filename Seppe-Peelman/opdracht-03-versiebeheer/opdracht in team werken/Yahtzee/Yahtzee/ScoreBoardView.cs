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
    public partial class ScoreBoardView : UserControl
    {
        #region Variables 
        // Make a instance of the scoreboardcontroller
        private ScoreBoardController scoreBoardController;
        
        // Give the array a constant length and height
        const int ARRAYROWS = 2;
        const int ARRAYCOLS = 16;

        // Array containing all the score labels
        Label[,] pointsLabels;
        #endregion

        // Constructor
        public ScoreBoardView(ScoreBoardController c)
        {
            InitializeComponent();
            scoreBoardController = c;
        }

        private void ScoreBoardView_Load(object sender, EventArgs e)
        {
            // Putting the labels into the array
            pointsLabels = new Label[ARRAYROWS, ARRAYCOLS]
            {
                { P1ON, P1TW, P1TH, P1FO, P1FI, P1SI, P1SU, P1BO, P1THOAK, P1FOOAK, P1FH, P1SS, P1LS, P1C, P1Y, P1TS },
                { P2ON, P2TW, P2TH, P2FO, P2FI, P2SI, P2SU, P2BO, P2THOAK, P1FOOAK, P1FH, P2SS, P2LS, P2C, P2Y, P2TS }
            };  
        }

        public void CountSum()
        {
            int row = 0;

            if (Yahtzee.turnController.turnModel.Turn == "P2")
                row = 1;

             foreach(TeerlingController c in Yahtzee.teerlingController.teerlingModel.Teerlingen)
            {
                switch (c.teerlingModel.AantalOgen)
                {
                    case 1:
                        AddScoreToLabel(row, 0, c.teerlingModel.AantalOgen);
                        break;
                    case 2:
                        AddScoreToLabel(row, 1, c.teerlingModel.AantalOgen);
                        break;
                    case 3:
                        AddScoreToLabel(row, 2, c.teerlingModel.AantalOgen);
                        break;
                    case 4:
                        AddScoreToLabel(row, 3, c.teerlingModel.AantalOgen);
                        break;
                    case 5:
                        AddScoreToLabel(row, 4, c.teerlingModel.AantalOgen);
                        break;
                    case 6:
                        AddScoreToLabel(row, 5, c.teerlingModel.AantalOgen);
                        break;
                    default:
                        break;
                }
            }  
        }

        internal void AddScoreToLabel(int row, int col, int c)
        {
            pointsLabels[row, col].Text = (Convert.ToInt32(pointsLabels[row, 0].Text) + c).ToString();
        }
    }
}
