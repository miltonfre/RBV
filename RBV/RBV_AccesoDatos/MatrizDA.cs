using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RBV_Clases;
using System.Data.Linq;

namespace RBV_AccesoDatos
{
    public class MatrizDA
    {
        public static MatrizValoracion ConsultarCaracteristicasRecursos(short IdEmpresa)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            MatrizValoracion matriz = new MatrizValoracion();

            matriz.Caracteristicas = MaestrosDA.ConsultarCaracteristicas();
            matriz.Recursos = MaestrosDA.ConsultarRecursos(IdEmpresa);
            
            return matriz;
        }
    }
}
