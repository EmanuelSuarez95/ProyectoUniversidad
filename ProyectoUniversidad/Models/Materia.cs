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
        List<Materia> listaMaterias;
    }
}