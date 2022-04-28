using System;

namespace FindText.Abstract_Factory_Pattern
{

class ConcreteFactory1 : IAbstractFactory
    {
        public IDialog CreateDialog()
        {
            return new Dialog();
        }

        //public IAbstractProductB CreateProductB()
        //{
        //    return new ConcreteProductB1();
        //}
    }

}
