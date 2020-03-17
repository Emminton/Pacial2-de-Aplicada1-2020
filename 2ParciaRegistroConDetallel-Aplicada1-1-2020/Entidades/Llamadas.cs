using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _2ParciaRegistroConDetallel_Aplicada1_1_2020.Entidades
{
    public class Llamadas
    {
        [Key]
        public int LlamadasId { get; set; }
        public string Descripcion { get; set; }    

        [ForeignKey("LlamadasId")]
        public virtual List<LLamadasDetalle> LlamadaDetalle { get; set; } = new List<LLamadasDetalle>();

        public Llamadas()
        {
            LlamadasId = 0;
            Descripcion = string.Empty;
            LlamadaDetalle = new List<LLamadasDetalle>();
        }
    }
}
