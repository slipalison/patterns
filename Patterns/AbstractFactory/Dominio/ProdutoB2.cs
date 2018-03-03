using AbstractFactory.Abstract;

namespace AbstractFactory.Dominio
{
    public class ProdutoB2 : AbstractProdutoB
    {
        public override string Interact(AbstractProdutoA a)
        {
            return $"{GetType().Name} interagindo com {a.GetType().Name}";
        }
    }
}
