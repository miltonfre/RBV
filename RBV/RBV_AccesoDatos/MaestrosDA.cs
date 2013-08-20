using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RBV_Clases;
using System.Data.Linq;

namespace RBV_AccesoDatos
{
    public class MaestrosDA
    {

        #region Clasificacion

        public static void InsertarClasificacion(Clasificacion clasificacion)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            contextoRBV.clasificacionRecursoValiosos.InsertOnSubmit(new clasificacionRecursoValioso
            {
               clasificacionRV = clasificacion.ClasificacionRV
            });

            contextoRBV.SubmitChanges();
        }

        public static void ActualizarClasificacion(Clasificacion clasificacion)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            clasificacionRecursoValioso clasificacionAnterior = new clasificacionRecursoValioso();

            clasificacionAnterior = contextoRBV.clasificacionRecursoValiosos.SingleOrDefault(p => p.idClasificacionRV == clasificacion.IdClasificacionRV); 
            clasificacionAnterior.clasificacionRV = clasificacion.ClasificacionRV;

            contextoRBV.SubmitChanges();
        }

        public static void EliminarClasificacion(short IdClasificacion)
        {
            RBVDataContext contextoRBV = new RBVDataContext();
            clasificacionRecursoValioso clasificacion = new clasificacionRecursoValioso();

            clasificacion = contextoRBV.clasificacionRecursoValiosos.SingleOrDefault(p => p.idClasificacionRV == IdClasificacion); 
            contextoRBV.clasificacionRecursoValiosos.DeleteOnSubmit(clasificacion);
            contextoRBV.SubmitChanges();
        }
                
        public static List<Clasificacion> ConsultarClasificaciones()
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            List<Clasificacion> clasificaciones = new List<Clasificacion>();

            clasificaciones = (from clasificacion in contextoRBV.clasificacionRecursoValiosos 
                           
                           select new Clasificacion
                           {
                               IdClasificacionRV = clasificacion.idClasificacionRV,
                               ClasificacionRV = clasificacion.clasificacionRV
                           }).ToList();


            return clasificaciones;
        }
#endregion

        #region Sector

        public static void InsertarSector(Sector sector)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            contextoRBV.sectors.InsertOnSubmit (new sector
            {
                sector1 = sector.NombreSector
            });

            contextoRBV.SubmitChanges();
        }

        public static void ActualizarSector(Sector sector)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            sector sectorAnterior = new sector();

            sectorAnterior = contextoRBV.sectors.SingleOrDefault(p => p.idSector == sector.IdSector);
            sectorAnterior.sector1 = sector.NombreSector;

            contextoRBV.SubmitChanges();
        }

        public static void EliminarSector(short IdSector)
        {
            RBVDataContext contextoRBV = new RBVDataContext();
            sector sectorEliminar = new sector();

            sectorEliminar = contextoRBV.sectors.SingleOrDefault(p => p.idSector == IdSector);
            contextoRBV.sectors.DeleteOnSubmit(sectorEliminar);
            contextoRBV.SubmitChanges();
        }

        public static List<Sector> ConsultarSectores()
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            List<Sector> sectores = new List<Sector>();

            sectores = (from sectorC in contextoRBV.sectors

                               select new Sector
                               {
                                   IdSector = sectorC.idSector,
                                   NombreSector = sectorC.sector1
                               }).ToList();


            return sectores;
        }
        
        #endregion

        #region TipoRecurso

        public static void InsertarTipoRecurso(TipoRecurso tipoRecurso)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            contextoRBV.tipoRecursos.InsertOnSubmit(new tipoRecurso
            {
                tipoRecurso1 = tipoRecurso.NombreTipoRecurso
            });

            contextoRBV.SubmitChanges();
        }

        public static void ActualizarTipoRecurso(TipoRecurso tipoRecurso)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            tipoRecurso tipoRecursoAnterior = new tipoRecurso();

            tipoRecursoAnterior = contextoRBV.tipoRecursos.SingleOrDefault(p => p.idTipoRecurso == tipoRecurso.IdTipoRecurso);
            tipoRecursoAnterior.tipoRecurso1 = tipoRecurso.NombreTipoRecurso;

            contextoRBV.SubmitChanges();
        }

        public static void EliminarTipoRecurso(short IdTipoRecurso)
        {
            RBVDataContext contextoRBV = new RBVDataContext();
            tipoRecurso tipoRecursoEliminar = new tipoRecurso();

            tipoRecursoEliminar = contextoRBV.tipoRecursos.SingleOrDefault(p => p.idTipoRecurso == IdTipoRecurso);
            contextoRBV.tipoRecursos.DeleteOnSubmit(tipoRecursoEliminar);
            contextoRBV.SubmitChanges();
        }

        public static List<TipoRecurso> ConsultarTiposRecurso()
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            List<TipoRecurso> tiposRecurso = new List<TipoRecurso>();

            tiposRecurso = (from tipoRecursoC in contextoRBV.tipoRecursos

                        select new TipoRecurso
                        {
                            IdTipoRecurso = tipoRecursoC.idTipoRecurso,
                            NombreTipoRecurso = tipoRecursoC.tipoRecurso1
                        }).ToList();


            return tiposRecurso;
        }

        #endregion
    }
}
