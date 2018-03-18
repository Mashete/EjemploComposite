using Composite.Productos.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Productos
{
    public class Paquete : ProductoCompuesto
    {
        private List<Producto> subProductos;
        public Paquete()
        {
            this.subProductos = new List<Producto>();
        }

        public override void add(Producto componente)
        {
            this.subProductos.Add(componente);
        }

        public override void remove(Producto componente)
        {
            this.subProductos.Remove(componente);
        }

        public override Producto getElemento(int indice)
        {
            return this.subProductos[indice];
        }


    }
}
