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

        public static List<RecursoValioso> InsertarMatriz(List<MatrizValoracion> Matriz, short IdEmpresa)
        {
            List<MatrizValoracion> MatrizValoracion = ConsultarMatrizValoracion(IdEmpresa);

            if (MatrizValoracion.Count > 0)
            {
                MatrizDA.EliminarMatriz(IdEmpresa);
            }
            MatrizDA.InsertarMatriz(Matriz);

            return CalcularResultadosMatriz(Matriz, IdEmpresa);
        }

        public static List<RecursoValioso> CalcularResultadosMatriz(List<MatrizValoracion> Matriz, short IdEmpresa)
        {
            List<EscalaValoracion> escalaValoracion = MaestrosDA.ConsultarEscalaValoracion(IdEmpresa);
            List<RecursosEmpresa> recursosEmpresa = MaestrosDA.ConsultarRecursos(IdEmpresa);
            List<RecursoValioso> RecursosValiosos = new List<RecursoValioso>();

            foreach (RecursosEmpresa item in recursosEmpresa)
            {
                
                List<MatrizValoracion> MatrizRecurso = Matriz.Where(p => p.IdRecurso == item.IdRecursoEmpresa).Distinct().ToList();
                decimal ValorTotalRecurso = 0;
                
                foreach (MatrizValoracion itemRecurso in MatrizRecurso)
                {
                    decimal ValorClasificacion = escalaValoracion.Where(p => p.IdClasificacion == itemRecurso.IdClasificacion).Sum(p => p.Valor);
                    decimal ValorCaracteristica = escalaValoracion.Where(p => p.IdCaracteristica == itemRecurso.IdCaracteristica).Single().Valor;
                    if (ValorClasificacion == ValorCaracteristica)
                    {
                        ValorTotalRecurso += itemRecurso.Valor * (ValorClasificacion / 100);
                    }
                    else
                    {
                        ValorTotalRecurso += itemRecurso.Valor * (ValorCaracteristica / 100) * (ValorClasificacion / 100);
                    }
                }
                RecursosValiosos.Add(new RecursoValioso { IdRecursoEmpresa = item.IdRecursoEmpresa, Valor = ValorTotalRecurso });
            }
            return RecursosValiosos;
        }
    }
}
