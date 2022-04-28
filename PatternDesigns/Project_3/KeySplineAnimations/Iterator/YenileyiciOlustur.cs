
using System;
using System.Collections;
using System.Collections.Generic;

namespace KeySplineAnimations.Iterator
{
    abstract class YenileyiciOlustur : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}