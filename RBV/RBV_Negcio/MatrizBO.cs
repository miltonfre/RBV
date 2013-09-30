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

        public static List<MatrizValoracion> ConsultarMatrizValoracion(short IdEmpresa)
        {
            return MatrizDA.ConsultarMatrizValoracion(IdEmpresa);
        }

        public static void InsertarMatriz(List<MatrizValoracion> Matriz, short IdEmpresa)
        {
            List<MatrizValoracion> MatrizValoracion = ConsultarMatrizValoracion(IdEmpresa);

            if (MatrizValoracion.Count > 0)
            {
                MatrizDA.EliminarMatriz(IdEmpresa);
            }
            MatrizDA.InsertarMatriz(Matriz);
        }
    }
}
