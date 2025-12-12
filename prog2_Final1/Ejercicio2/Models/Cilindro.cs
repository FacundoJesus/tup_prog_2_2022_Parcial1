using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Cilindro:Figura
    {
        private double radio;

        public Cilindro(double radio, double alto):base(alto) 
        {
            this.radio = radio;

            base.Descripcion = $"Cilindro de {base.alto} cm";
        }

        public override double Volumen()
        {
            return Math.PI * Math.Pow(2, this.radio) * base.alto;
        }

        public override double Perimetro()
        {
            return (2*Math.PI*radio) * alto;
        }
    }
}