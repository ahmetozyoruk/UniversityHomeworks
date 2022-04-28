using System;
using System.Collections.Generic;

namespace PathAnimations.composite_pattern
{
    class Dal : Bilesen
    {
        protected List<Bilesen> _kume = new List<Bilesen>();
        
        public override void Ekle(Bilesen Bilesen)
        {
            this._kume.Add(Bilesen);
        }

        public override void Kaldir(Bilesen bilesen)
        {
            this._kume.Remove(bilesen);
        }

        
        public override string Islem()
        {
            int i = 0;
            string sonuc = "Dal(";

            foreach (Bilesen bilesen in this._kume)
            {
                sonuc += bilesen.Islem();
                if (i != this._kume.Count - 1)
                {
                    sonuc += "+";
                }
                i++;
            }
            
            return sonuc + ")";
        }
    }
}