using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Yahtzee
{
  public class TeerlingController
  {
    private static int seed;

    //member die view opvangt
    TeerlingView view;
    public TeerlingModel teerlingModel = new TeerlingModel();

    public TeerlingController()
    {
      //maak nieuwe instantie aan van view
      view = new TeerlingView(this);
      
    }

    //methode die de view van teerling returnt
    public TeerlingView GetView()
    {
      return view;
    }

    public void Werp()
    {
      //vraagt aan model om aantal ogen te updaten
      Random random = new Random(seed);

      int aantalOgen = random.Next(1, 7);
      

      teerlingModel.AantalOgen = aantalOgen;
      Console.WriteLine(aantalOgen);
      seed += aantalOgen;
    }

    public void UpdateUI()
    {
      view.UpdateUI();
    }

    public void HideWerpBtn()
    {
      view.HideWerpBtn();
    }
    public void ShowWerpBtn()
    {
      view.ShowWerpBtn();
    }

    public void ClearText()
    {
      view.ClearText();
    }

  }
}
