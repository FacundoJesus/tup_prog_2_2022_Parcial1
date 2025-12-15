using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Delivery:Pedido
    {
        private double distancia;

        public Delivery(int numero, string cliente, double distEnKm): base(numero,cliente)
        {
            this.distancia = distEnKm;
        }

        public override double Precio()
        {
            return base.precio + 150 + (base.precio * this.distancia * 0.08);
        }

    }
}
