using System;

namespace RBV_Clases
{
    public class EmpresaUsuario
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public short IdEmpresa { get; set; }
        public short IdUsuarioEmpresa { get; set; }
    }
}