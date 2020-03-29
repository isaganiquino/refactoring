using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class PizzeriaFactory
    {
        public abstract void Order(string variety);
        public abstract void Prepare();
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();
    }
}
