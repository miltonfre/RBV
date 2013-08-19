//------------------------------------------------------------------------------
// Clase tipoRecurso generada automáticamente con CrearClaseSQL
// de la tabla 'tipoRecurso' de la base 'RBV'
// Fecha: 18/ago/2013 23:58:42
//
// ©Guillermo 'guille' Som, 2004-2013
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
//
public class tipoRecurso{
    // Las variables privadas
    // TODO: Revisar los tipos de los campos
    private System.Int16 _idCaracteristicaRV;
    private System.String _caracteristicaRV;
    private System.Int16 _idClasificacionRV;
    private System.Int16 _idEmpresa;
    private System.Decimal _Valor;
    private System.Int16 _idTipoRecurso;
    private System.String _tipoRecurso;
    //
    // Este método se usará para ajustar los anchos de las propiedades
    private string ajustarAncho(string cadena, int ancho){
        System.Text.StringBuilder sb = new System.Text.StringBuilder(new String(' ', ancho));
        // devolver la cadena quitando los espacios en blanco
        // esto asegura que no se devolverá un tamaño mayor ni espacios "extras"
        return (cadena + sb.ToString()).Substring(0, ancho).Trim();
    }
    //
    // Las propiedades públicas
    // TODO: Revisar los tipos de las propiedades
    public System.Int16 idCaracteristicaRV{
        get{
            return  _idCaracteristicaRV;
        }
        set{
            _idCaracteristicaRV = value;
        }
    }
    public System.String caracteristicaRV{
        get{
            return ajustarAncho(_caracteristicaRV,50);
        }
        set{
            _caracteristicaRV = value;
        }
    }
    public System.Int16 idClasificacionRV{
        get{
            return  _idClasificacionRV;
        }
        set{
            _idClasificacionRV = value;
        }
    }
    public System.Int16 idEmpresa{
        get{
            return  _idEmpresa;
        }
        set{
            _idEmpresa = value;
        }
    }
    public System.Decimal Valor{
        get{
            return  _Valor;
        }
        set{
            _Valor = value;
        }
    }
    public System.Int16 idTipoRecurso{
        get{
            return  _idTipoRecurso;
        }
        set{
            _idTipoRecurso = value;
        }
    }
    public System.String strTipoRecurso{
        get{
            return ajustarAncho(_tipoRecurso,50);
        }
        set{
            _tipoRecurso = value;
        }
    }
 
}
