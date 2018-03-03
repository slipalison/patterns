using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Abstract
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProdutoA CriaProdutoA();
        public abstract AbstractProdutoB CriaProdutoB();
    }
}
