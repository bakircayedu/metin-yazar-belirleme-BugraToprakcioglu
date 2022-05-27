using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme
{
    public class Node
    {
        public string Deger;
        public Node Next;
        public int kelimeSayisi;
        public string process;
        public int frekans = 1;

        public Node()
        {

        }
        public Node(string deger,int kelime)
        {
           Deger = deger;
            Next = null;
            kelimeSayisi = kelime; 
            kelimeSayisi = kelime; 
            
        }
        public Node(string deger,int kelime,string process)
        {
            Deger=deger;
            kelimeSayisi=kelime;
            this.process = process;
            this.Next = null;
        }
        

    }
}
