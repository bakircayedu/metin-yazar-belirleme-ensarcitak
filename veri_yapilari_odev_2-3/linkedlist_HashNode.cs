using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veri_yapilari_odev_2_3
{
    public class linkedlist_HashNode
    {
        public int Key { get; set; }
        public linkedlist_HashNode Next { get; set; }

        public linkedlist_HashNode(int key)
        {
            this.Key = key;
            Next = null;
        }
    }
}
