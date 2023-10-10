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

        public string vacante { get; set; }
       
       

        

        public string ObtenerRecomendacion()
        {
            string recomendacion = areaInteres + nivelDificultad;
            


            if (areaInteres == "Matematicas" && nivelDificultad == "Facil")
            {
                
                return "Te recomendamos el curso de Introducción a las Matemáticas.";
            }
            else if (areaInteres == "Matematicas" && nivelDificultad == "Intermedio")
            {
                return "Te recomendamos el curso de Matemáticas Avanzadas I";
            }
            else if (areaInteres == "Ciencias Sociales" && nivelDificultad == "Facil")
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
            else if (areaInteres == "Arte" && nivelDificultad == "Facil")
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
            else if (areaInteres == "Programacion" && nivelDificultad == "Facil")
            {
                return "Te recomendamos el curso de Introduccion a la Programación con pseudocodigo.";
            }
            else if (areaInteres == "Programacion" && nivelDificultad == "Intermedio")
            {
                return "Te recomendamos el curso de Desarrollo Web con C#.";
            }
            else if (areaInteres == "Programacion" && nivelDificultad == "Avanzado")
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

}