//------------------------------------------------------------------------------
// Clase aspnet_Paths generada automáticamente con CrearClaseSQL
// de la tabla 'aspnet_Paths' de la base 'RBV'
// Fecha: 19/ago/2013 00:00:23
//
// ©Guillermo 'guille' Som, 2004-2013
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
//
public class aspnet_Paths{
    // Las variables privadas
    // TODO: Revisar los tipos de los campos
    private System.Int16 _idCaracteristicaRV;
    private System.String _caracteristicaRV;
    private System.Int16 _idClasificacionRV;
    private System.Int16 _idEmpresa;
    private System.Decimal _Valor;
    private System.Int16 _idTipoRecurso;
    private System.String _tipoRecurso;
    private System.Int16 _idRecursoEmpresa;
    private System.String _recurso;
    private System.String _Descripcion;
    private System.Int16 _IdEscalaCalificacion;
    private System.String _Escala;
    private System.String _nit;
    private System.String _nombreEmpresa;
    private System.String _represetanteLegal;
    private System.Guid _UserId;
    private System.String _PropertyNames;
    private System.String _PropertyValuesString;
    private System.Byte[] _PropertyValuesBinary;
    private System.DateTime _LastUpdatedDate;
    private System.Int16 _idSector;
    private System.String _sector;
    private System.Guid _ApplicationId;
    private System.Guid _RoleId;
    private System.String _RoleName;
    private System.String _LoweredRoleName;
    private System.String _Description;
    private System.Guid _PathId;
    private System.String _Path;
    private System.String _LoweredPath;
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
    public System.String tipoRecurso{
        get{
            return ajustarAncho(_tipoRecurso,50);
        }
        set{
            _tipoRecurso = value;
        }
    }
    public System.Int16 idRecursoEmpresa{
        get{
            return  _idRecursoEmpresa;
        }
        set{
            _idRecursoEmpresa = value;
        }
    }
    public System.String recurso{
        get{
            return ajustarAncho(_recurso,50);
        }
        set{
            _recurso = value;
        }
    }
    public System.String Descripcion{
        get{
            // Seguramente sería mejor sin ajustar el ancho...
            //return ajustarAncho(_Descripcion,500);
            return  _Descripcion;
        }
        set{
            _Descripcion = value;
        }
    }
    public System.Int16 IdEscalaCalificacion{
        get{
            return  _IdEscalaCalificacion;
        }
        set{
            _IdEscalaCalificacion = value;
        }
    }
    public System.String Escala{
        get{
            return ajustarAncho(_Escala,50);
        }
        set{
            _Escala = value;
        }
    }
    public System.String nit{
        get{
            return ajustarAncho(_nit,50);
        }
        set{
            _nit = value;
        }
    }
    public System.String nombreEmpresa{
        get{
            return ajustarAncho(_nombreEmpresa,50);
        }
        set{
            _nombreEmpresa = value;
        }
    }
    public System.String represetanteLegal{
        get{
            return ajustarAncho(_represetanteLegal,10);
        }
        set{
            _represetanteLegal = value;
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
    public System.String PropertyNames{
        get{
            // Seguramente sería mejor sin ajustar el ancho...
            //return ajustarAncho(_PropertyNames,1073741823);
            return  _PropertyNames;
        }
        set{
            _PropertyNames = value;
        }
    }
    public System.String PropertyValuesString{
        get{
            // Seguramente sería mejor sin ajustar el ancho...
            //return ajustarAncho(_PropertyValuesString,1073741823);
            return  _PropertyValuesString;
        }
        set{
            _PropertyValuesString = value;
        }
    }
    
    public System.DateTime LastUpdatedDate{
        get{
            return  _LastUpdatedDate;
        }
        set{
            _LastUpdatedDate = value;
        }
    }
    public System.Int16 idSector{
        get{
            return  _idSector;
        }
        set{
            _idSector = value;
        }
    }
    public System.String sector{
        get{
            return ajustarAncho(_sector,50);
        }
        set{
            _sector = value;
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
    public System.Guid RoleId{
        get{
            return  _RoleId;
        }
        set{
            _RoleId = value;
        }
    }
    public System.String RoleName{
        get{
            // Seguramente sería mejor sin ajustar el ancho...
            //return ajustarAncho(_RoleName,256);
            return  _RoleName;
        }
        set{
            _RoleName = value;
        }
    }
    public System.String LoweredRoleName{
        get{
            // Seguramente sería mejor sin ajustar el ancho...
            //return ajustarAncho(_LoweredRoleName,256);
            return  _LoweredRoleName;
        }
        set{
            _LoweredRoleName = value;
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
    public System.Guid PathId{
        get{
            return  _PathId;
        }
        set{
            _PathId = value;
        }
    }
    public System.String Path{
        get{
            // Seguramente sería mejor sin ajustar el ancho...
            //return ajustarAncho(_Path,256);
            return  _Path;
        }
        set{
            _Path = value;
        }
    }
    public System.String LoweredPath{
        get{
            // Seguramente sería mejor sin ajustar el ancho...
            //return ajustarAncho(_LoweredPath,256);
            return  _LoweredPath;
        }
        set{
            _LoweredPath = value;
        }
    }

}
