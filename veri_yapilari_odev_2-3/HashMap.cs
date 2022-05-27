using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veri_yapilari_odev_2_3
{
    public class HashMap
    {
        public linkedlist_HashNode[] table;
        public int tablesize;

        public HashMap(int size)
        {
            tablesize = size;
            table = new linkedlist_HashNode[tablesize];
            for (int i = 0; i < tablesize; i++)
            {
                table[i] = null;
            }
        }

        
        public void TabloyaEkle(int key)
        {
            linkedlist_HashNode frekansim = new linkedlist_HashNode(key);
            int hash_degeri = key % tablesize;
            if (table[hash_degeri] == null)
            {
                table[hash_degeri] = frekansim;
            }
            else
            {
                linkedlist_HashNode oldlast = table[hash_degeri];
                
                while (oldlast != null)
                {
                    if (oldlast.Next != null)
                    {
                        oldlast = oldlast.Next;

                    }
                    else
                    {

                        break;
                    }
                }
                oldlast.Next = frekansim;
            }



        }
    }
}
