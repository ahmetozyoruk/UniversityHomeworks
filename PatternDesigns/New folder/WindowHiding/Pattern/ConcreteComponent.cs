using System;

namespace WindowHiding.Pattern
{
    class ConcreteComponent : Component
    {
        static int CagrilmaSayisi=0;
        public override string Operation()
        {
            CagrilmaSayisi++;
            return $"{CagrilmaSayisi}.ci cagrilis";
        }
    }
}
