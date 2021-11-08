using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_AP1_Stephany_2018_0654.Entidades
{
    public class Tareas
    {
        [Key]
        public int TareasId { get; set; }
        public string TipoTarea { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int TiempoTarea { get; set; }

        //[ForeignKey("TareasId")]

        public Tareas()
        {
            TipoTarea = string.Empty;
            //TareasId = 0;
            TiempoTarea = 0;
            FechaIngreso = DateTime.Now;
        }
    }
}
