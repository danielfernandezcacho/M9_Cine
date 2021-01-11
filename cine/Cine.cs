using System;
using System.Collections.Generic;
using System.Text;

namespace cine
{
    class Cine
    {
        // ATRIBUTOS
        private Silla[,] sala;
        private pelicula reproduccion;
        private double precio;

        // GETTERS Y SETTERS
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        internal pelicula Reproduccion
        {
            get { return reproduccion; }
            set { reproduccion = value; }
        }
        internal Silla[,] Sala
        {
            get { return sala; }
            set { sala = value; }
        }

        // CONSTRUCTOR
        public Cine(int numero, int letra, int precio)
        {
            // generamos una sala nueva con sillas. filas y columnas
            int numFila = 0;

            string lletres = "ABCDEFGHIJKLMNOPQRST";
            this.Precio = precio;
            sala = new Silla[numero, letra]; // creamos la sala
            for (int i = numero - 1; i >= 0; i--) // recorre la fila
            {
                numFila++;
                for (int j = 0; j < letra; j++) // recorre cada columna de la fila
                {
                    this.sala[i, j] = new Silla("" + numFila + lletres[j]); // creamos un objeto Silla nuevo pasandole como valor un número o una letra
                }
            }
        }

        // METODES
        public Boolean CheckPrecioEdad(Espectador espectador, double precio, pelicula pelicula)
        {
            // comprueba que el espectador tenga dinero y edad suficiente para entrar
            int edadEspectador = espectador.Edad;
            double dineroEspectador = espectador.Dinero;
            int edadMinima = pelicula.EdadMinima;

            if (edadEspectador < edadMinima || dineroEspectador < precio) //si es menor que la edad minima o no tiene suficiente dinero
            {
                return false;
            }
            // restamos el precio de la entrada al dinero del espectador
            espectador.Dinero = espectador.Dinero - precio;

            return true;

        }
            
        
    }
}

