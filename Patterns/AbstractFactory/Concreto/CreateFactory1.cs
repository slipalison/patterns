using AbstractFactory.Abstract;
using AbstractFactory.Dominio;

namespace AbstractFactory.Concreto
{
    public class CreateFactory1 : Abstract.AbstractFactory
    {
        public override AbstractProdutoA CriaProdutoA()
        {
            return new ProdutoA();
        }

        public override AbstractProdutoB CriaProdutoB()
        {
            return new ProdutoB();
        }
    }
}
