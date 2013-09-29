using System;

namespace RBV_Clases
{
    public class EscalaValoracion
    {
        public short IdCaracteristica { get; set; }
        public string Caracteristica { get; set; }
        public string Clasificacion { get; set; }
        public short IdEmpresa { get; set; }
        public decimal Valor { get; set; }
    }
}