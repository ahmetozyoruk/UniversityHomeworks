
using System;
using System.Collections;
using System.Collections.Generic;

namespace KeySplineAnimations.Iterator
{
    class AlfabetikSiraYenileyicisi : Yenileyici
    {
        private KelimeListesi _liste;
        
        private int pozisyon = -1;
        
        private bool tersmi = false;

        public AlfabetikSiraYenileyicisi(KelimeListesi liste, bool tersmi = false)
        {
            this._liste = liste;
            this.tersmi = tersmi;

            if (tersmi)
            {
                this.pozisyon = liste.GetirListeyi().Count;
            }
        }
        
        public override object Suanki()
        {
            return this._liste.GetirListeyi()[pozisyon];
        }

        public override int Anahtar()
        {
            return this.pozisyon;
        }
        
        public override bool MoveNext()
        {
            int updatedPosition = this.pozisyon + (this.tersmi ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this._liste.GetirListeyi().Count)
            {
                this.pozisyon = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public override void Reset()
        {
            this.pozisyon = this.tersmi ? this._liste.GetirListeyi().Count - 1 : 0;
        }
    }
}