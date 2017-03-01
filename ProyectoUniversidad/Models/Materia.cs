using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoUniversidad.Models
{
    public class Materia
    {
        string nombre;
        long idMateria;
        Carrera carrera;
        int nota1;
        int nota2;
        public void setNota1(int x)
        {
            nota1 = x;
        }
        public void setNota2(int x)
        {
            nota2 = x;
        }
       int notaFinal = (nota1+nota2)/2;

    }
}