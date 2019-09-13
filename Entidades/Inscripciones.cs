using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InscripcionesEstudiantes.Entidades
{
        public class Inscripciones
        {
            [Key]
            public int InscripcionId { get; set; }
            public DateTime Fecha { get; set; }
            public int EstudianteId { get; set; }
            public String Comentarios { get; set; }
            public decimal Monto { get; set;}
            public decimal Deposito { get; set; }
            public decimal Balance { get; set; }

          public Inscripciones()
          {
            InscripcionId = 0;
            Fecha = DateTime.Now;
            EstudianteId = 0;
            Comentarios = string.Empty;
            Monto = 0;
            Deposito = 0;
            Balance = 0;

           }
        public Inscripciones(int inscripcionId, DateTime fecha, int estudianteId, string comentarios, decimal monto, decimal deposito, decimal balance)
        {
            InscripcionId = inscripcionId;
            Fecha = fecha;
            EstudianteId = estudianteId;
            Comentarios = comentarios;
            Monto = monto;
            Deposito = deposito;
            Balance = balance;
        }


    }

    
}
