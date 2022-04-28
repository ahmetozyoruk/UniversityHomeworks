
using System;
using System.Collections;
using System.Collections.Generic;

namespace KeySplineAnimations.Iterator
{

abstract class Yenileyici : IEnumerator
    {
        object IEnumerator.Current => Suanki();

        
        public abstract int Anahtar();
        
        
        public abstract object Suanki();
        
        public abstract bool MoveNext();
        
        public abstract void Reset();
    }
}