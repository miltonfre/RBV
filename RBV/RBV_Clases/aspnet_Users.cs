//------------------------------------------------------------------------------
// Clase aspnet_Users generada automáticamente con CrearClaseSQL
// de la tabla 'aspnet_Users' de la base 'RBV'
// Fecha: 18/ago/2013 23:57:07
//
// ©Guillermo 'guille' Som, 2004-2013
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
//
public class aspnet_Users{
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
    private System.String _UserName;
    private System.String _LoweredUserName;
    private System.String _MobileAlias;
    private System.Boolean _IsAnonymous;
    private System.DateTime _LastActivityDate;
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
            // Seguramente sería mejor sin ajustar el ancho...
            //return ajustarAncho(_ApplicationName,256);
            return  _ApplicationName;
        }
        set{
            _ApplicationName = value;
        }
    }
    public System.String LoweredApplicationName{
        get{
            // Seguramente sería mejor sin ajustar el ancho...
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
            // Seguramente sería mejor sin ajustar el ancho...
            //return ajustarAncho(_Description,256);
            return  _Description;
        }
        set{
            _Description = value;
        }
    }
    public System.String UserName{
        get{
            // Seguramente sería mejor sin ajustar el ancho...
            //return ajustarAncho(_UserName,256);
            return  _UserName;
        }
        set{
            _UserName = value;
        }
    }
    public System.String LoweredUserName{
        get{
            // Seguramente sería mejor sin ajustar el ancho...
            //return ajustarAncho(_LoweredUserName,256);
            return  _LoweredUserName;
        }
        set{
            _LoweredUserName = value;
        }
    }
    public System.String MobileAlias{
        get{
            return ajustarAncho(_MobileAlias,16);
        }
        set{
            _MobileAlias = value;
        }
    }
    public System.Boolean IsAnonymous{
        get{
            return  _IsAnonymous;
        }
        set{
            _IsAnonymous = value;
        }
    }
    public System.DateTime LastActivityDate{
        get{
            return  _LastActivityDate;
        }
        set{
            _LastActivityDate = value;
        }
    }
}
