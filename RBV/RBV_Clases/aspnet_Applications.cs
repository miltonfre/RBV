//------------------------------------------------------------------------------
// Clase aspnet_Applications generada autom�ticamente con CrearClaseSQL
// de la tabla 'aspnet_Applications' de la base 'RBV'
// Fecha: 18/ago/2013 23:57:00
//
// �Guillermo 'guille' Som, 2004-2013
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
//
public class aspnet_Applications{
    // Las variables privadas
    // TODO: Revisar los tipos de los campos
    private System.Int16 _idCaracteristicaRV;
    private System.String _caracteristicaRV;
    private System.Int16 _idClasificacionRV;
    private System.Int16 _idUsuarioEmpresa;
    private System.Int16 _idEmpresa;
    private System.Guid _UserId;
    private System.String _ApplicationName;
    private System.String _LoweredApplicationName;
    private System.Guid _ApplicationId;
    private System.String _Description;
    //
    // Este m�todo se usar� para ajustar los anchos de las propiedades
    private string ajustarAncho(string cadena, int ancho){
        System.Text.StringBuilder sb = new System.Text.StringBuilder(new String(' ', ancho));
        // devolver la cadena quitando los espacios en blanco
        // esto asegura que no se devolver� un tama�o mayor ni espacios "extras"
        return (cadena + sb.ToString()).Substring(0, ancho).Trim();
    }
    //
    // Las propiedades p�blicas
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
    public System.Int16 idUsuarioEmpresa{
        get{
            return  _idUsuarioEmpresa;
        }
        set{
            _idUsuarioEmpresa = value;
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
    public System.Guid UserId{
        get{
            return  _UserId;
        }
        set{
            _UserId = value;
        }
    }
    public System.String ApplicationName{
        get{
            // Seguramente ser�a mejor sin ajustar el ancho...
            //return ajustarAncho(_ApplicationName,256);
            return  _ApplicationName;
        }
        set{
            _ApplicationName = value;
        }
    }
    public System.String LoweredApplicationName{
        get{
            // Seguramente ser�a mejor sin ajustar el ancho...
            //return ajustarAncho(_LoweredApplicationName,256);
            return  _LoweredApplicationName;
        }
        set{
            _LoweredApplicationName = value;
        }
    }
    public System.Guid ApplicationId{
        get{
            return  _ApplicationId;
        }
        set{
            _ApplicationId = value;
        }
    }
    public System.String Description{
        get{
            // Seguramente ser�a mejor sin ajustar el ancho...
            //return ajustarAncho(_Description,256);
            return  _Description;
        }
        set{
            _Description = value;
        }
    }
 
}
