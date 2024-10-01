using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp15
{
    internal class Lista
    {
        public nodo inicio;  //Cabeza de la Lista

        //Constructor por defecto
        public Lista()
        {
            inicio = null;
        }

        //Metodo que inserta al inicio de la lista
        public void insertarInicio(int dato)
        {
            nodo auxiliarcito = new nodo();
            auxiliarcito.dato = dato;
            auxiliarcito.siguiente = null;

            if (inicio == null)
            {
                inicio = auxiliarcito;
            }
            else
            { 
              nodo temporal= inicio;
              inicio=auxiliarcito;
              auxiliarcito.siguiente = temporal;
            }
        }

        //Metodo que inserta al final de la lista

        public void InsertarFinal(int dato)
        {
            nodo auxiliarcito = new nodo();
            auxiliarcito.dato = dato;
            auxiliarcito.siguiente = null;

            if (inicio == null)
            {
                inicio = auxiliarcito;
            }
            else
            {
                nodo puntero;
                puntero=inicio;
                while (puntero.siguiente != null)
                { 
                   puntero=puntero.siguiente;
                }
                puntero.siguiente = auxiliarcito;
            }

        }

        //metodo para eliminar el nodo que esta en la cabeza de la lista
        public void EliminarInicio()
        {
            if (inicio == null)
            { MessageBox.Show("La lista vacia"); }
            else
            {
                inicio = inicio.siguiente;
            }

        }

        //metodo para eliminar el nodo que esta en la cabeza de la lista
        public void EliminarFinal()
        {
            if (inicio == null)
            {
                MessageBox.Show("La lista esta vacia");
            }
            else
            {
                nodo punteroAnterior;
                punteroAnterior = inicio;
                while (punteroAnterior.siguiente != null)
                { 
                   
                }

            
            }
         
        }

    }
}
