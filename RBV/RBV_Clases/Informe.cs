using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RBV_Clases
{
    [Serializable]
    public class Informe
    {
        private int _idInforme;
        private string _titulo;
        private Empresa _empresa;
        private DateTime _fechaGeneracion;
        private string _rutaArchivo;
        private List<RolesInforme> _rolesInforme;

        public List<RolesInforme> RolesInforme
        {
            get { return _rolesInforme; }
            set { _rolesInforme = value; }
        }


        public int IdInforme
        {
            get { return _idInforme; }
            set { _idInforme = value; }
        }
    

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }
        

        public Empresa Empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }
   
        public DateTime FechaGeneracion
        {
            get { return _fechaGeneracion; }
            set { _fechaGeneracion = value; }
        }
        

        public string RutaArchivo
        {
            get { return _rutaArchivo; }
            set { _rutaArchivo = value; }
        }
    }
}
