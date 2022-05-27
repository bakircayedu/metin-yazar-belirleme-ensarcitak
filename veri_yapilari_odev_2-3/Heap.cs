using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veri_yapilari_odev_2_3
{
    public class Heap
    {
        public HeapDugumu[] heapdizisi;
        private int maksboyut;
        public int simdikiboyut;

        public Heap(int maxheapsize)
        {
            maksboyut = maxheapsize;
            simdikiboyut = 0;
            heapdizisi = new HeapDugumu[maksboyut];
        }

        public bool IsEmpty()
        {
            return simdikiboyut == 0 ? true : false;
        }

        public bool Insert(Kelime klm)
        {
            if (simdikiboyut == maksboyut)
                return false;
            HeapDugumu heapDugumu = new HeapDugumu(klm);
            heapdizisi[simdikiboyut] = heapDugumu;
            MoveToUp(simdikiboyut++);
            return true;
        }

        public void MoveToUp(int indeks)
        {
            int ebeveyn = (indeks - 1) / 2;
            HeapDugumu bottom = heapdizisi[indeks];
            while(indeks > 0 && heapdizisi[ebeveyn].kelime.frekans < bottom.kelime.frekans)
            {
                heapdizisi[indeks] = heapdizisi[ebeveyn];
                indeks = ebeveyn;
                ebeveyn = (ebeveyn - 1) / 2;
            }
            heapdizisi[indeks] = bottom;
        }

        public void MoveToDown(int indeks)
        {
            int dahaBuyukCocuk;
            HeapDugumu top = heapdizisi[indeks];
            while(indeks < simdikiboyut / 2)
            {
                int solcocuk = 2 * indeks + 1;
                int sagcocuk = solcocuk + 1;

                if (sagcocuk < simdikiboyut && heapdizisi[solcocuk].kelime.frekans < heapdizisi[sagcocuk].kelime.frekans)
                    dahaBuyukCocuk = sagcocuk;
                else
                    dahaBuyukCocuk = solcocuk;
                if (top.kelime.frekans >= heapdizisi[dahaBuyukCocuk].kelime.frekans)
                    break;
                heapdizisi[indeks] = heapdizisi[dahaBuyukCocuk];
                indeks = dahaBuyukCocuk;
            }
            heapdizisi[indeks] = top;
        }

        public HeapDugumu RemoveMax()
        {
            HeapDugumu kok = heapdizisi[0];
            heapdizisi[0] = heapdizisi[--simdikiboyut];
            MoveToDown(0);
            return kok;
        }

    }
}
