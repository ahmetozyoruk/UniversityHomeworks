using Microsoft.Win32;
using System;
using System.Diagnostics;

namespace FindText.Abstract_Factory_Pattern
{

 class Client
    {
        public IAbstractFactory CreateFactory(IAbstractFactory factory)
        {
            return factory;
        }

    }
}
