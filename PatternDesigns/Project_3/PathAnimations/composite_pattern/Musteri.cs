using System;
using System.Diagnostics;

namespace PathAnimations.composite_pattern
{
    class Musteri
    {

        public void IslemMusteri(Bilesen yaprak)
        {
            Trace.WriteLine($"RESULT: {yaprak.Islem()}\n");
        }


        public void IslemMusteri_2(Bilesen bilesen1, Bilesen bilesen2)
        {
            if (bilesen1.Dal_mi())
            {
                bilesen1.Ekle(bilesen2);
            }

            Trace.WriteLine($"RESULT: {bilesen1.Islem()}");
        }
    }
}