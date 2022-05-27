using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veri_yapilari_odev_2_3
{
    public interface IbagliListeTipliStack
    {
        bagliListeNode GetNode(Kelime data);
        void Push(Kelime data);
        object Peek();
        Kelime Pop();
        bool IsEmpty();


    }
}
