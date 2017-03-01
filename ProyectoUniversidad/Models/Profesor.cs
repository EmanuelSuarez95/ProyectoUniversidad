using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoUniversidad.Models
{
    public class Profesor
    {
        string nombre;
        string apellido;
        long dni;
        string mail;
        List<Materia> listaMaterias;

        public Materia calificar(Alumno alumno, int nota)
        {
            List<Materia> materias = alumno.getMateriasInscriptas();
            foreach(Materia m in materias)
            {
                foreach(Materia m2 in listaMaterias)
                {
                    if (m == m2)
                    {
                        materia = m;
                        m.nota == nota;
                        
                    }
                }
            }
            return materia;
        }
    }
}