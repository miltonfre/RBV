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

        #region Caracteristica

        public static void InsertarCaracteristica(Caracteristica caracteristica)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            contextoRBV.caracteristicaRecursoValiosos.InsertOnSubmit(new caracteristicaRecursoValioso
            {
                caracteristicaRV = caracteristica.NombreCaracteristica
                ,idClasificacionRV = caracteristica.IdClasificacionRV
            });

            contextoRBV.SubmitChanges();
        }

        public static void ActualizarCaracteristica(Caracteristica caracteristica)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            caracteristicaRecursoValioso caracteristicaAnterior = new caracteristicaRecursoValioso();

            caracteristicaAnterior = contextoRBV.caracteristicaRecursoValiosos.SingleOrDefault(p => p.idCaracteristicaRV == caracteristica.IdCaracteristica);
            caracteristicaAnterior.caracteristicaRV = caracteristica.NombreCaracteristica;
            caracteristicaAnterior.idClasificacionRV = caracteristica.IdClasificacionRV;

            contextoRBV.SubmitChanges();
        }

        public static void EliminarCaracteristica(short IdCaracteristica)
        {
            RBVDataContext contextoRBV = new RBVDataContext();
            caracteristicaRecursoValioso caracteristicaEliminar = new caracteristicaRecursoValioso();

            caracteristicaEliminar = contextoRBV.caracteristicaRecursoValiosos.SingleOrDefault(p => p.idCaracteristicaRV == IdCaracteristica);
            contextoRBV.caracteristicaRecursoValiosos.DeleteOnSubmit(caracteristicaEliminar);
            contextoRBV.SubmitChanges();
        }

        public static List<Caracteristica> ConsultarCaracteristicas()
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            List<Caracteristica> caracteristicas = new List<Caracteristica>();

            caracteristicas = (from caracteristicaC in contextoRBV.caracteristicaRecursoValiosos

                               select new Caracteristica
                               {
                                   IdCaracteristica = caracteristicaC.idCaracteristicaRV,
                                   NombreCaracteristica = caracteristicaC.caracteristicaRV,
                                   IdClasificacionRV = caracteristicaC.idClasificacionRV,
                                   ClasificacionAsociada = new Clasificacion
                                   {
                                       IdClasificacionRV = caracteristicaC.clasificacionRecursoValioso.idClasificacionRV,
                                       ClasificacionRV = caracteristicaC.clasificacionRecursoValioso.clasificacionRV
                                   }
                               }).ToList();


            return caracteristicas;
        }

        #endregion

        #region Empresa

        public static void InsertarEmpresa(Empresa empresaInsertar)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            contextoRBV.empresas.InsertOnSubmit(new empresa
            {
                nombreEmpresa = empresaInsertar.NombreEmpresa,
                nit = empresaInsertar.Nit,
                represetanteLegal = empresaInsertar.RepresetanteLegal
            });

            contextoRBV.SubmitChanges();
        }

        public static void ActualizarEmpresa(Empresa empresaActualizar)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            empresa empresaAnterior = new empresa();

            empresaAnterior = contextoRBV.empresas.SingleOrDefault(p => p.idEmpresa == empresaActualizar.IdEmpresa);
            empresaAnterior.nombreEmpresa = empresaActualizar.NombreEmpresa;
            empresaAnterior.represetanteLegal = empresaActualizar.RepresetanteLegal;
            empresaAnterior.nit = empresaActualizar.Nit;

            contextoRBV.SubmitChanges();
        }

        public static void EliminarEmpresa(short IdEmpresa)
        {
            RBVDataContext contextoRBV = new RBVDataContext();
            empresa empresaEliminar = new empresa();

            empresaEliminar = contextoRBV.empresas.SingleOrDefault(p => p.idEmpresa  == IdEmpresa);
            contextoRBV.empresas.DeleteOnSubmit(empresaEliminar);
            contextoRBV.SubmitChanges();
        }

        public static List<Empresa> ConsultarEmpresas()
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            List<Empresa> empresas = new List<Empresa>();

            empresas = (from empresaC in contextoRBV.empresas

                               select new Empresa
                               {
                                   IdEmpresa = empresaC.idEmpresa,
                                   NombreEmpresa = empresaC.nombreEmpresa,
                                   RepresetanteLegal = empresaC.represetanteLegal ,
                                   Nit = empresaC.nit
                               }).ToList();


            return empresas;
        }

        #endregion

        #region EscalaCalificacion

        public static void InsertarEscalaCalificacion(EscalaCalificacion escalaCalificacionInsertar)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            contextoRBV.escalaCalificacions.InsertOnSubmit(new escalaCalificacion
            {
                Escala = escalaCalificacionInsertar.Escala,
                Valor = escalaCalificacionInsertar.Valor,
                idEmpresa = escalaCalificacionInsertar.IdEmpresa
            });

            contextoRBV.SubmitChanges();
        }

        public static void ActualizarEscalaCalificacion(EscalaCalificacion escalaCalificacionActualizar)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            escalaCalificacion escalaCalificacionAnterior = new escalaCalificacion();

            escalaCalificacionAnterior = contextoRBV.escalaCalificacions.SingleOrDefault(p => p.IdEscalaCalificacion == escalaCalificacionActualizar.IdEscalaCalificacion);
            escalaCalificacionAnterior.idEmpresa = escalaCalificacionActualizar.IdEmpresa;
            escalaCalificacionAnterior.Valor = escalaCalificacionActualizar.Valor;
            escalaCalificacionAnterior.Escala = escalaCalificacionActualizar.Escala;

            contextoRBV.SubmitChanges();
        }

        public static void EliminarEscalaCalificacion(short IdEscalaCalificacion)
        {
            RBVDataContext contextoRBV = new RBVDataContext();
            escalaCalificacion escalaCalificacionEliminar = new escalaCalificacion();

            escalaCalificacionEliminar = contextoRBV.escalaCalificacions.SingleOrDefault(p => p.IdEscalaCalificacion == IdEscalaCalificacion);
            contextoRBV.escalaCalificacions.DeleteOnSubmit(escalaCalificacionEliminar);
            contextoRBV.SubmitChanges();
        }

        public static List<EscalaCalificacion> ConsultarEscalaCalificaciones(short IdEmpresa)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            List<EscalaCalificacion> escalaCalificacion = new List<EscalaCalificacion>();

            escalaCalificacion = (from escalaC in contextoRBV.escalaCalificacions
                                  where (escalaC.idEmpresa == IdEmpresa)
                        select new EscalaCalificacion
                        {
                            IdEmpresa = escalaC.idEmpresa,
                            IdEscalaCalificacion = escalaC.IdEscalaCalificacion,
                            Escala = escalaC.Escala,
                            Valor = escalaC.Valor
                        }).ToList();


            return escalaCalificacion;
        }

        #endregion
    }
}
