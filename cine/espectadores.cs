using System;
using System.Collections.Generic;
using System.Text;

namespace cine
{
    class Espectador
    {
        private string nombre;
        private int edad;
        private double dinero;

        public Espectador(string nombre, int edad, double dinero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dinero = dinero;
        }

        public Espectador()
        {
        }


        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Dinero { get => dinero; set => dinero = value; }


        public Espectador[] GenerarPublic(Espectador[] Gent)
        {
            //array con publico aleatorio
            int cantitat = Gent.Length;
            string[] Noms = { "Jesús", "María", "Manuel", "Antonio", " Jordi", "Mikel", "Pilar", "Javier", "Francisco ", "DAVID", "DANIEL", "CARLOS", "JESUS", "Isabel", "Laura", "Ana", "Cristina", "Marta", "Francisca", "Lucía", "Álvaro", "Amir", "Amira", "Ana", "Anas", "Àngel", "Aniol", "Anna", "Antonio" };
            string[] Cognoms = { "Alves", "Amador", "Amat", "Amaya", "Amigo", "Amores", "Amoros", "Andrade", "Andres", "Andreu", "Anglada", "Angles","Triviño", "Trujillo", "Tudela", "Ubeda", "Urbano", "Ureña","Villa", "Villalba", "Villanueva", "Villar", "Villegas", "Villena", "Viñals", "Viñas", "Virgili", "Vivas", "Vives", "Vizcaino", "Wang", "Wu", "Xu", "Yañez", "Ye", "Yuste", "Zafra", "Zambrano", "Zamora", "Zapata", "Zaragoza", "Zhang", "Zhou", "Zhu", "Zurita" };
            Random r = new Random();
            for (int i = 0; i < cantitat; i++)
            {
                Gent[i] = new Espectador();
                Gent[i].Nombre = Noms[r.Next(0, Noms.Length)] + " " + Cognoms[r.Next(0, Cognoms.Length)] + " " + Cognoms[r.Next(0, Cognoms.Length)];
                Gent[i].Edad = r.Next(0, 100);
                Gent[i].Dinero = r.Next(0, 20);
            }
            return Gent; 
        }
        public void MostrarEspectadores(Espectador[] Gent)
        {
            // printa los espectadores.
            int cantitat = Gent.Length;
            for (int i = 0; i < cantitat; i++)
            {
                Console.WriteLine("Espectador n{0}: {1}, {2}, {3}€", i + 1, Gent[i].Nombre, Gent[i].Edad, Gent[i].Dinero);
            }
        }
    }
}