using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veri_yapilari_odev_2_3
{
    public class bagliListeNode
    {
        public Kelime Data;
        public bagliListeNode Next;

        public bagliListeNode(Kelime data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
}
