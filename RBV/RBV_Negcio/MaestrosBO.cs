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
    }
}
