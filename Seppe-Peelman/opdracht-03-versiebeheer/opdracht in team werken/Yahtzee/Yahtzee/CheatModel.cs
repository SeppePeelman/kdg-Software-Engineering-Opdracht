using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class CheatModel
    {
        private bool extraRollIsAvailable = true;
        private bool individualRollsIsAvailable = true;
        private int p1CheatPoints = 7;
        private int p2CheatPoints = 7;
        private int extraRollPrice = 2;
        private int individualRollsPrice = 5;

        public bool ExtraRollIsAvailable
        {
            get { return extraRollIsAvailable; }
            set { extraRollIsAvailable = value; }
        }

        public bool IndividualRollsIsAvailable
        {
            get { return individualRollsIsAvailable; }
            set { individualRollsIsAvailable = value; }
        }

        public int P1CheatPoints
        {
            get { return p1CheatPoints; }
            set { p1CheatPoints = value; }
        }

        public int P2CheatPoints
        {
            get { return p2CheatPoints; }
            set { p2CheatPoints = value; }
        }

        public int ExtraRollPrice
        {
            get { return extraRollPrice; }
            set { extraRollPrice = value; }
        }

        public int IndividualRollsPrice
        {
            get { return individualRollsPrice; }
            set { individualRollsPrice = value; }
        }
    }
}
