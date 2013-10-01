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

        /// <summary>
        /// Método que devuelve las características de una misma clasificación
        /// </summary>
        /// <param name="caracteristica">clasificación a consultar</param>
        /// <returns></returns>
        public static List<Caracteristica> ConsultarCaracteristicasxClasificacion(Clasificacion clasificacion)
        {
           RBVDataContext contextoRBV = new RBVDataContext();

                        List<Caracteristica> caracteristicas = new List<Caracteristica>();

                        caracteristicas = (from caracteristicaC in contextoRBV.caracteristicaRecursoValiosos
                                           where caracteristicaC.idClasificacionRV == clasificacion.IdClasificacionRV
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

            empresa empresa = new empresa();
            empresa.nit = empresaInsertar.Nit;
            empresa.nombreEmpresa = empresaInsertar.NombreEmpresa;
            empresa.represetanteLegal = empresaInsertar.RepresetanteLegal;

            //contextoRBV.empresas.InsertOnSubmit(new empresa
            //{
            //    nombreEmpresa = empresaInsertar.NombreEmpresa,
            //    nit = empresaInsertar.Nit,
            //    represetanteLegal = empresaInsertar.RepresetanteLegal,
            //    idEmpresa = empresaInsertar.IdEmpresa
            //});
            contextoRBV.empresas.InsertOnSubmit(empresa);
            
            contextoRBV.SubmitChanges();
            (from sectorC in empresaInsertar.SectoresEmpresas select sectorC.IdEmpresa = empresa.idEmpresa).ToList();

            if (empresaInsertar.SectoresEmpresas.Count > 0)
            {
                InsertarEmpresaSector(empresaInsertar.SectoresEmpresas);
            }
            
            empresaInsertar.EmpresasUsuarios.UserId = contextoRBV.aspnet_Users.SingleOrDefault(p => p.UserName == empresaInsertar.EmpresasUsuarios.UserName).UserId;

            empresaInsertar.EmpresasUsuarios.IdEmpresa = empresa.idEmpresa;
            InsertarEmpresaUsuario(empresaInsertar.EmpresasUsuarios);
        }

        public static void ActualizarEmpresa(Empresa empresaActualizar)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            empresa empresaAnterior = new empresa();

            empresaAnterior = contextoRBV.empresas.SingleOrDefault(p => p.idEmpresa == empresaActualizar.IdEmpresa);
            empresaAnterior.nombreEmpresa = empresaActualizar.NombreEmpresa;
            empresaAnterior.represetanteLegal = empresaActualizar.RepresetanteLegal;
            empresaAnterior.nit = empresaActualizar.Nit;

            (from sectorC in empresaActualizar.SectoresEmpresas select sectorC.IdEmpresa = empresaActualizar.IdEmpresa).ToList();
            
            contextoRBV.SubmitChanges();

            ActualizarEmpresaSector(empresaActualizar.SectoresEmpresas);
        }

        public static void EliminarEmpresa(short IdEmpresa, string Usuario)
        {
            RBVDataContext contextoRBV = new RBVDataContext();
            empresa empresaEliminar = new empresa();
            empresaUsuario empresaUsuarioEliminar = new empresaUsuario();
            EliminarEmpresaSector(IdEmpresa);
            
            empresaEliminar = contextoRBV.empresas.SingleOrDefault(p => p.idEmpresa  == IdEmpresa);

            Guid idUsuario = contextoRBV.aspnet_Users.SingleOrDefault(p => p.UserName == Usuario).UserId;

            empresaUsuarioEliminar = contextoRBV.empresaUsuarios.SingleOrDefault(p => p.idEmpresa == IdEmpresa && p.UserId == idUsuario);

            contextoRBV.empresaUsuarios.DeleteOnSubmit(empresaUsuarioEliminar);
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
                            RepresetanteLegal = empresaC.represetanteLegal,
                            Nit = empresaC.nit,
                            SectoresEmpresas = (from sectorC in empresaC.sectorEmpresas 
                                                select new SectorEmpresa 
                                                { 
                                                    IdSector = sectorC.idSector, 
                                                    IdEmpresa = sectorC.idEmpresa 
                                                }).ToList()

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

        #region EmpresaSector
        private static void InsertarEmpresaSector(List<SectorEmpresa> SectoresEmpresas)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            contextoRBV.sectorEmpresas.InsertAllOnSubmit((from sectorC in SectoresEmpresas select new sectorEmpresa 
                                        { 
                                            idSector = sectorC.IdSector, 
                                            idEmpresa = sectorC.IdEmpresa 
                                        }).ToList());

            contextoRBV.SubmitChanges();
        }

        private static void ActualizarEmpresaSector(List<SectorEmpresa> SectoresEmpresas)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            List<sectorEmpresa> sectoresEmpresaEliminar = new List<sectorEmpresa>();

            sectoresEmpresaEliminar = contextoRBV.sectorEmpresas.Where(p => p.idEmpresa == SectoresEmpresas[0].IdEmpresa).ToList();
            contextoRBV.sectorEmpresas.DeleteAllOnSubmit(sectoresEmpresaEliminar);

            contextoRBV.sectorEmpresas.InsertAllOnSubmit((from sectorC in SectoresEmpresas
                                                          select new sectorEmpresa
                                                          {
                                                              idSector = sectorC.IdSector,
                                                              idEmpresa = sectorC.IdEmpresa
                                                          }).ToList());
            
            contextoRBV.SubmitChanges();            
        }

        private static void EliminarEmpresaSector(short IdEmpresa)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            List<sectorEmpresa> sectoresEmpresaEliminar = new List<sectorEmpresa>();

            sectoresEmpresaEliminar = contextoRBV.sectorEmpresas.Where(p => p.idEmpresa == IdEmpresa).ToList();
            contextoRBV.sectorEmpresas.DeleteAllOnSubmit(sectoresEmpresaEliminar);

            contextoRBV.SubmitChanges();            
        }

        public static List<SectorEmpresa> ConsultarSectorEmpresa(short IdEmpresa)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            List<SectorEmpresa> sectoresEmpresas = new List<SectorEmpresa>();


            sectoresEmpresas = (from sectorC in contextoRBV.sectorEmpresas
                                where sectorC.idEmpresa == IdEmpresa
                                select new SectorEmpresa
                                {
                                    IdEmpresa = sectorC.idEmpresa,
                                    IdSector = sectorC.idSector

                                }).ToList();

            return sectoresEmpresas;
        }
        #endregion

        #region EmpresaUsuario
        private static void InsertarEmpresaUsuario(EmpresaUsuario empresasUsuarios)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            contextoRBV.empresaUsuarios.InsertOnSubmit(new empresaUsuario
                                                          {
                                                              UserId = empresasUsuarios.UserId,
                                                              idEmpresa = empresasUsuarios.IdEmpresa
                                                          });

            contextoRBV.SubmitChanges();
        }
        #endregion

        #region Recursos

        public static void InsertarRecurso(RecursosEmpresa recursoInsertar)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            contextoRBV.recursosEmpresas.InsertOnSubmit(new recursosEmpresa
            {
                recurso = recursoInsertar.NombreRecurso,
                idTipoRecurso = recursoInsertar.TipoRecurso.IdTipoRecurso,
                Descripcion = recursoInsertar.DescripcionRecurso,
                idEmpresa = recursoInsertar.Empresa.IdEmpresa
            });

            contextoRBV.SubmitChanges();
        }

        public static void ActualizarRecurso(RecursosEmpresa recursoActualizar)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            recursosEmpresa recursoAnterior = new recursosEmpresa();

            recursoAnterior = contextoRBV.recursosEmpresas.SingleOrDefault(p => p.idRecursoEmpresa == recursoActualizar.IdRecursoEmpresa);
            recursoAnterior.recurso = recursoActualizar.NombreRecurso;
            recursoAnterior.Descripcion = recursoActualizar.DescripcionRecurso;
            recursoAnterior.idTipoRecurso = recursoActualizar.TipoRecurso.IdTipoRecurso;
            recursoAnterior.idEmpresa = recursoActualizar.Empresa.IdEmpresa;
                        
            contextoRBV.SubmitChanges();            
        }

        public static void EliminarRecurso(short IdRecurso)
        {
            RBVDataContext contextoRBV = new RBVDataContext();
            recursosEmpresa recursoEliminar = new recursosEmpresa();

            recursoEliminar = contextoRBV.recursosEmpresas.SingleOrDefault(p => p.idRecursoEmpresa == IdRecurso);
            contextoRBV.recursosEmpresas.DeleteOnSubmit(recursoEliminar);
            contextoRBV.SubmitChanges();
        }

        public static List<RecursosEmpresa> ConsultarRecursos(short IdEmpresa)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            List<RecursosEmpresa> recursos = new List<RecursosEmpresa>();

            recursos = (from recursoC in contextoRBV.recursosEmpresas
                        where recursoC.idEmpresa == IdEmpresa
                        select new RecursosEmpresa
                        {
                            IdRecursoEmpresa = recursoC.idRecursoEmpresa,
                            NombreRecurso = recursoC.recurso,
                            DescripcionRecurso = recursoC.Descripcion,
                            Empresa = new Empresa
                                       {
                                           IdEmpresa = recursoC.empresa.idEmpresa
                                       },
                            TipoRecurso = new TipoRecurso 
                                        { 
                                            IdTipoRecurso = recursoC.tipoRecurso.idTipoRecurso,
                                            NombreTipoRecurso = recursoC.tipoRecurso.tipoRecurso1
                                        }


                        }).ToList();


            return recursos;
        }

        #endregion

        public static List<EscalaValoracion> ConsultarEscalaValoracion(short IdEmpresa)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            List<EscalaValoracion> escalaValoracion = new List<EscalaValoracion>();

            escalaValoracion = (from escalaC in contextoRBV.escalaValoracions
                                join caracteristicaC in contextoRBV.caracteristicaRecursoValiosos
                                on escalaC.idCaracteristicaRV equals caracteristicaC.idCaracteristicaRV
                                  where (escalaC.idEmpresa == IdEmpresa)
                                  select new EscalaValoracion
                                  {
                                      IdEmpresa = escalaC.idEmpresa,
                                      IdCaracteristica = escalaC.idCaracteristicaRV,
                                      Caracteristica = caracteristicaC.caracteristicaRV,
                                      IdClasificacion = caracteristicaC.idClasificacionRV,
                                      Valor = escalaC.Valor
                                  }).ToList();


            return escalaValoracion;
        }

        public static List<EscalaValoracion> ConsultarEscalaValoracion(short IdEmpresa, short idCaracteristicaRV)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            List<EscalaValoracion> escalaValoracion = new List<EscalaValoracion>();

            escalaValoracion = (from escalaC in contextoRBV.escalaValoracions
                                join caracteristicaC in contextoRBV.caracteristicaRecursoValiosos
                                on escalaC.idCaracteristicaRV equals caracteristicaC.idCaracteristicaRV
                                where (escalaC.idEmpresa == IdEmpresa && escalaC.idCaracteristicaRV == idCaracteristicaRV)
                                select new EscalaValoracion
                                {
                                    IdEmpresa = escalaC.idEmpresa,
                                    IdCaracteristica = escalaC.idCaracteristicaRV,
                                    Caracteristica = caracteristicaC.caracteristicaRV,
                                    Valor = escalaC.Valor
                                }).ToList();


            return escalaValoracion;
        }

        public static void InsertarEscalaValoracion(List<EscalaValoracion> escala)
        {
            try
            {
                RBVDataContext contextoRBV = new RBVDataContext();
                //se borra todas las escalas de valoración de la empresa
                foreach (EscalaValoracion escalaVal in escala)
                {
                    escalaValoracion escValEliminar = new escalaValoracion();
                    escValEliminar = contextoRBV.escalaValoracions.SingleOrDefault(p => p.idCaracteristicaRV == escalaVal.IdCaracteristica && p.idEmpresa == escalaVal.IdEmpresa);
                    contextoRBV.escalaValoracions.DeleteOnSubmit(escValEliminar);
                    contextoRBV.SubmitChanges();
                }
                List<escalaValoracion> escalasValoracion = new List<escalaValoracion>();
                escalasValoracion = (from escal in escala
                                     select new escalaValoracion
                                     {
                                         idCaracteristicaRV = escal.IdCaracteristica,
                                         idEmpresa = escal.IdEmpresa,
                                         Valor = escal.Valor
                                     }).ToList();

                contextoRBV.escalaValoracions.InsertAllOnSubmit(escalasValoracion);
                contextoRBV.SubmitChanges();
            }
            catch (Exception ex)
            {
                Utilidades.UtilidadLogs.RegistrarError("Error insertando escalas de Valoración", ex, ex.GetType());
                throw new Exception("Error insertando escalas de Valoración", ex);
            }
        }
    }
}
