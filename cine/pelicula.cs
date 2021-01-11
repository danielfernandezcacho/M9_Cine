﻿using System;
using System.Collections.Generic;
using System.Text;

namespace cine
{
    class pelicula
    {

        private string titulo;
        private int duracion;
        private int edadMinima;
        private string director;

        // CONSTRUCTOR
        public pelicula(string titulo, int duracion, int edadMinima, string director)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.edadMinima = edadMinima;
            this.director = director;
        }


        public string Titulo { get => titulo; set => titulo = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public int EdadMinima { get => edadMinima; set => edadMinima = value; }
        public string Director { get => director; set => director = value; }
    }
}
