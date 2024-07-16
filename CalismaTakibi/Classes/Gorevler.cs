using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalismaTakibi.Classes
{
    public class Gorevler
    {
        public int GorevID { get; set; }
        public string GorevCat { get; set; }    
        public string GorevName { get; set; }
        public float GorevDiff { get; set; }
        public override string ToString()
        {
            return GorevName;
        }
    }
}
