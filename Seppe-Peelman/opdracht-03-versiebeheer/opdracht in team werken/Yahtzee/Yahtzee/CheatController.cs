using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class CheatController
    {
        CheatView view;
        public CheatModel cheatModel = new CheatModel();

        public CheatController()
        {
            //maak nieuwe instantie aan van view
            view = new CheatView(this);
        }

        public CheatView GetView()
        {
            return view;
        }

        public bool P1Turn()
        {
            if (Yahtzee.turnController.turnModel.Turn == "P1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateUI()
        {
            view.UpdateUI();
        }
    }
}
