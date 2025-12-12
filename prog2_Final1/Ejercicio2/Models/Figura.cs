using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public abstract class Figura:IComparable
    {
        protected double alto;
        public string Descripcion;

        public Figura(double alto)
        {
            this.alto = alto;
        }

        public abstract double Volumen();

        public abstract double Perimetro();

        public int CompareTo(object obj)
        {
            Figura nuevaFigura = obj as Figura;
            if(nuevaFigura != null)
            {
                return this.Descripcion.CompareTo(nuevaFigura.Descripcion);
            }
            return -1;
        }
    }
}
