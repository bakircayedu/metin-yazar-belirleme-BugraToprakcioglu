using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme
{
    public class Stack
    {
        Node top;
        public int size = 0;
        public Stack()
        {
            top=null;
        }
        public void Push(string Data,int kelime)
        {
            Node dugum = new Node(Data,kelime);
            if(top==null)
                top = dugum;
            else
            {
                dugum.Next=top;
                top=dugum;
            }
            size++;
        }
        public void Push(string value,int kelime,bool benzersizKelime)//Unique kelimeler için push metodu..
        {
            string process = string.Empty;
            foreach (var harf in value)
            {
                if (Char.IsPunctuation(harf))
                {
                    break;
                }

                process += harf;

            }
            Node node = new Node(value, kelime, process);
            if (top == null)
            {
                top = node;
                size++;
                return;
            }
        
            Node kontrol=TekrarEdenKelimeBul(node);
            if (kontrol == null)
            {
                node.Next = top;
                top = node;
                size++;

            }
            else
            {
                FrekansSayaci(node);
            }

            
        }
       public Node Pop()
       {
            Node temp = new Node();
            if (top == null)
                throw new Exception("Stack Boş..");
            else
            {
                temp = top;
                top = top.Next;
                return temp;
            }

        }
        
        public string Peek()
        {
            return top.Deger;
        }
        public int Size()
        {
            return size;
        }

        public Node TekrarEdenKelimeBul(Node control)
        {
            Node temp = new Node();
            temp = top;
            while (temp.Next != null)
            {
                if (String.Equals(temp.process, control.process))
                {

                    return temp;

                }

                temp = temp.Next;

            }
            if (String.Equals(temp.process, control.process))
            {

                return temp;

            }
            return null;
        }

        public int FrekansSayaci(Node node)
        {
            Node onceki = new Node();
            onceki = top;
            while (onceki.Next != null)
            {
                if (String.Equals(onceki.Next.process, node.process))//True Dönerse Frekans Artıyor
                {
                    int frekanskelime = onceki.Next.frekans;
                    onceki.Next.frekans = ++frekanskelime;
                }
                onceki = onceki.Next;
            }
            return onceki.frekans;

        }
        public string cumleYazdir()
        {
            Node temp = new Node(null, 0);
            temp = top;
            string cumle = "";
            while (temp.Next != null)
            {
                if(temp.kelimeSayisi!=0)
                    cumle += temp.Deger+"-->"+temp.kelimeSayisi + Environment.NewLine;

                temp = temp.Next;
            }
            cumle += temp.Deger +"-->"+temp.kelimeSayisi + Environment.NewLine;
            return cumle;

        }
        public string frekansYazdir()
        {

            Node temp = new Node(null, 0);
            temp = top;

            string frekans = "";
            
            while (temp.Next != null)
            {
                temp.frekans = FrekansSayaci(temp);
                frekans += temp.Deger+ " kelimesinin frekansı=" + temp.frekans + Environment.NewLine;
                temp = temp.Next;
                
            }
            return frekans;
        }
        public string KelimeYazdir()
        {
            Node temp = new Node(null, 0);
            temp = top;
            string kelime = "";
            while (temp.Next != null)
            {
               
                kelime += temp.Deger + Environment.NewLine;
                temp = temp.Next;

            }
            return kelime;

        }

    }
}
