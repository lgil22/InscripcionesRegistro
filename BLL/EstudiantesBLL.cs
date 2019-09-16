using InscripcionesEstudiantes.DAL;
using InscripcionesEstudiantes.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace InscripcionesEstudiantes.BLL
{
   public class EstudiantesBLL
    {
        public static bool Guardar(Estudiantes estudiante)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Estudiantes.Add(estudiante) != null)
                    paso = db.SaveChanges() > 0;
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

        public static bool Modificar(Estudiantes estudiante)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                //buscar las entidades que no estan para removerlas
                /*var Anterior = db.Estudiantes.Find(estudiante.EstudianteId);
                foreach (var item in Anterior.Telefono)
                {
                    if (!estudiante.Telefono.ToList().Exists(d => d.Id == item.Id))
                        db.Entry(item).State = EntityState.Deleted;
                }*/

                db.Entry(estudiante).State = EntityState.Modified;
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
                var eliminar = db.Estudiantes.Find(id);
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

        //Este es el metodo para buscar en la base de datos
        public static Estudiantes Buscar(int id)
        {
            Contexto db = new Contexto();
            Estudiantes estudiante = new Estudiantes();
            try
            {
                estudiante = db.Estudiantes.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return estudiante;
        }
        //Este es el metodo para listar o consultar lo que tenemos en la base de datos
        public static List<Estudiantes> GetList(Expression<Func<Estudiantes, bool>> estudiante)
        {
            List<Estudiantes> Lista = new List<Estudiantes>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Estudiantes.Where(estudiante).ToList();
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
