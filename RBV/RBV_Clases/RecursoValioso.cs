using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RBV_Clases
{
    public class RecursoValioso
    {
        public short IdRecursoEmpresa { get; set; }
        public string NombreRecurso { get; set; }
        public decimal Valor { get; set; }
        public string TipoRecurso { get; set; }
        public short IdTipoRecurso { get; set; }
    }
}
