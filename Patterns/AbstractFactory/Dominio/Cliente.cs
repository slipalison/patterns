using AbstractFactory.Abstract;

namespace AbstractFactory.Dominio
{
    public class Cliente
    {
        private AbstractProdutoA _abstractProdutoA;
        private AbstractProdutoB _abstractProdutoB;

        public Cliente(AbstractFactory.Abstract.AbstractFactory fabrica)
        {
            _abstractProdutoA = fabrica.CriaProdutoA();
            _abstractProdutoB = fabrica.CriaProdutoB();
        }


        public string Executar()
        {
           return _abstractProdutoB.Interact(_abstractProdutoA);
        }

    }
}
