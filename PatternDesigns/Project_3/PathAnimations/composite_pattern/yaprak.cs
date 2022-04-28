using System;

namespace PathAnimations.composite_pattern
{
    class Yaprak : Bilesen
    {
        public override string Islem()
        {
            return "Yaprak";
        }

        public override bool Dal_mi()
        {
            return false;
        }


    }
}