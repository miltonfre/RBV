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

        public static void InsertarMatriz(List<MatrizValoracion> Matriz)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            List<matrizValoracion> matrizInsertar = new List<matrizValoracion>();

            matrizInsertar = (from mat in Matriz
                              select new matrizValoracion
                              {
                                  idCaracteristicaRV = mat.IdCaracteristica,
                                  idRecursoEmpresa = mat.IdRecurso,
                                  valor = mat.Valor

                              }).ToList();

            contextoRBV.matrizValoracions.InsertAllOnSubmit(matrizInsertar);
            contextoRBV.SubmitChanges();
        }
    }
}
