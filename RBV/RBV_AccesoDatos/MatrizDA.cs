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
            MatrizValoracion matriz = new MatrizValoracion();
            
            matriz.Caracteristicas = MaestrosDA.ConsultarCaracteristicas();
            matriz.Recursos = MaestrosDA.ConsultarRecursos(IdEmpresa);
            
            return matriz;
        }

        public static List<MatrizValoracion> ConsultarMatrizValoracion(short IdEmpresa)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            List<MatrizValoracion> MatrizValoracionEmpresa = new List<MatrizValoracion>();
            MatrizValoracionEmpresa = (from mat in contextoRBV.matrizValoracions
                                       join rec in contextoRBV.recursosEmpresas
                                       on mat.idRecursoEmpresa equals rec.idRecursoEmpresa
                                       where rec.idEmpresa == IdEmpresa
                                       select new MatrizValoracion
                                       {
                                           IdCaracteristica = mat.idCaracteristicaRV,
                                           IdRecurso = mat.idRecursoEmpresa,
                                           Valor = mat.valor

                                       }).ToList();

            return MatrizValoracionEmpresa;
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

        public static void EliminarMatriz(short IdEmpresa)
        {
            RBVDataContext contextoRBV = new RBVDataContext();
            
            var MatrizValoracionEmpresas = (from mat in contextoRBV.matrizValoracions
                                            join rec in contextoRBV.recursosEmpresas
                                            on mat.idRecursoEmpresa equals rec.idRecursoEmpresa
                                            where rec.idEmpresa == IdEmpresa
                                            select mat).ToList();

            contextoRBV.matrizValoracions.DeleteAllOnSubmit(MatrizValoracionEmpresas);
            contextoRBV.SubmitChanges();            
        }
    }
}
