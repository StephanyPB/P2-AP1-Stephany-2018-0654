using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_AP1_Stephany_2018_0654.Entidades
{
    public class Proyecto
    {
        [Key]
        public int ProyectoId { get; set; }
        public DateTime Fecha { get; set; }
        public string DescripcionProyecto { get; set; }
        [ForeignKey("ProyectoId")]
        public List<ProyectoDetalle> Detalle { get; set; }

        public Proyecto()
        {
            ProyectoId = 0;
            Fecha = DateTime.Now;
            DescripcionProyecto = string.Empty;
            Detalle = new List<ProyectoDetalle>();
        }

        public Proyecto(int proyectoId, DateTime fecha, string descripcionProyecto)
        {
            ProyectoId = proyectoId;
            Fecha = fecha;
            DescripcionProyecto = descripcionProyecto;
        }
    }
}
