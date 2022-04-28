using System;

namespace FindText.Abstract_Factory_Pattern
{

public interface IAbstractFactory
    {
        IDialog CreateDialog();

        //IAbstractProductB CreateProductB();
    }

}
