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
            scoreBoardController.model.PointsLabels = new Label[ARRAYROWS, ARRAYCOLS]
            {
                { P1ON, P1TW, P1TH, P1FO, P1FI, P1SI, P1SU, P1BO, P1THOAK, P1FOOAK, P1FH, P1SS, P1LS, P1C, P1Y, P1TS },
                { P2ON, P2TW, P2TH, P2FO, P2FI, P2SI, P2SU, P2BO, P2THOAK, P1FOOAK, P1FH, P2SS, P2LS, P2C, P2Y, P2TS }
            };
        }

        // Add to each label it's current score
        public void CountSum()
        {
            int row = 0;

            if (Yahtzee.turnController.turnModel.Turn == "P2")
                row = 1;

            // Use a loop to iterate through the list of dice
            // put the scores into the labels 
            #region foreach loop: add the scores to the labels
            foreach (TeerlingController c in Yahtzee.teerlingController.teerlingModel.Teerlingen)
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
                #endregion
            }
        }

        internal void AddScoreToLabel(int row, int col, int c)
        {
            scoreBoardController.model.PointsLabels[row, col].Text = (Convert.ToInt32(scoreBoardController.model.PointsLabels[row, col].Text) + c).ToString();
        }

        // Count how much a number in the list of dice occurs
        // Used to get a three_of_a_kind, four_of_a_kind, YAHTZEE etc.
        public void CountOccurence()
        {
            int row = 0;

            if (Yahtzee.turnController.turnModel.Turn == "P2")
                row = 1;

            #region Unused Code
            // test to see if the list contains any elements of a specific number
            //MessageBox.Show(Yahtzee.teerlingController.teerlingModel.Teerlingen.Any(b => b.teerlingModel.AantalOgen == 3).ToString());
            #endregion

            var query = Yahtzee.teerlingController.teerlingModel.Teerlingen.GroupBy(r => r.teerlingModel.AantalOgen)
                .Select(grp => new
                {
                    Value = grp.Key,
                    Count = grp.Count()
                });

            foreach (var item in query)
            {
                //MessageBox.Show(item.Value.ToString() + " appears " + item.Count.ToString() + " time(s)!");
                switch (item.Count)
                {
                    // If value occurs three times: ThreeOfAKind
                    case 3:
                        AddScoreToLabel(row, 8, 25);
                        break;
                    // If value occurs four times: FourOfAKind
                    case 4:
                        AddScoreToLabel(row, 9, 25);
                        break;
                    // If a value occurs five times: YAHTZEE
                    case 5:
                        AddScoreToLabel(row, 9, 50);
                        break;
                }
                    
            }
        }

        #region Not used due to little time
        public void HoldScore()
        {
            foreach (Label l in scoreBoardController.model.PointsLabels)
            {
                l.Click += label_Click;
            }
        }
        
        // Method to set a score when clicking a label
        internal void label_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked " + ((Label)sender).Name);

            for (int a = 0; a < ARRAYCOLS; a++)
            {
                for (int b = 0; b < ARRAYROWS; b++)
                {
                    if(scoreBoardController.model.PointsLabels[b, a].Name == ((Label)sender).Name)
                    {
                        MessageBox.Show("[" + b.ToString() + "," + a.ToString() + "]");
                    }
                }
            }
        }
        #endregion

        // When the maximum amount of throws is reached, count the totalscore
        public void CountTotalScore(int row)
        { 
            int totalScore = 0;

            for (int i = 0; i < scoreBoardController.model.PointsLabels.GetLength(1); i++)
            {
                totalScore += Convert.ToInt32(scoreBoardController.model.PointsLabels[row, i].Text);
            }
            
            scoreBoardController.model.PointsLabels[row, 15].Text = totalScore.ToString();
        }
    }
}
