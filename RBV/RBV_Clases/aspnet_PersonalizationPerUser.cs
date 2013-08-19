//------------------------------------------------------------------------------
// Clase aspnet_PersonalizationPerUser generada automáticamente con CrearClaseSQL
// de la tabla 'aspnet_PersonalizationPerUser' de la base 'RBV'
// Fecha: 19/ago/2013 00:00:45
//
// ©Guillermo 'guille' Som, 2004-2013
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
//
public class aspnet_PersonalizationPerUser{
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
    private System.Byte[] _PageSettings;
    private System.Guid _Id;
    private System.String _Password;
    private System.Int32 _PasswordFormat;
    private System.String _PasswordSalt;
    private System.String _MobilePIN;
    private System.String _Email;
    private System.String _LoweredEmail;
    private System.String _PasswordQuestion;
    private System.String _PasswordAnswer;
    private System.Boolean _IsApproved;
    private System.Boolean _IsLockedOut;
    private System.DateTime _CreateDate;
    private System.DateTime _LastLoginDate;
    private System.DateTime _LastPasswordChangedDate;
    private System.DateTime _LastLockoutDate;
    private System.Int32 _FailedPasswordAttemptCount;
    private System.DateTime _FailedPasswordAttemptWindowStart;
    private System.Int32 _FailedPasswordAnswerAttemptCount;
    private System.DateTime _FailedPasswordAnswerAttemptWindowStart;
    private System.String _Comment;
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
    
    public System.Guid Id{
        get{
            return  _Id;
        }
        set{
            _Id = value;
        }
    }
    public System.String Password{
        get{
            return ajustarAncho(_Password,128);
        }
        set{
            _Password = value;
        }
    }
    public System.Int32 PasswordFormat{
        get{
            return  _PasswordFormat;
        }
        set{
            _PasswordFormat = value;
        }
    }
    public System.String PasswordSalt{
        get{
            return ajustarAncho(_PasswordSalt,128);
        }
        set{
            _PasswordSalt = value;
        }
    }
    public System.String MobilePIN{
        get{
            return ajustarAncho(_MobilePIN,16);
        }
        set{
            _MobilePIN = value;
        }
    }
    public System.String Email{
        get{
            // Seguramente sería mejor sin ajustar el ancho...
            //return ajustarAncho(_Email,256);
            return  _Email;
        }
        set{
            _Email = value;
        }
    }
    public System.String LoweredEmail{
        get{
            // Seguramente sería mejor sin ajustar el ancho...
            //return ajustarAncho(_LoweredEmail,256);
            return  _LoweredEmail;
        }
        set{
            _LoweredEmail = value;
        }
    }
    public System.String PasswordQuestion{
        get{
            // Seguramente sería mejor sin ajustar el ancho...
            //return ajustarAncho(_PasswordQuestion,256);
            return  _PasswordQuestion;
        }
        set{
            _PasswordQuestion = value;
        }
    }
    public System.String PasswordAnswer{
        get{
            return ajustarAncho(_PasswordAnswer,128);
        }
        set{
            _PasswordAnswer = value;
        }
    }
    public System.Boolean IsApproved{
        get{
            return  _IsApproved;
        }
        set{
            _IsApproved = value;
        }
    }
    public System.Boolean IsLockedOut{
        get{
            return  _IsLockedOut;
        }
        set{
            _IsLockedOut = value;
        }
    }
    public System.DateTime CreateDate{
        get{
            return  _CreateDate;
        }
        set{
            _CreateDate = value;
        }
    }
    public System.DateTime LastLoginDate{
        get{
            return  _LastLoginDate;
        }
        set{
            _LastLoginDate = value;
        }
    }
    public System.DateTime LastPasswordChangedDate{
        get{
            return  _LastPasswordChangedDate;
        }
        set{
            _LastPasswordChangedDate = value;
        }
    }
    public System.DateTime LastLockoutDate{
        get{
            return  _LastLockoutDate;
        }
        set{
            _LastLockoutDate = value;
        }
    }
    public System.Int32 FailedPasswordAttemptCount{
        get{
            return  _FailedPasswordAttemptCount;
        }
        set{
            _FailedPasswordAttemptCount = value;
        }
    }
    public System.DateTime FailedPasswordAttemptWindowStart{
        get{
            return  _FailedPasswordAttemptWindowStart;
        }
        set{
            _FailedPasswordAttemptWindowStart = value;
        }
    }
    public System.Int32 FailedPasswordAnswerAttemptCount{
        get{
            return  _FailedPasswordAnswerAttemptCount;
        }
        set{
            _FailedPasswordAnswerAttemptCount = value;
        }
    }
    public System.DateTime FailedPasswordAnswerAttemptWindowStart{
        get{
            return  _FailedPasswordAnswerAttemptWindowStart;
        }
        set{
            _FailedPasswordAnswerAttemptWindowStart = value;
        }
    }
    public System.String Comment{
        get{
            // Seguramente sería mejor sin ajustar el ancho...
            //return ajustarAncho(_Comment,1073741823);
            return  _Comment;
        }
        set{
            _Comment = value;
        }
    }

}
