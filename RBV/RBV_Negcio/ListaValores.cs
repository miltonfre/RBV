using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RBV_Clases
{
    /// <summary>
    /// Clase que contiene el listado de valores para la generación de grafico en el informe de word
    /// </summary>
    public class ListaValores
    {
        private string _propiedadName;
        private string _valueName;
        public string PropiedadName
        {
            get
            {
                return _propiedadName;
            }
            set
            {
                _propiedadName = value;
            }
        }


        public string ValueName
        {
            get
            {
                return _valueName;
            }
            set
            {
                _valueName = value;
            }
        }
    }
}
