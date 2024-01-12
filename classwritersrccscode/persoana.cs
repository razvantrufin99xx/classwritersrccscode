using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwritersrccscode
{

    public class persoana
    {
        public int cod = 1;
        public string name = "numele";
        public string prenume = "prenumele";
        public float numericf = 1.0f;
        public double numericd = 19090329032;
        public bool isEmpty = true;
        public bool IsNotEmpty = false;

        public persoana()
        {
        }


        public persoana(
         int pcod,
         string pname,
         string pprenume,
         float pnumericf,
         double pnumericd,
         bool pisEmpty,
         bool pIsNotEmpty
        )
        {
            this.cod = pcod;
            this.name = pname;
            this.prenume = pprenume;
            this.numericf = pnumericf;
            this.numericd = pnumericd;
            this.isEmpty = pisEmpty;
            this.IsNotEmpty = pIsNotEmpty;
        }

    }

}

