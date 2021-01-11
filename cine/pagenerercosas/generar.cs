using System;
using System.Collections.Generic;
using System.Text;

namespace cine
{
    class generar
    {
        abstract class Generadores
        {

            public static Espectador[] GenerarPublic(Espectador[] Gent)
            {

                int cantitat = Gent.Length;
                string[] Noms = { "Jesús", "María", "Manuel", "Antonio", " Jordi", "Mikel", "Pilar", "Javier", "Francisco ", "DAVID", "DANIEL", "CARLOS", "JESUS", "Isabel", "Laura", "Ana", "Cristina", "Marta", "Francisca", "Lucía", "Álvaro", "Amir", "Amira", "Ana", "Anas", "Àngel", "Aniol", "Anna", "Antonio" };
                string[] Cognoms = { "Alves", "Amador", "Amat", "Amaya", "Amigo", "Amores", "Amoros", "Andrade", "Andres", "Andreu", "Anglada", "Angles", "Triviño", "Trujillo", "Tudela", "Ubeda", "Urbano", "Ureña","Villa", "Villalba", "Villanueva", "Villar", "Villegas", "Villena", "Viñals", "Viñas", "Virgili", "Vivas", "Vives", "Vizcaino", "Wang", "Wu", "Xu", "Yañez", "Ye", "Yuste", "Zafra", "Zambrano", "Zamora", "Zapata", "Zaragoza", "Zhang", "Zhou", "Zhu", "Zurita" };
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

        }

        protected static Espectador[] GenerarPublic(Espectador[] publico)
        {
            throw new NotImplementedException();
        }
    }
}