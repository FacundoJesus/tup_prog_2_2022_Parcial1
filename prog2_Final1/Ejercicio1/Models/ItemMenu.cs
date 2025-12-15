using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class ItemMenu
    {
        private string descripcion;
        private int id;

        public double Precio {  get; set; }

        public ItemMenu(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        public override string ToString()
        {
            return $"{this.descripcion}, {this.Precio:c2}";
        }
    }
}
