using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Cliente
    {
        private string nombre;
        private long cuit;

        public Cliente(string nombre, long cuit)
        {
            this.nombre = nombre;
            this.cuit = cuit;
        }

        public override string ToString()
        {
            return $"{this.nombre} ({this.cuit})";
        }
    }
}
