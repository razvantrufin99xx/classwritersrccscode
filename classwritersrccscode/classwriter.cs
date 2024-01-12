using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classwritersrccscode
{
    public class classwriter
    {
        public List<entryItem> entries = new List<entryItem>();
        public List<entryItem> internaldatas = new List<entryItem>();

        public string denumireofclasa;
        public string memoryaccestypeofclass;
        public bool writeContructor;
        public bool writeEmptyContructor;

        public classwriter()    {        }
        public classwriter(string denumire, string memacc, bool wc, bool wec )
        {
            this.denumireofclasa = denumire;
            this.memoryaccestypeofclass = memacc;
            this.writeContructor = wc;
            this.writeEmptyContructor = wec;
        }
        public string writeTheClass() 
        {
            string s="";
            s += "\r\n";
            s += this.memoryaccestypeofclass;
            s += " class " + this.denumireofclasa;
            s += "\r\n";
            s += "{";
            s += "\r\n";
            for (int i = 0; i < entries.Count; i++)
            {
                s += entries[i].writeItem();
                s += "\r\n";
            }
            s += "\r\n";
            if (this.writeEmptyContructor == true)
            {
                s += this.memoryaccestypeofclass; 
                s += " " + this.denumireofclasa + "( ) ";
                s += "\r\n";
                s += "{";
                s += "\r\n";
                s += "}";
                s += "\r\n";
            }

            s += "\r\n";


            s += "\r\n";
            if (this.writeEmptyContructor == true)
            {
                s += this.memoryaccestypeofclass;
                s += " " + this.denumireofclasa + "(";

            s += "\r\n";

            if (this.writeContructor == true)
            {
                for (int i = 0; i < entries.Count; i++)
                {
                    s += entries[i].writeItemAsParam();
                        if (i < entries.Count - 1) { s += " ,"; }
                        s += "\r\n";
                }

                }
             s+= ") ";
                s += "\r\n";
                s += "{";
                s += "\r\n";

                for (int i = 0; i < entries.Count; i++)
                {
                    s += "this." + entries[i].writeItemAsCoInst() + "=" + entries[i].writeItemAsCoInst() + ";";
                   
                    s += "\r\n";
                }

                s += "}";
                s += "\r\n";
            }

            s += "\r\n";
            s += "}";

            return s;
        }
    }
}
