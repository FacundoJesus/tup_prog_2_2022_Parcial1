using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Rotiseria
    {
        public double TotalRecaudado
        {
            get
            {
                double total = 0;
                foreach(Pedido p in listaPedidos)
                {
                    total += p.Precio();
                }
                return total;
            }
        }

        public int TotalDePedidos
        {
            get
            {
                return listaPedidos.Count;
            }
        }

        private ArrayList listaPedidos = new ArrayList();

        public void AgregarPedido(Pedido p)
        {
            if (p != null)
            {
                listaPedidos.Add(p);
            }
        }

        public Pedido VerPedido(int pos)
        {
            Pedido pedido = null;
            if (pos < TotalDePedidos)
            {
                pedido = listaPedidos[pos] as Pedido;
            }
            return pedido;
        }

        public void Ordenar()
        {
            listaPedidos.Sort();
        }
        /*
        public void Ordenar()
        {
            quickSort(listaPedidos, 0, listaPedidos.Count - 1);
        }
        private void quickSort(ArrayList lista, int inicio, int fin)
        {
            //partición
            Pedido p = (Pedido)lista[inicio];
            int m = inicio + 1;
            int n = fin;
            Pedido aux = null;

            while (m <= n)//hasta que se crucen
            {
                while (m <= fin && p.Precio() >= ((Pedido)lista[m]).Precio()) m++;
                while (n > inicio && p.Precio() <= ((Pedido)lista[n]).Precio()) n--;

                if (m < n)
                {
                    aux = (Pedido)lista[m];
                    lista[m] = lista[n];
                    lista[n] = aux;
                }
            }
            lista[inicio] = lista[n];
            lista[n] = p;
            //fin partición

            if (inicio <= n - 1)
                quickSort(lista, inicio, n - 1);
            if (n + 1 <= fin)
                quickSort(lista, n + 1, fin);
        }
        */

    }
}
