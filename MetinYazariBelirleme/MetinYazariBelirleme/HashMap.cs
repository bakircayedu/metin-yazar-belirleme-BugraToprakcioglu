using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazariBelirleme
{
    public class HashMap
    {
        HashEntry[] table;
        public int size { get; set; }
        public HashMap(int tableSize)
        {
            size = tableSize;
            table = new HashEntry[tableSize];
            for (int i = 0; i < tableSize; i++)
            {
                table[i] = null;
            }
        }
        public object Arama(int key)
        {
            int hash = key % size;
            while (table[hash] != null && table[hash].anahtar != key)
            {
                hash = (hash + 1) % size;
            }
            if (table[hash] == null)
                return null;
            else
                return (object)table[hash].deger;
        }
        public void Ekleme(int key, object value)
        {
            int hash = (key % size);
            while (table[hash] != null && table[hash].anahtar != key)
            {
                hash = (hash + 1) % size;
            }
            table[hash] = new HashEntry(key, value);
        }
    }
}

