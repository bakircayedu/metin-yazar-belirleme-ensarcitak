using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veri_yapilari_odev_2_3
{
    public class Yigin:IbagliListeTipliStack
    {
        public bagliListeNode top;
        public int elemansayisi;
        public Yigin()
        {
            top = null;
            elemansayisi = 0;
        }
        public bagliListeNode GetNode(Kelime data)
        {
            bagliListeNode dugum = new bagliListeNode(data);
            return dugum;

        }

        public void Push(Kelime data)
        {
            bagliListeNode yenidugum = GetNode(data);
            if (top == null)
            {
                top = yenidugum;
                elemansayisi++;
                return;
            }
            yenidugum.Next = top;
            top = yenidugum;
            elemansayisi++;
        }

        public object Peek()
        {
            if (top == null)
            {
                throw new Exception("Yığın boş...");
            }
            return top.Data;
        }
        public Kelime Pop()
        {
            Kelime kelime;
            if (top == null)
            {
                throw new Exception("yıgın boş");
            }
            kelime =top.Data;
            top = top.Next;
            elemansayisi--;
            return kelime;
        }
        public bool IsEmpty()
        {
            return top == null ? true : false;
        }
    }
}
