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
                RecursosValiosos.Add(new RecursoValioso { IdRecursoEmpresa = item.IdRecursoEmpresa, NombreRecurso = item.NombreRecurso ,Valor = ValorTotalRecurso, IdTipoRecurso = item.TipoRecurso.IdTipoRecurso, TipoRecurso = item.TipoRecurso.NombreTipoRecurso });
            }
            return RecursosValiosos;
        }

        public static List<RecursoValioso> ConsultarRecursosValiosos(short idEmpresa)
        {
            List<RecursoValioso> Recursos = new List<RecursoValioso>();
            List<RecursoValioso> RecursosValiosos = new List<RecursoValioso>();
            decimal ValorTotal = 0;

            List<MatrizValoracion> matrizValoracion = RBV_Negocio.MatrizBO.ConsultarMatrizValoracion(idEmpresa).OrderBy(p => p.IdCaracteristica).ThenBy(p => p.IdRecurso).ToList();

            if (matrizValoracion.Count > 0)
            {
                Recursos = RBV_Negocio.MatrizBO.CalcularResultadosMatriz(matrizValoracion, idEmpresa);
                ValorTotal = Recursos.Sum(p => p.Valor) / Recursos.Count;
                RecursosValiosos = Recursos.Where(p => p.Valor >= ValorTotal).ToList();
            }

            return RecursosValiosos;
        }



        public static List<RecursoValioso> CalcularResultadosCaracteritica(List<MatrizValoracion> Matriz, short IdEmpresa)
        {
            List<EscalaValoracion> escalaValoracion = MaestrosDA.ConsultarEscalaValoracion(IdEmpresa);
            List<RecursosEmpresa> recursosEmpresa = MaestrosDA.ConsultarRecursos(IdEmpresa);
            List<RecursoValioso> RecursosValiosos = new List<RecursoValioso>();

            foreach (EscalaValoracion item in escalaValoracion)
            {

                List<MatrizValoracion> MatrizCaracteristica = Matriz.Where(p => p.IdCaracteristica == item.IdCaracteristica).Distinct().ToList();
                decimal ValorTotalCaracteristica = 0;
                foreach (MatrizValoracion itemCaracteristica in MatrizCaracteristica)
                {
                    decimal ValorClasificacion = escalaValoracion.Where(p => p.IdClasificacion == itemCaracteristica.IdClasificacion).Sum(p => p.Valor);
                    decimal ValorCaracteristica = item.Valor;
                    
                    ValorTotalCaracteristica += itemCaracteristica.Valor * (ValorCaracteristica / 100) * (ValorClasificacion / 100);                    
                }
                RecursosValiosos.Add(new RecursoValioso {Valor = ValorTotalCaracteristica, NombreCaracteristica = escalaValoracion.Where(p => p.IdCaracteristica == item.IdCaracteristica).Single().Caracteristica });
            }
            return RecursosValiosos;
        }
    }
}
