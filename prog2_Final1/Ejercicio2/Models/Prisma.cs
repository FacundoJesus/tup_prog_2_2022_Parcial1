using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Prisma:Figura
    {
        private double largo;
        private double ancho;

        public Prisma(double largo, double ancho,double alto):base(alto)
        {
            this.largo = largo;
            this.ancho = ancho;

            base.Descripcion = $"Prisma de {base.alto} cm";
            
        }

        public override double Volumen()
        {
            return this.largo * this.ancho * base.alto;

        }

        public override double Perimetro()
        {
            return (2*this.largo + 2*this.ancho) * base.alto;
        }

        
    }

}
