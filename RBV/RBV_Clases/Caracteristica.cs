using System;
using System.Data;

namespace RBV_Clases
{
    public class Caracteristica
    {
        public short IdCaracteristica { get; set; }
        public string NombreCaracteristica { get; set; }
        public short IdClasificacionRV { get; set; }
        public Clasificacion ClasificacionAsociada { get; set; }
    }
}