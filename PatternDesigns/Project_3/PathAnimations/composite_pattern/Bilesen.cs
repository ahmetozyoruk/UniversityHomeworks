using System;

namespace PathAnimations.composite_pattern
{
    abstract class Bilesen
    {
        public Bilesen() { }


        public abstract string Islem();


        public virtual void Ekle(Bilesen bilesen)
        {
            throw new NotImplementedException();
        }

        public virtual void Kaldir(Bilesen bilesen)
        {
            throw new NotImplementedException();
        }


        public virtual bool Dal_mi()
        {
            return true;
        }
    }
}