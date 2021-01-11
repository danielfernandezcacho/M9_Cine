using System;
using System.Collections.Generic;
using System.Text;

namespace cine
{
    class Silla
    { 
            private string etiqueta;
            private Espectador ocupado;

   
            public string Etiqueta
            {
                get { return etiqueta; }
                set { etiqueta = value; }
            }
            internal Espectador Ocupado
            {
                get { return ocupado; }
            }
            public Silla(string etiqueta)
            {
                this.etiqueta = etiqueta;
                this.ocupado = null;
            }
            public Silla()
            {
                this.ocupado = null;
            }

            public void Asentar(Espectador espectador)
            {

                this.ocupado = espectador;
            }
            public void Aixecar()
            {
                this.ocupado = null;
            }

        }
    }
