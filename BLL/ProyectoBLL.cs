using Microsoft.EntityFrameworkCore;
using P2_AP1_Stephany_2018_0654.DAL;
using P2_AP1_Stephany_2018_0654.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace P2_AP1_Stephany_2018_0654.BLL
{
    public class ProyectoBLL
    {
        public static bool Guardar(Proyecto Proyecto)
        {
            if (!Existe(Proyecto.ProyectoId))
            {
                return Insertar(Proyecto);
            }
            else
                return Modificar(Proyecto);

        }
        private static bool Insertar(Proyecto Proyecto)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                foreach (var item in Proyecto.Detalle)
                {
                    var tarea = db.Tareas.Find(item.TareasId);
                    tarea.TiempoTarea += item.Tiempo;
                    ModificarTipoTarea(tarea);
                }

                if (db.Proyecto.Add(Proyecto) != null)
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

        private static bool Modificar(Proyecto Proyecto)
        {
            bool paso = false;
            // //
            Contexto db = new Contexto();
            try
            {

                var proyetoAntes = Buscar(Proyecto.ProyectoId);
                foreach (var item in proyetoAntes.Detalle)
                {
                    var tarea = db.Tareas.Find(item.TareasId);
                    tarea.TiempoTarea -= item.Tiempo;
                    ModificarTipoTarea(tarea);
                }

                db.Database.ExecuteSqlRaw($"Delete FROM ProyectoDetalle Where ProyectoId = {Proyecto.ProyectoId}");

                foreach (var item in Proyecto.Detalle)
                {
                    var tarea = db.Tareas.Find(item.TareasId);
                    tarea.TiempoTarea += item.Tiempo;
                    ModificarTipoTarea(tarea);
                    db.Entry(item).State = EntityState.Added;
                }

                db.Entry(Proyecto).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;

        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var proyecto = Buscar(id);
                if (proyecto != null)
                {
                    foreach (var item in proyecto.Detalle)
                    {
                        var tarea = db.Tareas.Find(item.TareasId);
                        tarea.TiempoTarea -= item.Tiempo;
                        ModificarTipoTarea(tarea);
                    }

                    db.Proyecto.Remove(proyecto);
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

        public static Proyecto Buscar(int id)
        {
            Contexto db = new Contexto();
            Proyecto proyecto;
            try
            {
                proyecto = db.Proyecto.Where(x => x.ProyectoId == id).Include(x => x.Detalle).SingleOrDefault();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return proyecto;
        }
        public static List<Proyecto> GetList(Expression<Func<Proyecto, bool>> expression)
        {
            List<Proyecto> proyectos = new List<Proyecto>();
            Contexto db = new Contexto();
            try
            {
                proyectos = db.Proyecto.Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return proyectos;
        }
        private static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto db = new Contexto();
            try
            {
                encontrado = db.Proyecto.Any(x => x.ProyectoId == id);
            }catch(Exception)
            {
                throw;
            }finally
            {
                db.Dispose();
            }

            return encontrado;
        }

        public static bool ModificarTipoTarea(Tareas tarea)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(tarea).State = EntityState.Modified;
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
    }
}
