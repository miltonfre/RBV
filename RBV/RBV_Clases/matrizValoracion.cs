using System;
using System.Collections.Generic;

namespace RBV_Clases
{
    public class MatrizValoracion
    {
        public List<Caracteristica> Caracteristicas { get; set; }
        public List<RecursosEmpresa> Recursos { get; set; }

        public short IdCaracteristica { get; set; }
        public short IdRecurso { get; set; }
        public decimal Valor { get; set; }
    }
}