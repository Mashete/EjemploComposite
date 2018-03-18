using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Productos.Composite
{
    public abstract class Producto : ProductoAbstracto
    {
        public float Precio { get; set; }
        public float Impuestos { get; set; }
        public string Nombre { get; set; }
        public bool Cancelado { get; set; }

        public override float ObtenerPrecioTotal()
        {
            return this.Precio + this.Impuestos;
        }

        public override void Cancelar()
        {
            //Llamar a WebService que cancela
            this.Cancelado = true;
        }

        public override string ObtenerNombre()
        {
            return this.Nombre;
        }
    }
}

