using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme
{
    public class HashEntry
    {
        public int anahtar { get; set; }
        public object deger { get; set; }
        public HashEntry(int anahtar, object deger)
        {
            this.anahtar = anahtar;
            this.deger = deger;
        }
    }
}
