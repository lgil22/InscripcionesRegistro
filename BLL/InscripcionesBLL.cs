using InscripcionesEstudiantes.DAL;
using InscripcionesEstudiantes.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InscripcionesEstudiantes.BLL
{
   public class InscripcionesBLL
    {

        public static bool Guardar(Inscripciones inscripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Inscripciones.Add(inscripcion) != null)
                {
                    db.Estudiantes.Find(inscripcion.EstudianteId).Balance += inscripcion.Monto;
                    paso = db.SaveChanges() > 0;
                }
                    
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Inscripciones inscripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                Inscripciones ant = InscripcionesBLL.Buscar(inscripcion.InscripcionId);

                decimal cambio = inscripcion.Monto - ant.Monto;

                var est = db.Estudiantes.Find(inscripcion.EstudianteId);
                est.Balance += cambio;
                EstudiantesBLL.Modificar(est);

                db.Entry(inscripcion).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        //Este es el metodo para eliminar en la base de datos
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Inscripciones.Find(id);
                db.Estudiantes.Find(eliminar.EstudianteId).Balance -= eliminar.Monto;
                db.Entry(eliminar).State = System.Data.Entity.EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static Inscripciones Buscar(int id)
        {
            Contexto db = new Contexto();
            Inscripciones inscripcion = new Inscripciones();
            try
            {
                inscripcion = db.Inscripciones.Find(id);
            
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return inscripcion;
        }

        public static List<Inscripciones> GetList(Expression<Func<Inscripciones, bool>> inscripcion)
        {
            List<Inscripciones> Lista = new List<Inscripciones>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Inscripciones.Where(inscripcion).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }

    }
}
