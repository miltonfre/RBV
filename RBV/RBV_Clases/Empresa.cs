using System;
using System.Collections.Generic;

namespace RBV_Clases
{
    public class Empresa
    {
        public short IdEmpresa { get; set; }
        public string Nit { get; set; }
        public string NombreEmpresa { get; set; }
        public string RepresetanteLegal { get; set; }
        public List<SectorEmpresa> SectoresEmpresas { get; set; }
        public EmpresaUsuario EmpresasUsuarios { get; set; }
    }
}
