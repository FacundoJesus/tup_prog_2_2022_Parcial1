using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Pedido:IComparable
    {
        private string cliente;
        public int Numero { get; private set; }

        protected double precio;

        private ArrayList menu = new ArrayList();

        public Pedido(int numero, string cliente)
        {
            this.Numero = ++numero;
            this.cliente = cliente;
        }

        public virtual double Precio()
        {
            double descuento = 0;
            if (precio > 2000)
                descuento = precio * 0.05;

            return precio - descuento;
        }

        public void AgregarItem(ItemMenu itemMenu, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                precio += itemMenu.Precio;
                menu.Add(itemMenu);
            }
        }

        public int CompareTo(object obj)
        {
            Pedido nuevoPedido = obj as Pedido;
            if(nuevoPedido != null ) 
            {
                return this.Numero.CompareTo(nuevoPedido.Numero);
            }
            return -1;
        }

        public override string ToString()
        {
            return $"Nro: {this.Numero} - Cliente: {this.cliente}";
        }


    }
}
