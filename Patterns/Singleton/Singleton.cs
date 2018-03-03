using System;

namespace Singleton
{
    public class Singleton
    {
        private Objeto obj;

        public Objeto Obj
        {
            get
            {
                if (obj == null)
                    obj = new Objeto("valor1");
                return obj;
            }set {
                if (obj == null)
                    obj = value;
            }
        }
    }
}
