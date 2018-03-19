using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Productos.Composite
{
    public class ProductoCompuesto : ProductoAbstracto
    {
        public string Nombre { get; set; }
        public float Precio { get; set; }

        private List<ProductoAbstracto> subProductos;

        public ProductoCompuesto()
        {
            this.subProductos = new List<ProductoAbstracto>();
        }

        public override void add(ProductoAbstracto componente)
        {
            this.subProductos.Add(componente);
        }

        public override void remove(ProductoAbstracto componente)
        {
            this.subProductos.Remove(componente);
        }

        public override ProductoAbstracto getElemento(int indice)
        {
            return this.subProductos[indice];
        }

        public override void Cancelar()
        {
            Console.WriteLine(string.Concat("Ejecutar cancelacion de ", this.GetType()));
            foreach (var producto in this.subProductos)
            {
                producto.Cancelar();
            }
        }

        public override float ObtenerPrecioTotal()
        {
            float total = this.Precio;
            foreach (var producto in this.subProductos)
            {
                total += producto.ObtenerPrecioTotal();
            }
            return total;
        }

        public override string ObtenerNombre()
        {
            string nombre = this.Nombre;
            foreach (var producto in this.subProductos)
            {
                nombre = string.Concat(nombre, "/", producto.ObtenerNombre());
            }
            return nombre;
        }
    }
}
