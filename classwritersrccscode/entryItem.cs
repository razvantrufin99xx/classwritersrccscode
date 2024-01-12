using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwritersrccscode
{
    public class entryItem
    {
        public string id;
        public string memoryaccesstype;
        public string datatype;
        public string identificator;
        public string defaultvalue;
        public int length;

        public entryItem() { }

        public entryItem(
            string pid, 
            string pmemoryaccesstype, 
            string pdatatype,
            string pidentificator, 
            string pdefaultvalue, 
            int plength
            )
        { 
            this.id = pid;
            this.memoryaccesstype = pmemoryaccesstype;
            this.datatype = pdatatype;
            this.identificator = pidentificator;
            this.defaultvalue = pdefaultvalue;
            this.length = plength;

        }
        public string writeItem()
        {
            string s = "";
            s += this.memoryaccesstype;
            s += " " + this.datatype;
            s += " " + this.identificator;
            if(this.defaultvalue != null ) { s += "=" + this.defaultvalue;  }
            s += " ;";
            return s;
        }
        public string writeItemAsParam()
        {
            string s = "";
          
            s += " " + this.datatype;
            s += " " + this.identificator;
           
            s += " ,";
            return s;
        }
        public string writeItemAsCoInst()
        {
            string s = "";

           
            s +=this.identificator;

           
            return s;
        }
    }
}
