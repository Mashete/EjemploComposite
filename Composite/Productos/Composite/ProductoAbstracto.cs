using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Productos.Composite
{
    public abstract class ProductoAbstracto
    {

        public virtual float ObtenerPrecioTotal()
        {
            throw new NotSupportedException(this.GetType().Name + "ObtenerPrecioTotal()");
        }

        public virtual void Cancelar()
        {
            throw new NotSupportedException(this.GetType().Name + "Cancelar()");
        }

        public virtual string ObtenerNombre()
        {
            throw new NotSupportedException(this.GetType().Name + "ObtenerDescripcion()");
        }

        public virtual void add(ProductoAbstracto componente)
        {
            throw new NotSupportedException(this.GetType().Name + "add()");
        }

        public virtual void remove(ProductoAbstracto componente)
        {
            throw new NotSupportedException(this.GetType().Name + "remove()");
        }

        public virtual ProductoAbstracto getElemento(int indice)
        {
            throw new NotSupportedException(this.GetType().Name + "getElemento()");
        }
    }
}
