using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RBV_Clases
{
    [Serializable]
    public class RolesInforme
    {

        private int _idRolInforme;
        private string _nombreParticipante;
        private string _rol;
        private Informe _informe;

        public int IdRolInforme
        {
            get { return _idRolInforme; }
            set { _idRolInforme = value; }
        }
       

        public string NombreParticipante
        {
            get { return _nombreParticipante; }
            set { _nombreParticipante = value; }
        }
        

        public string Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }
       

        public Informe Informe
        {
            get { return _informe; }
            set { _informe = value; }
        }
    }
}
