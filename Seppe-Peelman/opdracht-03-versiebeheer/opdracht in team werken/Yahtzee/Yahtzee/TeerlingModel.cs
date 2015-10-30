using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
  public class TeerlingModel
  {
    private int aantalOgen;
    private List<TeerlingController> teerlingen = new List<TeerlingController>();

    public int AantalOgen
    {
      get
      { return aantalOgen; }
      set
      { aantalOgen = value; }
    }

        public List<TeerlingController> Teerlingen {
            get { return teerlingen; }
            set { teerlingen = value; }
        }


    }
}
