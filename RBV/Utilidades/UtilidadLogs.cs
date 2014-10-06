using System;
using System.Collections.Generic;
using System.Text;
using log4net;

namespace Utilidades
{
    public class UtilidadLogs
    {
        //private static readonly ILog logger = LogManager.GetLogger(typeof(UtilidadLogs));

        public static void RegistrarError(Exception e, Type tipo)
        {
            ILog logger = LogManager.GetLogger(tipo);
            logger.Error("Error:", e);
        }

        public static void RegistrarError(string mensaje, Exception e, Type tipo)
        {
            ILog logger = LogManager.GetLogger(tipo);
            logger.Error(mensaje, e);
        }

        public static void RegistrarInfo(string mensaje, Type tipo)
        {
            ILog logger = LogManager.GetLogger(tipo);
            logger.Info(mensaje);
        }

        public static void RegistrarDebug(string mensaje, Type tipo)
        {
            ILog logger = LogManager.GetLogger(tipo);
            logger.Debug(mensaje);
        }

        public static void RegistrarWarn(string mensaje, Type tipo)
        {
            ILog logger = LogManager.GetLogger(tipo);
            logger.Warn(mensaje);
        }

        public static void RegistrarError(string p)
        {
            throw new NotImplementedException();
        }
    }
}
