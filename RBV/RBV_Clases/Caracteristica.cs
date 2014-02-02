using System;
using System.Data;

namespace RBV_Clases
{
    public class Caracteristica
    {
        public short IdCaracteristica { get; set; }
        public string NombreCaracteristica { get; set; }
        public string ValorCaracteristica { get; set; }
        public string Descripcion { get; set; }
        public string Acciones { get; set; }
        public short IdClasificacionRV { get; set; }
        public Clasificacion ClasificacionAsociada { get; set; }
    }
}