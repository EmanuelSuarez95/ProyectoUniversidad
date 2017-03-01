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
    }
}