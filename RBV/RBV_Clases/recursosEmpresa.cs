using System;
using RBV_Clases;

namespace RBV_Clases
{
    public class RecursosEmpresa
    {
        public short IdRecursoEmpresa { get; set; }
        public string NombreRecurso { get; set; }
        public string DescripcionRecurso { get; set; }
        public TipoRecurso TipoRecurso { get; set; }
        public Empresa Empresa { get; set; }
    }
}