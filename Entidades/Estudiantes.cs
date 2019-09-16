using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations;

namespace InscripcionesEstudiantes.Entidades
{
   public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal Balance { get; set; }

        public Estudiantes()
        {
            EstudianteId = 0;
            Matricula = string.Empty;
            Nombre = string.Empty;
            Apellidos = string.Empty;
            Telefono = string.Empty;
            Cedula = string.Empty;
            Email = string.Empty;
            FechaNacimiento = DateTime.Now;
            Balance = 0;

        }

        public Estudiantes(int estudianteid, string nombre, string matricula, string apellidos, string cedula, string email, DateTime fechanacimiento, int balance)
        {
            EstudianteId = estudianteid;
            Matricula = matricula;
            Nombre = nombre;
            Apellidos = apellidos;
            Cedula = cedula;
            Email = email;
            FechaNacimiento = fechanacimiento;
            Balance = balance;
        }

    }

}
