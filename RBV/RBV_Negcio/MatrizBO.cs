using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RBV_Clases;
using RBV_AccesoDatos;

namespace RBV_Negocio
{
    public class MatrizBO
    {
        public static MatrizValoracion ConsultarCaracteristicasRecursos(short IdEmpresa)
        {
            return MatrizDA.ConsultarCaracteristicasRecursos(IdEmpresa);
        }

        public static void InsertarMatriz(List<MatrizValoracion> Matriz)
        {
            MatrizDA.InsertarMatriz(Matriz);
        }
    }
}
