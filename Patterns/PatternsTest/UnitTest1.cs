using Xunit;
using AbstractFactory.Concreto;
using AbstractFactory.Dominio;

namespace PatternsTest
{
    public class UnitTest1
    {
        [Fact(DisplayName = nameof(Singleton))]
        public void SingletonTest()
        {
            var single = new Singleton.Singleton();
            Assert.True(single.Obj.nome == "valor1");
            single.Obj.nome = "valor2";
            single.Obj = new Singleton.Objeto("valor1");
            Assert.True(single.Obj.nome == "valor2");
        }

        [Fact(DisplayName = nameof(AbstractFactory))]
        public void AbstractFactoryTest()
        {
            AbstractFactory.Abstract.AbstractFactory fabrica1 = new CreateFactory1();
            var cliente = new Cliente(fabrica1);
            var t = cliente.Executar();

            AbstractFactory.Abstract.AbstractFactory fabrica2 = new CreateFactory2();
            var cliente2 = new Cliente(fabrica2);
            var t2 = cliente2.Executar();

        }
    }
}
