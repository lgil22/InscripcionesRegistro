using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using InscripcionesEstudiantes.Entidades;

namespace InscripcionesEstudiantes.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Inscripciones> Inscripciones { get; set; }
        public Contexto() : base("ConStr")
        {

        }

    }
}
