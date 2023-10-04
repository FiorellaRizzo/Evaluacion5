using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion5.BE
{
    public class Recomendacion

    {
        public string areaInteres { get; set; }

        public string nivelDificultad { get; set; }

        //public string recomendacion = ObtenerRecomendacion(string areaInteres,string nivelDificultad);
        public string ObtenerRecomendacion()
        {
            string recomendacion = areaInteres + nivelDificultad;

            if (areaInteres == "Matemáticas" && nivelDificultad == "Fácil")
            {
                return "Te recomendamos el curso de Introducción a las Matemáticas.";
            }
            else if (areaInteres == "Matemáticas" && nivelDificultad == "Intermedio")
            {
                return "Te recomendamos el curso de Matemáticas Avanzadas I";
            }
            else if (areaInteres == "Matemáticas" && nivelDificultad == "Avanzado")
            {
                return "Te recomendamos el curso de Matemáticas Avanzadas II";
            }
            else if (areaInteres == "Ciencias Sociales" && nivelDificultad == "Fácil")
            {
                return "Te recomendamos el curso Introductorio a las disciplinas fundamentales de Ciencias Sociales.";
            }
            else if (areaInteres == "Ciencias Sociales" && nivelDificultad == "Intermedio")
            {
                return "Te recomendamos el curso de Historia Contemporánea.";
            }
            else if (areaInteres == "Ciencias Sociales" && nivelDificultad == "Avanzado")
            {
                return "Te recomendamos el curso de Historia de la Cultura y la Civilización.";
            }
            else if (areaInteres == "Arte" && nivelDificultad == "Fácil")
            {
                return "Te recomendamos el curso de Introduccion a Las bellas artes.";
            }
            else if (areaInteres == "Arte" && nivelDificultad == "Intermedio")
            {
                return "Te recomendamos el curso de Arte Plastica y Visual.";
            }
            else if (areaInteres == "Arte" && nivelDificultad == "Avanzado")
            {
                return "Te recomendamos el curso de Pintura Expresionista.";
            }
            else if (areaInteres == "Programación" && nivelDificultad == "Facil")
            {
                return "Te recomendamos el curso de Introduccion a la Programación con pseudocodigo.";
            }
            else if (areaInteres == "Programación" && nivelDificultad == "Intermedio")
            {
                return "Te recomendamos el curso de Desarrollo Web con C#.";
            }
            else if (areaInteres == "Programación" && nivelDificultad == "Avanzado")
            {
                return "Te recomendamos el curso de Paradigmas de la programación.";
            }
            else
            {
                return "Lo siento, no podemos encontrar una recomendación en este momento.";
            }
        

    }
}
}
