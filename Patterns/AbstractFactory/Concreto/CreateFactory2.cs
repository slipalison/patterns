using AbstractFactory.Abstract;
using AbstractFactory.Dominio;

namespace AbstractFactory.Concreto
{
    public class CreateFactory2 : Abstract.AbstractFactory
    {
        public override AbstractProdutoA CriaProdutoA()
        {
            return new ProdutoA2();
        }

        public override AbstractProdutoB CriaProdutoB()
        {
            return new ProdutoB2();
        }
    }
}
