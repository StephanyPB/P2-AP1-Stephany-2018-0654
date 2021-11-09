using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_AP1_Stephany_2018_0654.Entidades
{
   public class ProyectoDetalle
    {
        [Key]
        public int Id { get; set; }
        public int ProyectoId { get; set; }
        public int TareasId { get; set; }
        public String TipoTarea { get; set; }
        public String Requerimiento { get; set; }
        public int Tiempo { get; set; }

        public ProyectoDetalle()
        {
            Id = 0;
            ProyectoId = 0;
            TareasId = 0;
            TipoTarea = string.Empty;
            Requerimiento = string.Empty;
            Tiempo = 0;
        }

        public ProyectoDetalle(int id, int proyectoId, int tareaId, string tipoTarea, string requerimiento, int tiempo)
        {
            Id = id;
            ProyectoId = proyectoId;
            TareasId = tareaId;
            TipoTarea = tipoTarea;
            Requerimiento = requerimiento;
            Tiempo = tiempo;
        }
    }
}
