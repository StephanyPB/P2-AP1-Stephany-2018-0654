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
    public class TareasBLL
    {
        public static List<Tareas> GetList(Expression<Func<Tareas, bool>> expression)
        {
            List<Tareas> tareas = new List<Tareas>();
            Contexto db = new Contexto();
            try
            {
                tareas = db.Tareas.Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return tareas;
        }
    }
}
