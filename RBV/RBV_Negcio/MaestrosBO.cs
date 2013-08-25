using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos = RBV_AccesoDatos;
using RBV_Clases;

namespace RBV_Negocio
{
    public class MaestrosBO
    {
        #region Clasificaciones
        public static void InsertarClasificacion(Clasificacion clasificacion)
        {
            Datos.MaestrosDA.InsertarClasificacion(clasificacion);
        }

        public static List<Clasificacion> ConsultarClasificaciones()
        {
            return Datos.MaestrosDA.ConsultarClasificaciones();
        }

        public static void ActualizarClasificacion(Clasificacion clasificacion)
        {
            Datos.MaestrosDA.ActualizarClasificacion(clasificacion);
        }

        public static void EliminarClasificacion(short IdClasificacion)
        {
            Datos.MaestrosDA.EliminarClasificacion(IdClasificacion);   
        }

        #endregion

        #region Sector
        public static void InsertarSector(Sector sector)
        {
            Datos.MaestrosDA.InsertarSector(sector);
        }

        public static List<Sector> ConsultarSectores()
        {
            return Datos.MaestrosDA.ConsultarSectores();
        }

        public static void ActualizarSector(Sector sector)
        {
            Datos.MaestrosDA.ActualizarSector(sector);
        }

        public static void EliminarSector(short IdSector)
        {
            Datos.MaestrosDA.EliminarSector(IdSector);
        }
        #endregion
        
        #region TipoRecurso

        public static void InsertarTipoRecurso(TipoRecurso tipoRecurso)
        {
            Datos.MaestrosDA.InsertarTipoRecurso(tipoRecurso);
        }

        public static void ActualizarTipoRecurso(TipoRecurso tipoRecurso)
        {
            Datos.MaestrosDA.ActualizarTipoRecurso(tipoRecurso);
        }

        public static void EliminarTipoRecurso(short IdTipoRecurso)
        {
            Datos.MaestrosDA.EliminarTipoRecurso(IdTipoRecurso);
        }

        public static List<TipoRecurso> ConsultarTiposRecurso()
        {
            return Datos.MaestrosDA.ConsultarTiposRecurso();
        }

        #endregion

        #region Caracteristica

        public static void InsertarCaracteristica(Caracteristica caracteristica)
        {
            Datos.MaestrosDA.InsertarCaracteristica(caracteristica);
        }

        public static void ActualizarCaracteristica(Caracteristica caracteristica)
        {
           Datos.MaestrosDA.ActualizarCaracteristica(caracteristica);
        }

        public static void EliminarCaracteristica(short IdCaracteristica)
        {
            Datos.MaestrosDA.EliminarCaracteristica(IdCaracteristica);
        }

        public static List<Caracteristica> ConsultarCaracteristicas()
        {
            return Datos.MaestrosDA.ConsultarCaracteristicas();
        }

        #endregion

        #region Empresa

        public static void InsertarEmpresa(Empresa empresaInsertar)
        {
            Datos.MaestrosDA.InsertarEmpresa(empresaInsertar);
        }

        public static void ActualizarEmpresa(Empresa empresaActualizar)
        {
            Datos.MaestrosDA.ActualizarEmpresa(empresaActualizar);
        }

        public static void EliminarEmpresa(short IdEmpresa)
        {
            Datos.MaestrosDA.EliminarEmpresa(IdEmpresa);
        }

        public static List<Empresa> ConsultarEmpresas()
        {
            return Datos.MaestrosDA.ConsultarEmpresas();
        }

        #endregion

        #region EscalaCalificacion

        public static void InsertarEscalaCalificacion(EscalaCalificacion escalaCalificacionInsertar)
        {
            Datos.MaestrosDA.InsertarEscalaCalificacion(escalaCalificacionInsertar);
        }

        public static void ActualizarEscalaCalificacion(EscalaCalificacion escalaCalificacionActualizar)
        {
            Datos.MaestrosDA.ActualizarEscalaCalificacion(escalaCalificacionActualizar);
        }

        public static void EliminarEscalaCalificacion(short IdEscalaCalificacion)
        {
            Datos.MaestrosDA.EliminarEscalaCalificacion(IdEscalaCalificacion);
        }

        public static List<EscalaCalificacion> ConsultarEscalaCalificaciones(short IdEmpresa)
        {
            return Datos.MaestrosDA.ConsultarEscalaCalificaciones(IdEmpresa);
        }

        #endregion

        #region SectorEmpresa

        public static List<SectorEmpresa> ConsultarSectorEmpresa(short IdEmpresa)
        {
            return Datos.MaestrosDA.ConsultarSectorEmpresa(IdEmpresa);
        }
        #endregion

        #region Recursos

        public static void InsertarRecurso(RecursosEmpresa recursoInsertar)
        {
            Datos.MaestrosDA.InsertarRecurso(recursoInsertar);
        }

        public static void ActualizarRecurso(RecursosEmpresa recursoActualizar)
        {
            Datos.MaestrosDA.ActualizarRecurso(recursoActualizar);
        }

        public static void EliminarRecurso(short IdRecurso)
        {
            Datos.MaestrosDA.EliminarRecurso(IdRecurso);
        }

        public static List<RecursosEmpresa> ConsultarRecursos(short IdEmpresa)
        {
            return Datos.MaestrosDA.ConsultarRecursos(IdEmpresa);
        }

        #endregion
    }
}
