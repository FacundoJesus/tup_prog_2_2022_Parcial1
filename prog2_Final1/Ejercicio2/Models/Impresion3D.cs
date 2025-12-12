using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Impresion3D
    {
        private double precio;
        private double tiempo;
        private double precioTotal;

        private Cliente empresa;

        private ArrayList figuras = new ArrayList();
        public int CantidadFiguras
        {
            get
            {
                return figuras.Count;
            }
        }
        public Figura VerFigura(int pos)
        {
            return figuras[pos] as Figura;
        }


        public Impresion3D(double precioBase, string nombre, long cuit)
        {
            empresa = new Cliente(nombre, cuit);
            this.precio = precioBase;
        }

        public void AgregarFigura(Figura pieza)
        {
            if (pieza != null) 
            {
                figuras.Add(pieza);
                precioTotal += pieza.Volumen() * 0.0035 * precio;
                tiempo += pieza.Perimetro() * 1.75;
            }
        }

        public double PrecioEstimado()
        {
            return precioTotal;
        }

        public int Tiempo()
        {
            return Convert.ToInt32(tiempo);
        }

        public override string ToString()
        {
            return empresa.ToString();
        }

        public void Ordenar()
        {
            figuras.Sort();
        }


    }
}
