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
        public string prenume ="prenumele";

        public persoana()
        {
        }


        public persoana(
         int cod,
         string name,
         string prenume
        )
        {
            this.cod = cod;
            this.name = name;
            this.prenume = prenume;
        }

    }
}

