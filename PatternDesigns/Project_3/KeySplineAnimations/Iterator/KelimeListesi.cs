
using System;
using System.Collections;
using System.Collections.Generic;

namespace KeySplineAnimations.Iterator
{
    class KelimeListesi : YenileyiciOlustur
    {
        List<string> _collection = new List<string>();
        
        bool _yon = false;
        
        public void YonuDegistir()
        {
            _yon = !_yon;
        }
        
        public List<string> GetirListeyi()
        {
            return _collection;
        }
        
        public void EkleElamani(string item)
        {
            this._collection.Add(item);
        }
        
        public override IEnumerator GetEnumerator()
        {
            return new AlfabetikSiraYenileyicisi(this, _yon);
        }
    }
}