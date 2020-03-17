using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _2ParciaRegistroConDetallel_Aplicada1_1_2020.Entidades
{
   public class LLamadasDetalle
    {
        [Key]
        public int LLamadaDetalleId { get; set; }
        public int LlamadasId { get; set; }
        public string Problema { get; set; }
        public string Solucion { get; set; }
        
      
        public LLamadasDetalle()
        {
            LLamadaDetalleId = 0;
            LlamadasId = 0;
            Problema = string.Empty;
            Solucion = string.Empty;


        }

        public LLamadasDetalle( int llamadasId, string problema, string solucion)
        {
            LLamadaDetalleId = 0;
            LlamadasId = llamadasId;
            Problema = problema;
            Solucion = solucion;
        }
    }
}
