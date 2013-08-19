//------------------------------------------------------------------------------
// Clase aspnet_Membership generada automáticamente con CrearClaseSQL
// de la tabla 'aspnet_Membership' de la base 'RBV'
// Fecha: 19/ago/2013 00:00:53
//
// ©Guillermo 'guille' Som, 2004-2013
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
//
public class aspnet_Membership{
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
    //public System.Byte() PageSettings{
    //    get{
    //        return  _PageSettings;
    //    }
    //    set{
    //        _PageSettings = value;
    //    }
    //}
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
    //
    public string this[int index]{
        // Devuelve el contenido del campo indicado en index
        // (el índice corresponde con la columna de la tabla)
        get{
            if(index == 0){
                return this.idCaracteristicaRV.ToString();
            }else if(index == 1){
                return this.caracteristicaRV.ToString();
            }else if(index == 2){
                return this.idClasificacionRV.ToString();
            }else if(index == 3){
                return this.idEmpresa.ToString();
            }else if(index == 4){
                return this.Valor.ToString();
            }else if(index == 5){
                return this.idTipoRecurso.ToString();
            }else if(index == 6){
                return this.tipoRecurso.ToString();
            }else if(index == 7){
                return this.idRecursoEmpresa.ToString();
            }else if(index == 8){
                return this.recurso.ToString();
            }else if(index == 9){
                return this.Descripcion.ToString();
            }else if(index == 10){
                return this.IdEscalaCalificacion.ToString();
            }else if(index == 11){
                return this.Escala.ToString();
            }else if(index == 12){
                return this.nit.ToString();
            }else if(index == 13){
                return this.nombreEmpresa.ToString();
            }else if(index == 14){
                return this.represetanteLegal.ToString();
            }else if(index == 15){
                return this.UserId.ToString();
            }else if(index == 16){
                return this.PropertyNames.ToString();
            }else if(index == 17){
                return this.PropertyValuesString.ToString();
            }
            
            //else if(index == 18){
            //    return <Binario largo>;
            //}
            else if(index == 19){
                return this.LastUpdatedDate.ToString();
            }else if(index == 20){
                return this.idSector.ToString();
            }else if(index == 21){
                return this.sector.ToString();
            }else if(index == 22){
                return this.ApplicationId.ToString();
            }else if(index == 23){
                return this.RoleId.ToString();
            }else if(index == 24){
                return this.RoleName.ToString();
            }else if(index == 25){
                return this.LoweredRoleName.ToString();
            }else if(index == 26){
                return this.Description.ToString();
            }else if(index == 27){
                return this.PathId.ToString();
            }else if(index == 28){
                return this.Path.ToString();
            }else if(index == 29){
                return this.LoweredPath.ToString();
            }
            //else if(index == 30){
            //    return <Binario largo>;
            //}
            else if(index == 31){
                return this.Id.ToString();
            }else if(index == 32){
                return this.Password.ToString();
            }else if(index == 33){
                return this.PasswordFormat.ToString();
            }else if(index == 34){
                return this.PasswordSalt.ToString();
            }else if(index == 35){
                return this.MobilePIN.ToString();
            }else if(index == 36){
                return this.Email.ToString();
            }else if(index == 37){
                return this.LoweredEmail.ToString();
            }else if(index == 38){
                return this.PasswordQuestion.ToString();
            }else if(index == 39){
                return this.PasswordAnswer.ToString();
            }else if(index == 40){
                return this.IsApproved.ToString();
            }else if(index == 41){
                return this.IsLockedOut.ToString();
            }else if(index == 42){
                return this.CreateDate.ToString();
            }else if(index == 43){
                return this.LastLoginDate.ToString();
            }else if(index == 44){
                return this.LastPasswordChangedDate.ToString();
            }else if(index == 45){
                return this.LastLockoutDate.ToString();
            }else if(index == 46){
                return this.FailedPasswordAttemptCount.ToString();
            }else if(index == 47){
                return this.FailedPasswordAttemptWindowStart.ToString();
            }else if(index == 48){
                return this.FailedPasswordAnswerAttemptCount.ToString();
            }else if(index == 49){
                return this.FailedPasswordAnswerAttemptWindowStart.ToString();
            }else if(index == 50){
                return this.Comment.ToString();
            }
            // Para que no de error el compilador de C#
            return "";
        }
        set{
            if(index == 0){
                try{
                    this.idCaracteristicaRV = System.Int16.Parse("0" + value);
                }catch{
                    this.idCaracteristicaRV = System.Int16.Parse("0");
                }
            }else if(index == 1){
                this.caracteristicaRV = value;
            }else if(index == 2){
                try{
                    this.idClasificacionRV = System.Int16.Parse("0" + value);
                }catch{
                    this.idClasificacionRV = System.Int16.Parse("0");
                }
            }else if(index == 3){
                try{
                    this.idEmpresa = System.Int16.Parse("0" + value);
                }catch{
                    this.idEmpresa = System.Int16.Parse("0");
                }
            }else if(index == 4){
                try{
                    this.Valor = System.Decimal.Parse("0" + value);
                }catch{
                    this.Valor = System.Decimal.Parse("0");
                }
            }else if(index == 5){
                try{
                    this.idTipoRecurso = System.Int16.Parse("0" + value);
                }catch{
                    this.idTipoRecurso = System.Int16.Parse("0");
                }
            }else if(index == 6){
                this.tipoRecurso = value;
            }else if(index == 7){
                try{
                    this.idRecursoEmpresa = System.Int16.Parse("0" + value);
                }catch{
                    this.idRecursoEmpresa = System.Int16.Parse("0");
                }
            }else if(index == 8){
                this.recurso = value;
            }else if(index == 9){
                this.Descripcion = value;
            }else if(index == 10){
                try{
                    this.IdEscalaCalificacion = System.Int16.Parse("0" + value);
                }catch{
                    this.IdEscalaCalificacion = System.Int16.Parse("0");
                }
            }else if(index == 11){
                this.Escala = value;
            }else if(index == 12){
                this.nit = value;
            }else if(index == 13){
                this.nombreEmpresa = value;
            }else if(index == 14){
                this.represetanteLegal = value;
            }else if(index == 15){
                // TODO: Comprobar la conversión a realizar
                //       con el tipo System.Guid
                //this.UserId = value;
                this.UserId = System.Guid.Parse(value);
            }else if(index == 16){
                this.PropertyNames = value;
            }else if(index == 17){
                this.PropertyValuesString = value;
            }else if(index == 18){
                // Es un Binario largo (array de Byte)
                // y por tanto no se le puede asignar el contenido de una cadena...
            }else if(index == 19){
                try{
                    this.LastUpdatedDate = System.DateTime.Parse(value);
                }catch{
                    // TODO: Usa el valor de fecha que quieras predeterminar
                    //       Una fecha ficticia:
                    //this.LastUpdatedDate = new System.DateTime(1900, 1, 1);
                    //       o la fecha de hoy:
                    this.LastUpdatedDate = System.DateTime.Now;
                }
            }else if(index == 20){
                try{
                    this.idSector = System.Int16.Parse("0" + value);
                }catch{
                    this.idSector = System.Int16.Parse("0");
                }
            }else if(index == 21){
                this.sector = value;
            }else if(index == 22){
                // TODO: Comprobar la conversión a realizar
                //       con el tipo System.Guid
                //this.ApplicationId = value;
                this.ApplicationId = System.Guid.Parse(value);
            }else if(index == 23){
                // TODO: Comprobar la conversión a realizar
                //       con el tipo System.Guid
                //this.RoleId = value;
                this.RoleId = System.Guid.Parse(value);
            }else if(index == 24){
                this.RoleName = value;
            }else if(index == 25){
                this.LoweredRoleName = value;
            }else if(index == 26){
                this.Description = value;
            }else if(index == 27){
                // TODO: Comprobar la conversión a realizar
                //       con el tipo System.Guid
                //this.PathId = value;
                this.PathId = System.Guid.Parse(value);
            }else if(index == 28){
                this.Path = value;
            }else if(index == 29){
                this.LoweredPath = value;
            }else if(index == 30){
                // Es un Binario largo (array de Byte)
                // y por tanto no se le puede asignar el contenido de una cadena...
            }else if(index == 31){
                // TODO: Comprobar la conversión a realizar
                //       con el tipo System.Guid
                //this.Id = value;
                this.Id = System.Guid.Parse(value);
            }else if(index == 32){
                this.Password = value;
            }else if(index == 33){
                try{
                    this.PasswordFormat = System.Int32.Parse("0" + value);
                }catch{
                    this.PasswordFormat = System.Int32.Parse("0");
                }
            }else if(index == 34){
                this.PasswordSalt = value;
            }else if(index == 35){
                this.MobilePIN = value;
            }else if(index == 36){
                this.Email = value;
            }else if(index == 37){
                this.LoweredEmail = value;
            }else if(index == 38){
                this.PasswordQuestion = value;
            }else if(index == 39){
                this.PasswordAnswer = value;
            }else if(index == 40){
                try{
                    this.IsApproved = System.Boolean.Parse(value);
                }catch{
                    this.IsApproved = false;
                }
            }else if(index == 41){
                try{
                    this.IsLockedOut = System.Boolean.Parse(value);
                }catch{
                    this.IsLockedOut = false;
                }
            }else if(index == 42){
                try{
                    this.CreateDate = System.DateTime.Parse(value);
                }catch{
                    // TODO: Usa el valor de fecha que quieras predeterminar
                    //       Una fecha ficticia:
                    //this.CreateDate = new System.DateTime(1900, 1, 1);
                    //       o la fecha de hoy:
                    this.CreateDate = System.DateTime.Now;
                }
            }else if(index == 43){
                try{
                    this.LastLoginDate = System.DateTime.Parse(value);
                }catch{
                    // TODO: Usa el valor de fecha que quieras predeterminar
                    //       Una fecha ficticia:
                    //this.LastLoginDate = new System.DateTime(1900, 1, 1);
                    //       o la fecha de hoy:
                    this.LastLoginDate = System.DateTime.Now;
                }
            }else if(index == 44){
                try{
                    this.LastPasswordChangedDate = System.DateTime.Parse(value);
                }catch{
                    // TODO: Usa el valor de fecha que quieras predeterminar
                    //       Una fecha ficticia:
                    //this.LastPasswordChangedDate = new System.DateTime(1900, 1, 1);
                    //       o la fecha de hoy:
                    this.LastPasswordChangedDate = System.DateTime.Now;
                }
            }else if(index == 45){
                try{
                    this.LastLockoutDate = System.DateTime.Parse(value);
                }catch{
                    // TODO: Usa el valor de fecha que quieras predeterminar
                    //       Una fecha ficticia:
                    //this.LastLockoutDate = new System.DateTime(1900, 1, 1);
                    //       o la fecha de hoy:
                    this.LastLockoutDate = System.DateTime.Now;
                }
            }else if(index == 46){
                try{
                    this.FailedPasswordAttemptCount = System.Int32.Parse("0" + value);
                }catch{
                    this.FailedPasswordAttemptCount = System.Int32.Parse("0");
                }
            }else if(index == 47){
                try{
                    this.FailedPasswordAttemptWindowStart = System.DateTime.Parse(value);
                }catch{
                    // TODO: Usa el valor de fecha que quieras predeterminar
                    //       Una fecha ficticia:
                    //this.FailedPasswordAttemptWindowStart = new System.DateTime(1900, 1, 1);
                    //       o la fecha de hoy:
                    this.FailedPasswordAttemptWindowStart = System.DateTime.Now;
                }
            }else if(index == 48){
                try{
                    this.FailedPasswordAnswerAttemptCount = System.Int32.Parse("0" + value);
                }catch{
                    this.FailedPasswordAnswerAttemptCount = System.Int32.Parse("0");
                }
            }else if(index == 49){
                try{
                    this.FailedPasswordAnswerAttemptWindowStart = System.DateTime.Parse(value);
                }catch{
                    // TODO: Usa el valor de fecha que quieras predeterminar
                    //       Una fecha ficticia:
                    //this.FailedPasswordAnswerAttemptWindowStart = new System.DateTime(1900, 1, 1);
                    //       o la fecha de hoy:
                    this.FailedPasswordAnswerAttemptWindowStart = System.DateTime.Now;
                }
            }else if(index == 50){
                this.Comment = value;
            }
        }
    }
    public string this[string index]{
        // Devuelve el contenido del campo indicado en index
        // (el índice corresponde al nombre de la columna)
        get{
            if(index == "idCaracteristicaRV"){
                return this.idCaracteristicaRV.ToString();
            }else if(index == "caracteristicaRV"){
                return this.caracteristicaRV.ToString();
            }else if(index == "idClasificacionRV"){
                return this.idClasificacionRV.ToString();
            }else if(index == "idEmpresa"){
                return this.idEmpresa.ToString();
            }else if(index == "Valor"){
                return this.Valor.ToString();
            }else if(index == "idTipoRecurso"){
                return this.idTipoRecurso.ToString();
            }else if(index == "tipoRecurso"){
                return this.tipoRecurso.ToString();
            }else if(index == "idRecursoEmpresa"){
                return this.idRecursoEmpresa.ToString();
            }else if(index == "recurso"){
                return this.recurso.ToString();
            }else if(index == "Descripcion"){
                return this.Descripcion.ToString();
            }else if(index == "IdEscalaCalificacion"){
                return this.IdEscalaCalificacion.ToString();
            }else if(index == "Escala"){
                return this.Escala.ToString();
            }else if(index == "nit"){
                return this.nit.ToString();
            }else if(index == "nombreEmpresa"){
                return this.nombreEmpresa.ToString();
            }else if(index == "represetanteLegal"){
                return this.represetanteLegal.ToString();
            }else if(index == "UserId"){
                return this.UserId.ToString();
            }else if(index == "PropertyNames"){
                return this.PropertyNames.ToString();
            }else if(index == "PropertyValuesString"){
                return this.PropertyValuesString.ToString();
            }
            //else if(index == "PropertyValuesBinary"){
            //    return <Binario largo>;
            //}
            else if(index == "LastUpdatedDate"){
                return this.LastUpdatedDate.ToString();
            }else if(index == "idSector"){
                return this.idSector.ToString();
            }else if(index == "sector"){
                return this.sector.ToString();
            }else if(index == "ApplicationId"){
                return this.ApplicationId.ToString();
            }else if(index == "RoleId"){
                return this.RoleId.ToString();
            }else if(index == "RoleName"){
                return this.RoleName.ToString();
            }else if(index == "LoweredRoleName"){
                return this.LoweredRoleName.ToString();
            }else if(index == "Description"){
                return this.Description.ToString();
            }else if(index == "PathId"){
                return this.PathId.ToString();
            }else if(index == "Path"){
                return this.Path.ToString();
            }else if(index == "LoweredPath"){
                return this.LoweredPath.ToString();
            }
            //else if(index == "PageSettings"){
            //    return <Binario largo>;
            //}
            else if(index == "Id"){
                return this.Id.ToString();
            }else if(index == "Password"){
                return this.Password.ToString();
            }else if(index == "PasswordFormat"){
                return this.PasswordFormat.ToString();
            }else if(index == "PasswordSalt"){
                return this.PasswordSalt.ToString();
            }else if(index == "MobilePIN"){
                return this.MobilePIN.ToString();
            }else if(index == "Email"){
                return this.Email.ToString();
            }else if(index == "LoweredEmail"){
                return this.LoweredEmail.ToString();
            }else if(index == "PasswordQuestion"){
                return this.PasswordQuestion.ToString();
            }else if(index == "PasswordAnswer"){
                return this.PasswordAnswer.ToString();
            }else if(index == "IsApproved"){
                return this.IsApproved.ToString();
            }else if(index == "IsLockedOut"){
                return this.IsLockedOut.ToString();
            }else if(index == "CreateDate"){
                return this.CreateDate.ToString();
            }else if(index == "LastLoginDate"){
                return this.LastLoginDate.ToString();
            }else if(index == "LastPasswordChangedDate"){
                return this.LastPasswordChangedDate.ToString();
            }else if(index == "LastLockoutDate"){
                return this.LastLockoutDate.ToString();
            }else if(index == "FailedPasswordAttemptCount"){
                return this.FailedPasswordAttemptCount.ToString();
            }else if(index == "FailedPasswordAttemptWindowStart"){
                return this.FailedPasswordAttemptWindowStart.ToString();
            }else if(index == "FailedPasswordAnswerAttemptCount"){
                return this.FailedPasswordAnswerAttemptCount.ToString();
            }else if(index == "FailedPasswordAnswerAttemptWindowStart"){
                return this.FailedPasswordAnswerAttemptWindowStart.ToString();
            }else if(index == "Comment"){
                return this.Comment.ToString();
            }
            // Para que no de error el compilador de C#
            return "";
        }
        set{
            if(index == "idCaracteristicaRV"){
                try{
                    this.idCaracteristicaRV = System.Int16.Parse("0" + value);
                }catch{
                    this.idCaracteristicaRV = System.Int16.Parse("0");
                }
            }else if(index == "caracteristicaRV"){
                this.caracteristicaRV = value;
            }else if(index == "idClasificacionRV"){
                try{
                    this.idClasificacionRV = System.Int16.Parse("0" + value);
                }catch{
                    this.idClasificacionRV = System.Int16.Parse("0");
                }
            }else if(index == "idEmpresa"){
                try{
                    this.idEmpresa = System.Int16.Parse("0" + value);
                }catch{
                    this.idEmpresa = System.Int16.Parse("0");
                }
            }else if(index == "Valor"){
                try{
                    this.Valor = System.Decimal.Parse("0" + value);
                }catch{
                    this.Valor = System.Decimal.Parse("0");
                }
            }else if(index == "idTipoRecurso"){
                try{
                    this.idTipoRecurso = System.Int16.Parse("0" + value);
                }catch{
                    this.idTipoRecurso = System.Int16.Parse("0");
                }
            }else if(index == "tipoRecurso"){
                this.tipoRecurso = value;
            }else if(index == "idRecursoEmpresa"){
                try{
                    this.idRecursoEmpresa = System.Int16.Parse("0" + value);
                }catch{
                    this.idRecursoEmpresa = System.Int16.Parse("0");
                }
            }else if(index == "recurso"){
                this.recurso = value;
            }else if(index == "Descripcion"){
                this.Descripcion = value;
            }else if(index == "IdEscalaCalificacion"){
                try{
                    this.IdEscalaCalificacion = System.Int16.Parse("0" + value);
                }catch{
                    this.IdEscalaCalificacion = System.Int16.Parse("0");
                }
            }else if(index == "Escala"){
                this.Escala = value;
            }else if(index == "nit"){
                this.nit = value;
            }else if(index == "nombreEmpresa"){
                this.nombreEmpresa = value;
            }else if(index == "represetanteLegal"){
                this.represetanteLegal = value;
            }else if(index == "UserId"){
                // TODO: Comprobar la conversión a realizar
                //       con el tipo System.Guid
                //this.UserId = value;
                this.UserId = System.Guid.Parse(value);
            }else if(index == "PropertyNames"){
                this.PropertyNames = value;
            }else if(index == "PropertyValuesString"){
                this.PropertyValuesString = value;
            }else if(index == "PropertyValuesBinary"){
                // Es un Binario largo (array de Byte)
                // y por tanto no se le puede asignar el contenido de una cadena...
            }else if(index == "LastUpdatedDate"){
                try{
                    this.LastUpdatedDate = System.DateTime.Parse(value);
                }catch{
                    // TODO: Usa el valor de fecha que quieras predeterminar
                    //       Una fecha ficticia:
                    //this.LastUpdatedDate = new System.DateTime(1900, 1, 1);
                    //       o la fecha de hoy:
                    this.LastUpdatedDate = System.DateTime.Now;
                }
            }else if(index == "idSector"){
                try{
                    this.idSector = System.Int16.Parse("0" + value);
                }catch{
                    this.idSector = System.Int16.Parse("0");
                }
            }else if(index == "sector"){
                this.sector = value;
            }else if(index == "ApplicationId"){
                // TODO: Comprobar la conversión a realizar
                //       con el tipo System.Guid
                //this.ApplicationId = value;
                this.ApplicationId = System.Guid.Parse(value);
            }else if(index == "RoleId"){
                // TODO: Comprobar la conversión a realizar
                //       con el tipo System.Guid
                //this.RoleId = value;
                this.RoleId = System.Guid.Parse(value);
            }else if(index == "RoleName"){
                this.RoleName = value;
            }else if(index == "LoweredRoleName"){
                this.LoweredRoleName = value;
            }else if(index == "Description"){
                this.Description = value;
            }else if(index == "PathId"){
                // TODO: Comprobar la conversión a realizar
                //       con el tipo System.Guid
                //this.PathId = value;
                this.PathId = System.Guid.Parse(value);
            }else if(index == "Path"){
                this.Path = value;
            }else if(index == "LoweredPath"){
                this.LoweredPath = value;
            }else if(index == "PageSettings"){
                // Es un Binario largo (array de Byte)
                // y por tanto no se le puede asignar el contenido de una cadena...
            }else if(index == "Id"){
                // TODO: Comprobar la conversión a realizar
                //       con el tipo System.Guid
                //this.Id = value;
                this.Id = System.Guid.Parse(value);
            }else if(index == "Password"){
                this.Password = value;
            }else if(index == "PasswordFormat"){
                try{
                    this.PasswordFormat = System.Int32.Parse("0" + value);
                }catch{
                    this.PasswordFormat = System.Int32.Parse("0");
                }
            }else if(index == "PasswordSalt"){
                this.PasswordSalt = value;
            }else if(index == "MobilePIN"){
                this.MobilePIN = value;
            }else if(index == "Email"){
                this.Email = value;
            }else if(index == "LoweredEmail"){
                this.LoweredEmail = value;
            }else if(index == "PasswordQuestion"){
                this.PasswordQuestion = value;
            }else if(index == "PasswordAnswer"){
                this.PasswordAnswer = value;
            }else if(index == "IsApproved"){
                try{
                    this.IsApproved = System.Boolean.Parse(value);
                }catch{
                    this.IsApproved = false;
                }
            }else if(index == "IsLockedOut"){
                try{
                    this.IsLockedOut = System.Boolean.Parse(value);
                }catch{
                    this.IsLockedOut = false;
                }
            }else if(index == "CreateDate"){
                try{
                    this.CreateDate = System.DateTime.Parse(value);
                }catch{
                    // TODO: Usa el valor de fecha que quieras predeterminar
                    //       Una fecha ficticia:
                    //this.CreateDate = new System.DateTime(1900, 1, 1);
                    //       o la fecha de hoy:
                    this.CreateDate = System.DateTime.Now;
                }
            }else if(index == "LastLoginDate"){
                try{
                    this.LastLoginDate = System.DateTime.Parse(value);
                }catch{
                    // TODO: Usa el valor de fecha que quieras predeterminar
                    //       Una fecha ficticia:
                    //this.LastLoginDate = new System.DateTime(1900, 1, 1);
                    //       o la fecha de hoy:
                    this.LastLoginDate = System.DateTime.Now;
                }
            }else if(index == "LastPasswordChangedDate"){
                try{
                    this.LastPasswordChangedDate = System.DateTime.Parse(value);
                }catch{
                    // TODO: Usa el valor de fecha que quieras predeterminar
                    //       Una fecha ficticia:
                    //this.LastPasswordChangedDate = new System.DateTime(1900, 1, 1);
                    //       o la fecha de hoy:
                    this.LastPasswordChangedDate = System.DateTime.Now;
                }
            }else if(index == "LastLockoutDate"){
                try{
                    this.LastLockoutDate = System.DateTime.Parse(value);
                }catch{
                    // TODO: Usa el valor de fecha que quieras predeterminar
                    //       Una fecha ficticia:
                    //this.LastLockoutDate = new System.DateTime(1900, 1, 1);
                    //       o la fecha de hoy:
                    this.LastLockoutDate = System.DateTime.Now;
                }
            }else if(index == "FailedPasswordAttemptCount"){
                try{
                    this.FailedPasswordAttemptCount = System.Int32.Parse("0" + value);
                }catch{
                    this.FailedPasswordAttemptCount = System.Int32.Parse("0");
                }
            }else if(index == "FailedPasswordAttemptWindowStart"){
                try{
                    this.FailedPasswordAttemptWindowStart = System.DateTime.Parse(value);
                }catch{
                    // TODO: Usa el valor de fecha que quieras predeterminar
                    //       Una fecha ficticia:
                    //this.FailedPasswordAttemptWindowStart = new System.DateTime(1900, 1, 1);
                    //       o la fecha de hoy:
                    this.FailedPasswordAttemptWindowStart = System.DateTime.Now;
                }
            }else if(index == "FailedPasswordAnswerAttemptCount"){
                try{
                    this.FailedPasswordAnswerAttemptCount = System.Int32.Parse("0" + value);
                }catch{
                    this.FailedPasswordAnswerAttemptCount = System.Int32.Parse("0");
                }
            }else if(index == "FailedPasswordAnswerAttemptWindowStart"){
                try{
                    this.FailedPasswordAnswerAttemptWindowStart = System.DateTime.Parse(value);
                }catch{
                    // TODO: Usa el valor de fecha que quieras predeterminar
                    //       Una fecha ficticia:
                    //this.FailedPasswordAnswerAttemptWindowStart = new System.DateTime(1900, 1, 1);
                    //       o la fecha de hoy:
                    this.FailedPasswordAnswerAttemptWindowStart = System.DateTime.Now;
                }
            }else if(index == "Comment"){
                this.Comment = value;
            }
        }
    }
    //
    // Campos y métodos compartidos (estáticos) para gestionar la base de datos
    //
    // La cadena de conexión a la base de datos
    private static string cadenaConexion = @"Data Source=Milton1; Initial Catalog=RBV; user id=USR_RBV; password=USR_RBV";
    // La cadena de selección
    public static string CadenaSelect = "SELECT * FROM aspnet_Membership";
    //
    public aspnet_Membership(){
    }
    public aspnet_Membership(string conex){
        cadenaConexion = conex;
    }
    //
    // Métodos compartidos (estáticos) privados
    //
    // asigna una fila de la tabla a un objeto aspnet_Membership
    private static aspnet_Membership row2aspnet_Membership(DataRow r){
        // asigna a un objeto aspnet_Membership los datos del dataRow indicado
        aspnet_Membership oaspnet_Membership = new aspnet_Membership();
        //
        oaspnet_Membership.idCaracteristicaRV = System.Int16.Parse("0" + r["idCaracteristicaRV"].ToString());
        oaspnet_Membership.caracteristicaRV = r["caracteristicaRV"].ToString();
        oaspnet_Membership.idClasificacionRV = System.Int16.Parse("0" + r["idClasificacionRV"].ToString());
        oaspnet_Membership.idEmpresa = System.Int16.Parse("0" + r["idEmpresa"].ToString());
        oaspnet_Membership.Valor = System.Decimal.Parse("0" + r["Valor"].ToString());
        oaspnet_Membership.idTipoRecurso = System.Int16.Parse("0" + r["idTipoRecurso"].ToString());
        oaspnet_Membership.tipoRecurso = r["tipoRecurso"].ToString();
        oaspnet_Membership.idRecursoEmpresa = System.Int16.Parse("0" + r["idRecursoEmpresa"].ToString());
        oaspnet_Membership.recurso = r["recurso"].ToString();
        oaspnet_Membership.Descripcion = r["Descripcion"].ToString();
        oaspnet_Membership.IdEscalaCalificacion = System.Int16.Parse("0" + r["IdEscalaCalificacion"].ToString());
        oaspnet_Membership.Escala = r["Escala"].ToString();
        oaspnet_Membership.nit = r["nit"].ToString();
        oaspnet_Membership.nombreEmpresa = r["nombreEmpresa"].ToString();
        oaspnet_Membership.represetanteLegal = r["represetanteLegal"].ToString();
        // TODO: Comprobar la conversión a realizar
        //       con el tipo System.Guid
        //oaspnet_Membership.UserId = r["UserId"];
        oaspnet_Membership.UserId = System.Guid.Parse(r["UserId"].ToString());
        oaspnet_Membership.PropertyNames = r["PropertyNames"].ToString();
        oaspnet_Membership.PropertyValuesString = r["PropertyValuesString"].ToString();
        //oaspnet_Membership.PropertyValuesBinary = r["PropertyValuesBinary"];
        try{
            oaspnet_Membership.LastUpdatedDate = DateTime.Parse(r["LastUpdatedDate"].ToString());
        }catch{
            // TODO: Usa el valor de fecha que quieras predeterminar
            //       Una fecha ficticia:
            //oaspnet_Membership.LastUpdatedDate = new DateTime(1900, 1, 1);
            //       o la fecha de hoy:
            oaspnet_Membership.LastUpdatedDate = DateTime.Now;
        }
        oaspnet_Membership.idSector = System.Int16.Parse("0" + r["idSector"].ToString());
        oaspnet_Membership.sector = r["sector"].ToString();
        // TODO: Comprobar la conversión a realizar
        //       con el tipo System.Guid
        //oaspnet_Membership.ApplicationId = r["ApplicationId"];
        oaspnet_Membership.ApplicationId = System.Guid.Parse(r["ApplicationId"].ToString());
        // TODO: Comprobar la conversión a realizar
        //       con el tipo System.Guid
        //oaspnet_Membership.RoleId = r["RoleId"];
        oaspnet_Membership.RoleId = System.Guid.Parse(r["RoleId"].ToString());
        oaspnet_Membership.RoleName = r["RoleName"].ToString();
        oaspnet_Membership.LoweredRoleName = r["LoweredRoleName"].ToString();
        oaspnet_Membership.Description = r["Description"].ToString();
        // TODO: Comprobar la conversión a realizar
        //       con el tipo System.Guid
        //oaspnet_Membership.PathId = r["PathId"];
        oaspnet_Membership.PathId = System.Guid.Parse(r["PathId"].ToString());
        oaspnet_Membership.Path = r["Path"].ToString();
        oaspnet_Membership.LoweredPath = r["LoweredPath"].ToString();
        //oaspnet_Membership.PageSettings = r["PageSettings"];
        // TODO: Comprobar la conversión a realizar
        //       con el tipo System.Guid
        //oaspnet_Membership.Id = r["Id"];
        oaspnet_Membership.Id = System.Guid.Parse(r["Id"].ToString());
        oaspnet_Membership.Password = r["Password"].ToString();
        oaspnet_Membership.PasswordFormat = System.Int32.Parse("0" + r["PasswordFormat"].ToString());
        oaspnet_Membership.PasswordSalt = r["PasswordSalt"].ToString();
        oaspnet_Membership.MobilePIN = r["MobilePIN"].ToString();
        oaspnet_Membership.Email = r["Email"].ToString();
        oaspnet_Membership.LoweredEmail = r["LoweredEmail"].ToString();
        oaspnet_Membership.PasswordQuestion = r["PasswordQuestion"].ToString();
        oaspnet_Membership.PasswordAnswer = r["PasswordAnswer"].ToString();
        try{
            oaspnet_Membership.IsApproved = System.Boolean.Parse(r["IsApproved"].ToString());
        }catch{
            oaspnet_Membership.IsApproved = false;
        }
        try{
            oaspnet_Membership.IsLockedOut = System.Boolean.Parse(r["IsLockedOut"].ToString());
        }catch{
            oaspnet_Membership.IsLockedOut = false;
        }
        try{
            oaspnet_Membership.CreateDate = DateTime.Parse(r["CreateDate"].ToString());
        }catch{
            // TODO: Usa el valor de fecha que quieras predeterminar
            //       Una fecha ficticia:
            //oaspnet_Membership.CreateDate = new DateTime(1900, 1, 1);
            //       o la fecha de hoy:
            oaspnet_Membership.CreateDate = DateTime.Now;
        }
        try{
            oaspnet_Membership.LastLoginDate = DateTime.Parse(r["LastLoginDate"].ToString());
        }catch{
            // TODO: Usa el valor de fecha que quieras predeterminar
            //       Una fecha ficticia:
            //oaspnet_Membership.LastLoginDate = new DateTime(1900, 1, 1);
            //       o la fecha de hoy:
            oaspnet_Membership.LastLoginDate = DateTime.Now;
        }
        try{
            oaspnet_Membership.LastPasswordChangedDate = DateTime.Parse(r["LastPasswordChangedDate"].ToString());
        }catch{
            // TODO: Usa el valor de fecha que quieras predeterminar
            //       Una fecha ficticia:
            //oaspnet_Membership.LastPasswordChangedDate = new DateTime(1900, 1, 1);
            //       o la fecha de hoy:
            oaspnet_Membership.LastPasswordChangedDate = DateTime.Now;
        }
        try{
            oaspnet_Membership.LastLockoutDate = DateTime.Parse(r["LastLockoutDate"].ToString());
        }catch{
            // TODO: Usa el valor de fecha que quieras predeterminar
            //       Una fecha ficticia:
            //oaspnet_Membership.LastLockoutDate = new DateTime(1900, 1, 1);
            //       o la fecha de hoy:
            oaspnet_Membership.LastLockoutDate = DateTime.Now;
        }
        oaspnet_Membership.FailedPasswordAttemptCount = System.Int32.Parse("0" + r["FailedPasswordAttemptCount"].ToString());
        try{
            oaspnet_Membership.FailedPasswordAttemptWindowStart = DateTime.Parse(r["FailedPasswordAttemptWindowStart"].ToString());
        }catch{
            // TODO: Usa el valor de fecha que quieras predeterminar
            //       Una fecha ficticia:
            //oaspnet_Membership.FailedPasswordAttemptWindowStart = new DateTime(1900, 1, 1);
            //       o la fecha de hoy:
            oaspnet_Membership.FailedPasswordAttemptWindowStart = DateTime.Now;
        }
        oaspnet_Membership.FailedPasswordAnswerAttemptCount = System.Int32.Parse("0" + r["FailedPasswordAnswerAttemptCount"].ToString());
        try{
            oaspnet_Membership.FailedPasswordAnswerAttemptWindowStart = DateTime.Parse(r["FailedPasswordAnswerAttemptWindowStart"].ToString());
        }catch{
            // TODO: Usa el valor de fecha que quieras predeterminar
            //       Una fecha ficticia:
            //oaspnet_Membership.FailedPasswordAnswerAttemptWindowStart = new DateTime(1900, 1, 1);
            //       o la fecha de hoy:
            oaspnet_Membership.FailedPasswordAnswerAttemptWindowStart = DateTime.Now;
        }
        oaspnet_Membership.Comment = r["Comment"].ToString();
        //
        return oaspnet_Membership;
    }
    //
    // asigna un objeto aspnet_Membership a la fila indicada
    private static void aspnet_Membership2Row(aspnet_Membership oaspnet_Membership, DataRow r){
        // asigna un objeto aspnet_Membership al dataRow indicado
        // TODO: Comprueba si esta asignación debe hacerse
        //       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        //r["idCaracteristicaRV"] = oaspnet_Membership.idCaracteristicaRV;
        r["caracteristicaRV"] = oaspnet_Membership.caracteristicaRV;
        r["idClasificacionRV"] = oaspnet_Membership.idClasificacionRV;
        // TODO: Comprueba si esta asignación debe hacerse
        //       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        //r["idEmpresa"] = oaspnet_Membership.idEmpresa;
        r["Valor"] = oaspnet_Membership.Valor;
        // TODO: Comprueba si esta asignación debe hacerse
        //       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        //r["idTipoRecurso"] = oaspnet_Membership.idTipoRecurso;
        r["tipoRecurso"] = oaspnet_Membership.tipoRecurso;
        // TODO: Comprueba si esta asignación debe hacerse
        //       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        //r["idRecursoEmpresa"] = oaspnet_Membership.idRecursoEmpresa;
        r["recurso"] = oaspnet_Membership.recurso;
        r["Descripcion"] = oaspnet_Membership.Descripcion;
        // TODO: Comprueba si esta asignación debe hacerse
        //       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        //r["IdEscalaCalificacion"] = oaspnet_Membership.IdEscalaCalificacion;
        r["Escala"] = oaspnet_Membership.Escala;
        r["nit"] = oaspnet_Membership.nit;
        r["nombreEmpresa"] = oaspnet_Membership.nombreEmpresa;
        r["represetanteLegal"] = oaspnet_Membership.represetanteLegal;
        r["UserId"] = oaspnet_Membership.UserId;
        r["PropertyNames"] = oaspnet_Membership.PropertyNames;
        r["PropertyValuesString"] = oaspnet_Membership.PropertyValuesString;
        r["PropertyValuesBinary"] = oaspnet_Membership.PropertyValuesBinary;
        r["LastUpdatedDate"] = oaspnet_Membership.LastUpdatedDate;
        // TODO: Comprueba si esta asignación debe hacerse
        //       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        //r["idSector"] = oaspnet_Membership.idSector;
        r["sector"] = oaspnet_Membership.sector;
        r["ApplicationId"] = oaspnet_Membership.ApplicationId;
        r["RoleId"] = oaspnet_Membership.RoleId;
        r["RoleName"] = oaspnet_Membership.RoleName;
        r["LoweredRoleName"] = oaspnet_Membership.LoweredRoleName;
        r["Description"] = oaspnet_Membership.Description;
        r["PathId"] = oaspnet_Membership.PathId;
        r["Path"] = oaspnet_Membership.Path;
        r["LoweredPath"] = oaspnet_Membership.LoweredPath;
        r["PageSettings"] = oaspnet_Membership.PageSettings;
        r["Id"] = oaspnet_Membership.Id;
        r["Password"] = oaspnet_Membership.Password;
        r["PasswordFormat"] = oaspnet_Membership.PasswordFormat;
        r["PasswordSalt"] = oaspnet_Membership.PasswordSalt;
        r["MobilePIN"] = oaspnet_Membership.MobilePIN;
        r["Email"] = oaspnet_Membership.Email;
        r["LoweredEmail"] = oaspnet_Membership.LoweredEmail;
        r["PasswordQuestion"] = oaspnet_Membership.PasswordQuestion;
        r["PasswordAnswer"] = oaspnet_Membership.PasswordAnswer;
        r["IsApproved"] = oaspnet_Membership.IsApproved;
        r["IsLockedOut"] = oaspnet_Membership.IsLockedOut;
        r["CreateDate"] = oaspnet_Membership.CreateDate;
        r["LastLoginDate"] = oaspnet_Membership.LastLoginDate;
        r["LastPasswordChangedDate"] = oaspnet_Membership.LastPasswordChangedDate;
        r["LastLockoutDate"] = oaspnet_Membership.LastLockoutDate;
        r["FailedPasswordAttemptCount"] = oaspnet_Membership.FailedPasswordAttemptCount;
        r["FailedPasswordAttemptWindowStart"] = oaspnet_Membership.FailedPasswordAttemptWindowStart;
        r["FailedPasswordAnswerAttemptCount"] = oaspnet_Membership.FailedPasswordAnswerAttemptCount;
        r["FailedPasswordAnswerAttemptWindowStart"] = oaspnet_Membership.FailedPasswordAnswerAttemptWindowStart;
        r["Comment"] = oaspnet_Membership.Comment;
    }
    //
    // crea una nueva fila y la asigna a un objeto aspnet_Membership
    private static void nuevoaspnet_Membership(DataTable dt, aspnet_Membership oaspnet_Membership){
        // Crear un nuevo aspnet_Membership
        DataRow dr = dt.NewRow();
        aspnet_Membership oa = row2aspnet_Membership(dr);
        //
        oa.idCaracteristicaRV = oaspnet_Membership.idCaracteristicaRV;
        oa.caracteristicaRV = oaspnet_Membership.caracteristicaRV;
        oa.idClasificacionRV = oaspnet_Membership.idClasificacionRV;
        oa.idEmpresa = oaspnet_Membership.idEmpresa;
        oa.Valor = oaspnet_Membership.Valor;
        oa.idTipoRecurso = oaspnet_Membership.idTipoRecurso;
        oa.tipoRecurso = oaspnet_Membership.tipoRecurso;
        oa.idRecursoEmpresa = oaspnet_Membership.idRecursoEmpresa;
        oa.recurso = oaspnet_Membership.recurso;
        oa.Descripcion = oaspnet_Membership.Descripcion;
        oa.IdEscalaCalificacion = oaspnet_Membership.IdEscalaCalificacion;
        oa.Escala = oaspnet_Membership.Escala;
        oa.nit = oaspnet_Membership.nit;
        oa.nombreEmpresa = oaspnet_Membership.nombreEmpresa;
        oa.represetanteLegal = oaspnet_Membership.represetanteLegal;
        oa.UserId = oaspnet_Membership.UserId;
        oa.PropertyNames = oaspnet_Membership.PropertyNames;
        oa.PropertyValuesString = oaspnet_Membership.PropertyValuesString;
        oa.PropertyValuesBinary = oaspnet_Membership.PropertyValuesBinary;
        oa.LastUpdatedDate = oaspnet_Membership.LastUpdatedDate;
        oa.idSector = oaspnet_Membership.idSector;
        oa.sector = oaspnet_Membership.sector;
        oa.ApplicationId = oaspnet_Membership.ApplicationId;
        oa.RoleId = oaspnet_Membership.RoleId;
        oa.RoleName = oaspnet_Membership.RoleName;
        oa.LoweredRoleName = oaspnet_Membership.LoweredRoleName;
        oa.Description = oaspnet_Membership.Description;
        oa.PathId = oaspnet_Membership.PathId;
        oa.Path = oaspnet_Membership.Path;
        oa.LoweredPath = oaspnet_Membership.LoweredPath;
        oa.PageSettings = oaspnet_Membership.PageSettings;
        oa.Id = oaspnet_Membership.Id;
        oa.Password = oaspnet_Membership.Password;
        oa.PasswordFormat = oaspnet_Membership.PasswordFormat;
        oa.PasswordSalt = oaspnet_Membership.PasswordSalt;
        oa.MobilePIN = oaspnet_Membership.MobilePIN;
        oa.Email = oaspnet_Membership.Email;
        oa.LoweredEmail = oaspnet_Membership.LoweredEmail;
        oa.PasswordQuestion = oaspnet_Membership.PasswordQuestion;
        oa.PasswordAnswer = oaspnet_Membership.PasswordAnswer;
        oa.IsApproved = oaspnet_Membership.IsApproved;
        oa.IsLockedOut = oaspnet_Membership.IsLockedOut;
        oa.CreateDate = oaspnet_Membership.CreateDate;
        oa.LastLoginDate = oaspnet_Membership.LastLoginDate;
        oa.LastPasswordChangedDate = oaspnet_Membership.LastPasswordChangedDate;
        oa.LastLockoutDate = oaspnet_Membership.LastLockoutDate;
        oa.FailedPasswordAttemptCount = oaspnet_Membership.FailedPasswordAttemptCount;
        oa.FailedPasswordAttemptWindowStart = oaspnet_Membership.FailedPasswordAttemptWindowStart;
        oa.FailedPasswordAnswerAttemptCount = oaspnet_Membership.FailedPasswordAnswerAttemptCount;
        oa.FailedPasswordAnswerAttemptWindowStart = oaspnet_Membership.FailedPasswordAnswerAttemptWindowStart;
        oa.Comment = oaspnet_Membership.Comment;
        //
        aspnet_Membership2Row(oa, dr);
        //
        dt.Rows.Add(dr);
    }
    //
    // Métodos públicos
    //
    // devuelve una tabla con los datos indicados en la cadena de selección
    public static DataTable Tabla(){
        return Tabla(CadenaSelect);
    }
    public static DataTable Tabla(string sel){
        // devuelve una tabla con los datos de la tabla aspnet_Membership
        SqlDataAdapter da;
        DataTable dt = new DataTable("aspnet_Membership");
        //
        try{
            da = new SqlDataAdapter(sel, cadenaConexion);
            da.Fill(dt);
        }catch{
            return null;
        }
        //
        return dt;
    }
    //
    public static aspnet_Membership Buscar(string sWhere){
        // Busca en la tabla los datos indicados en el parámetro
        // el parámetro contendrá lo que se usará después del WHERE
        aspnet_Membership oaspnet_Membership = null;
        SqlDataAdapter da;
        DataTable dt = new DataTable("aspnet_Membership");
        string sel = "SELECT * FROM aspnet_Membership WHERE " + sWhere;
        //
        da = new SqlDataAdapter(sel, cadenaConexion);
        da.Fill(dt);
        //
        if(dt.Rows.Count > 0){
            oaspnet_Membership = row2aspnet_Membership(dt.Rows[0]);
        }
        return oaspnet_Membership;
    }
    //
    // Actualizar: Actualiza los datos en la tabla usando la instancia actual
    //             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    //             Para comprobar si el objeto en memoria coincide con uno existente,
    //             se comprueba si el idSector existe en la tabla.
    //             TODO: Si en lugar de idSector usas otro campo, indicalo en la cadena SELECT
    //                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    public string Actualizar(){
        // TODO: Poner aquí la selección a realizar para acceder a este registro
        //       yo uso el idSector que es el identificador único de cada registro
        string sel = "SELECT * FROM aspnet_Membership WHERE idSector = " + this.idSector.ToString();
        return Actualizar(sel);
    }
    public string Actualizar(string sel){
        // Actualiza los datos indicados
        // El parámetro, que es una cadena de selección, indicará el criterio de actualización
        //
        // En caso de error, devolverá la cadena empezando por ERROR.
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt = new DataTable("aspnet_Membership");
        //
        cnn = new SqlConnection(cadenaConexion);
        //da = new SqlDataAdapter(CadenaSelect, cnn);
        da = new SqlDataAdapter(sel, cnn);
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
        //
        //-------------------------------------------
        // Esta no es la más óptima, pero funcionará
        //-------------------------------------------
        SqlCommandBuilder cb = new SqlCommandBuilder(da);
        da.UpdateCommand = cb.GetUpdateCommand();
        //
        //--------------------------------------------------------------------
        // Esta está más optimizada pero debes comprobar que funciona bien...
        //--------------------------------------------------------------------
        //string sCommand;
        ////
        //// El comando UPDATE
        //// TODO: Comprobar cual es el campo de índice principal (sin duplicados)
        ////       Yo compruebo que sea un campo llamado idSector, pero en tu caso puede ser otro
        ////       Ese campo, (en mi caso idSector) será el que hay que poner al final junto al WHERE.
        //sCommand = "UPDATE aspnet_Membership SET idCaracteristicaRV = @idCaracteristicaRV, caracteristicaRV = @caracteristicaRV, idClasificacionRV = @idClasificacionRV, idEmpresa = @idEmpresa, Valor = @Valor, idTipoRecurso = @idTipoRecurso, tipoRecurso = @tipoRecurso, idRecursoEmpresa = @idRecursoEmpresa, recurso = @recurso, Descripcion = @Descripcion, IdEscalaCalificacion = @IdEscalaCalificacion, Escala = @Escala, nit = @nit, nombreEmpresa = @nombreEmpresa, represetanteLegal = @represetanteLegal, UserId = @UserId, PropertyNames = @PropertyNames, PropertyValuesString = @PropertyValuesString, PropertyValuesBinary = @PropertyValuesBinary, LastUpdatedDate = @LastUpdatedDate, sector = @sector, ApplicationId = @ApplicationId, RoleId = @RoleId, RoleName = @RoleName, LoweredRoleName = @LoweredRoleName, Description = @Description, PathId = @PathId, Path = @Path, LoweredPath = @LoweredPath, PageSettings = @PageSettings, Id = @Id, Password = @Password, PasswordFormat = @PasswordFormat, PasswordSalt = @PasswordSalt, MobilePIN = @MobilePIN, Email = @Email, LoweredEmail = @LoweredEmail, PasswordQuestion = @PasswordQuestion, PasswordAnswer = @PasswordAnswer, IsApproved = @IsApproved, IsLockedOut = @IsLockedOut, CreateDate = @CreateDate, LastLoginDate = @LastLoginDate, LastPasswordChangedDate = @LastPasswordChangedDate, LastLockoutDate = @LastLockoutDate, FailedPasswordAttemptCount = @FailedPasswordAttemptCount, FailedPasswordAttemptWindowStart = @FailedPasswordAttemptWindowStart, FailedPasswordAnswerAttemptCount = @FailedPasswordAnswerAttemptCount, FailedPasswordAnswerAttemptWindowStart = @FailedPasswordAnswerAttemptWindowStart, Comment = @Comment  WHERE (idSector = @idSector)";
        //da.UpdateCommand = new SqlCommand(sCommand, cnn);
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@idCaracteristicaRV", SqlDbType.SmallInt, 0, "idCaracteristicaRV");
        //da.UpdateCommand.Parameters.Add("@caracteristicaRV", SqlDbType.NVarChar, 50, "caracteristicaRV");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@idClasificacionRV", SqlDbType.SmallInt, 0, "idClasificacionRV");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@idEmpresa", SqlDbType.SmallInt, 0, "idEmpresa");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@Valor", SqlDbType.Decimal, 0, "Valor");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@idTipoRecurso", SqlDbType.SmallInt, 0, "idTipoRecurso");
        //da.UpdateCommand.Parameters.Add("@tipoRecurso", SqlDbType.NVarChar, 50, "tipoRecurso");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@idRecursoEmpresa", SqlDbType.SmallInt, 0, "idRecursoEmpresa");
        //da.UpdateCommand.Parameters.Add("@recurso", SqlDbType.NVarChar, 50, "recurso");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 500
        ////da.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.NText, 500, "Descripcion");
        //da.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.NText, 0, "Descripcion");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@IdEscalaCalificacion", SqlDbType.SmallInt, 0, "IdEscalaCalificacion");
        //da.UpdateCommand.Parameters.Add("@Escala", SqlDbType.NVarChar, 50, "Escala");
        //da.UpdateCommand.Parameters.Add("@nit", SqlDbType.NVarChar, 50, "nit");
        //da.UpdateCommand.Parameters.Add("@nombreEmpresa", SqlDbType.NVarChar, 50, "nombreEmpresa");
        //da.UpdateCommand.Parameters.Add("@represetanteLegal", SqlDbType.NVarChar, 10, "represetanteLegal");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@UserId", SqlDbType.UniqueIdentifier, 0, "UserId");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 1073741823
        ////da.UpdateCommand.Parameters.Add("@PropertyNames", SqlDbType.NText, 1073741823, "PropertyNames");
        //da.UpdateCommand.Parameters.Add("@PropertyNames", SqlDbType.NText, 0, "PropertyNames");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 1073741823
        ////da.UpdateCommand.Parameters.Add("@PropertyValuesString", SqlDbType.NText, 1073741823, "PropertyValuesString");
        //da.UpdateCommand.Parameters.Add("@PropertyValuesString", SqlDbType.NText, 0, "PropertyValuesString");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@PropertyValuesBinary", SqlDbType.Int, 0, "PropertyValuesBinary");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@LastUpdatedDate", SqlDbType.DateTime, 0, "LastUpdatedDate");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@idSector", SqlDbType.SmallInt, 0, "idSector");
        //da.UpdateCommand.Parameters.Add("@sector", SqlDbType.NVarChar, 50, "sector");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@ApplicationId", SqlDbType.UniqueIdentifier, 0, "ApplicationId");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@RoleId", SqlDbType.UniqueIdentifier, 0, "RoleId");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 256
        ////da.UpdateCommand.Parameters.Add("@RoleName", SqlDbType.NText, 256, "RoleName");
        //da.UpdateCommand.Parameters.Add("@RoleName", SqlDbType.NText, 0, "RoleName");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 256
        ////da.UpdateCommand.Parameters.Add("@LoweredRoleName", SqlDbType.NText, 256, "LoweredRoleName");
        //da.UpdateCommand.Parameters.Add("@LoweredRoleName", SqlDbType.NText, 0, "LoweredRoleName");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 256
        ////da.UpdateCommand.Parameters.Add("@Description", SqlDbType.NText, 256, "Description");
        //da.UpdateCommand.Parameters.Add("@Description", SqlDbType.NText, 0, "Description");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@PathId", SqlDbType.UniqueIdentifier, 0, "PathId");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 256
        ////da.UpdateCommand.Parameters.Add("@Path", SqlDbType.NText, 256, "Path");
        //da.UpdateCommand.Parameters.Add("@Path", SqlDbType.NText, 0, "Path");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 256
        ////da.UpdateCommand.Parameters.Add("@LoweredPath", SqlDbType.NText, 256, "LoweredPath");
        //da.UpdateCommand.Parameters.Add("@LoweredPath", SqlDbType.NText, 0, "LoweredPath");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@PageSettings", SqlDbType.Int, 0, "PageSettings");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@Id", SqlDbType.UniqueIdentifier, 0, "Id");
        //da.UpdateCommand.Parameters.Add("@Password", SqlDbType.NVarChar, 128, "Password");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@PasswordFormat", SqlDbType.Int, 0, "PasswordFormat");
        //da.UpdateCommand.Parameters.Add("@PasswordSalt", SqlDbType.NVarChar, 128, "PasswordSalt");
        //da.UpdateCommand.Parameters.Add("@MobilePIN", SqlDbType.NVarChar, 16, "MobilePIN");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 256
        ////da.UpdateCommand.Parameters.Add("@Email", SqlDbType.NText, 256, "Email");
        //da.UpdateCommand.Parameters.Add("@Email", SqlDbType.NText, 0, "Email");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 256
        ////da.UpdateCommand.Parameters.Add("@LoweredEmail", SqlDbType.NText, 256, "LoweredEmail");
        //da.UpdateCommand.Parameters.Add("@LoweredEmail", SqlDbType.NText, 0, "LoweredEmail");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 256
        ////da.UpdateCommand.Parameters.Add("@PasswordQuestion", SqlDbType.NText, 256, "PasswordQuestion");
        //da.UpdateCommand.Parameters.Add("@PasswordQuestion", SqlDbType.NText, 0, "PasswordQuestion");
        //da.UpdateCommand.Parameters.Add("@PasswordAnswer", SqlDbType.NVarChar, 128, "PasswordAnswer");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@IsApproved", SqlDbType.Bit, 0, "IsApproved");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@IsLockedOut", SqlDbType.Bit, 0, "IsLockedOut");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@CreateDate", SqlDbType.DateTime, 0, "CreateDate");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@LastLoginDate", SqlDbType.DateTime, 0, "LastLoginDate");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@LastPasswordChangedDate", SqlDbType.DateTime, 0, "LastPasswordChangedDate");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@LastLockoutDate", SqlDbType.DateTime, 0, "LastLockoutDate");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@FailedPasswordAttemptCount", SqlDbType.Int, 0, "FailedPasswordAttemptCount");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@FailedPasswordAttemptWindowStart", SqlDbType.DateTime, 0, "FailedPasswordAttemptWindowStart");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@FailedPasswordAnswerAttemptCount", SqlDbType.Int, 0, "FailedPasswordAnswerAttemptCount");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@FailedPasswordAnswerAttemptWindowStart", SqlDbType.DateTime, 0, "FailedPasswordAnswerAttemptWindowStart");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 1073741823
        ////da.UpdateCommand.Parameters.Add("@Comment", SqlDbType.NText, 1073741823, "Comment");
        //da.UpdateCommand.Parameters.Add("@Comment", SqlDbType.NText, 0, "Comment");
        //
        try{
            da.Fill(dt);
        }catch(Exception ex){
            return "ERROR: " + ex.Message;
        }
        //
        if(dt.Rows.Count == 0){
            // crear uno nuevo
            return Crear();
        }else{
            aspnet_Membership2Row(this, dt.Rows[0]);
        }
        //
        try{
            da.Update(dt);
            dt.AcceptChanges();
            return "Actualizado correctamente";
        }catch(Exception ex){
            return "ERROR: " + ex.Message;
        }
    }
    //
    public string Crear(){
        // Crear un nuevo registro
        // En caso de error, devolverá la cadena de error empezando por ERROR:.
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt = new DataTable("aspnet_Membership");
        //
        cnn = new SqlConnection(cadenaConexion);
        da = new SqlDataAdapter(CadenaSelect, cnn);
        //da = new SqlDataAdapter(CadenaSelect, cadenaConexion);
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
        //
        //-------------------------------------------
        // Esta no es la más óptima, pero funcionará
        //-------------------------------------------
        SqlCommandBuilder cb = new SqlCommandBuilder(da);
        da.InsertCommand = cb.GetInsertCommand();
        //
        //--------------------------------------------------------------------
        // Esta está más optimizada pero debes comprobar que funciona bien...
        //--------------------------------------------------------------------
        //string sCommand;
        ////
        //// El comando INSERT
        //// TODO: No incluir el campo de clave primaria incremental
        ////       Yo compruebo que sea un campo llamado idSector, pero en tu caso puede ser otro
        //sCommand = "INSERT INTO aspnet_Membership (caracteristicaRV, idClasificacionRV, Valor, tipoRecurso, recurso, Descripcion, Escala, nit, nombreEmpresa, represetanteLegal, UserId, PropertyNames, PropertyValuesString, PropertyValuesBinary, LastUpdatedDate, sector, ApplicationId, RoleId, RoleName, LoweredRoleName, Description, PathId, Path, LoweredPath, PageSettings, Id, Password, PasswordFormat, PasswordSalt, MobilePIN, Email, LoweredEmail, PasswordQuestion, PasswordAnswer, IsApproved, IsLockedOut, CreateDate, LastLoginDate, LastPasswordChangedDate, LastLockoutDate, FailedPasswordAttemptCount, FailedPasswordAttemptWindowStart, FailedPasswordAnswerAttemptCount, FailedPasswordAnswerAttemptWindowStart, Comment)  VALUES(@caracteristicaRV, @idClasificacionRV, @Valor, @tipoRecurso, @recurso, @Descripcion, @Escala, @nit, @nombreEmpresa, @represetanteLegal, @UserId, @PropertyNames, @PropertyValuesString, @PropertyValuesBinary, @LastUpdatedDate, @sector, @ApplicationId, @RoleId, @RoleName, @LoweredRoleName, @Description, @PathId, @Path, @LoweredPath, @PageSettings, @Id, @Password, @PasswordFormat, @PasswordSalt, @MobilePIN, @Email, @LoweredEmail, @PasswordQuestion, @PasswordAnswer, @IsApproved, @IsLockedOut, @CreateDate, @LastLoginDate, @LastPasswordChangedDate, @LastLockoutDate, @FailedPasswordAttemptCount, @FailedPasswordAttemptWindowStart, @FailedPasswordAnswerAttemptCount, @FailedPasswordAnswerAttemptWindowStart, @Comment)";
        //da.InsertCommand = new SqlCommand(sCommand, cnn);
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@idCaracteristicaRV", SqlDbType.SmallInt, 0, "idCaracteristicaRV");
        //da.InsertCommand.Parameters.Add("@caracteristicaRV", SqlDbType.NVarChar, 50, "caracteristicaRV");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@idClasificacionRV", SqlDbType.SmallInt, 0, "idClasificacionRV");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@idEmpresa", SqlDbType.SmallInt, 0, "idEmpresa");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@Valor", SqlDbType.Decimal, 0, "Valor");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@idTipoRecurso", SqlDbType.SmallInt, 0, "idTipoRecurso");
        //da.InsertCommand.Parameters.Add("@tipoRecurso", SqlDbType.NVarChar, 50, "tipoRecurso");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@idRecursoEmpresa", SqlDbType.SmallInt, 0, "idRecursoEmpresa");
        //da.InsertCommand.Parameters.Add("@recurso", SqlDbType.NVarChar, 50, "recurso");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 500
        ////da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NText, 500, "Descripcion");
        //da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NText, 0, "Descripcion");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@IdEscalaCalificacion", SqlDbType.SmallInt, 0, "IdEscalaCalificacion");
        //da.InsertCommand.Parameters.Add("@Escala", SqlDbType.NVarChar, 50, "Escala");
        //da.InsertCommand.Parameters.Add("@nit", SqlDbType.NVarChar, 50, "nit");
        //da.InsertCommand.Parameters.Add("@nombreEmpresa", SqlDbType.NVarChar, 50, "nombreEmpresa");
        //da.InsertCommand.Parameters.Add("@represetanteLegal", SqlDbType.NVarChar, 10, "represetanteLegal");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@UserId", SqlDbType.UniqueIdentifier, 0, "UserId");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 1073741823
        ////da.InsertCommand.Parameters.Add("@PropertyNames", SqlDbType.NText, 1073741823, "PropertyNames");
        //da.InsertCommand.Parameters.Add("@PropertyNames", SqlDbType.NText, 0, "PropertyNames");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 1073741823
        ////da.InsertCommand.Parameters.Add("@PropertyValuesString", SqlDbType.NText, 1073741823, "PropertyValuesString");
        //da.InsertCommand.Parameters.Add("@PropertyValuesString", SqlDbType.NText, 0, "PropertyValuesString");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@PropertyValuesBinary", SqlDbType.Int, 0, "PropertyValuesBinary");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@LastUpdatedDate", SqlDbType.DateTime, 0, "LastUpdatedDate");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@idSector", SqlDbType.SmallInt, 0, "idSector");
        //da.InsertCommand.Parameters.Add("@sector", SqlDbType.NVarChar, 50, "sector");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@ApplicationId", SqlDbType.UniqueIdentifier, 0, "ApplicationId");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@RoleId", SqlDbType.UniqueIdentifier, 0, "RoleId");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 256
        ////da.InsertCommand.Parameters.Add("@RoleName", SqlDbType.NText, 256, "RoleName");
        //da.InsertCommand.Parameters.Add("@RoleName", SqlDbType.NText, 0, "RoleName");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 256
        ////da.InsertCommand.Parameters.Add("@LoweredRoleName", SqlDbType.NText, 256, "LoweredRoleName");
        //da.InsertCommand.Parameters.Add("@LoweredRoleName", SqlDbType.NText, 0, "LoweredRoleName");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 256
        ////da.InsertCommand.Parameters.Add("@Description", SqlDbType.NText, 256, "Description");
        //da.InsertCommand.Parameters.Add("@Description", SqlDbType.NText, 0, "Description");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@PathId", SqlDbType.UniqueIdentifier, 0, "PathId");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 256
        ////da.InsertCommand.Parameters.Add("@Path", SqlDbType.NText, 256, "Path");
        //da.InsertCommand.Parameters.Add("@Path", SqlDbType.NText, 0, "Path");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 256
        ////da.InsertCommand.Parameters.Add("@LoweredPath", SqlDbType.NText, 256, "LoweredPath");
        //da.InsertCommand.Parameters.Add("@LoweredPath", SqlDbType.NText, 0, "LoweredPath");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@PageSettings", SqlDbType.Int, 0, "PageSettings");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@Id", SqlDbType.UniqueIdentifier, 0, "Id");
        //da.InsertCommand.Parameters.Add("@Password", SqlDbType.NVarChar, 128, "Password");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@PasswordFormat", SqlDbType.Int, 0, "PasswordFormat");
        //da.InsertCommand.Parameters.Add("@PasswordSalt", SqlDbType.NVarChar, 128, "PasswordSalt");
        //da.InsertCommand.Parameters.Add("@MobilePIN", SqlDbType.NVarChar, 16, "MobilePIN");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 256
        ////da.InsertCommand.Parameters.Add("@Email", SqlDbType.NText, 256, "Email");
        //da.InsertCommand.Parameters.Add("@Email", SqlDbType.NText, 0, "Email");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 256
        ////da.InsertCommand.Parameters.Add("@LoweredEmail", SqlDbType.NText, 256, "LoweredEmail");
        //da.InsertCommand.Parameters.Add("@LoweredEmail", SqlDbType.NText, 0, "LoweredEmail");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 256
        ////da.InsertCommand.Parameters.Add("@PasswordQuestion", SqlDbType.NText, 256, "PasswordQuestion");
        //da.InsertCommand.Parameters.Add("@PasswordQuestion", SqlDbType.NText, 0, "PasswordQuestion");
        //da.InsertCommand.Parameters.Add("@PasswordAnswer", SqlDbType.NVarChar, 128, "PasswordAnswer");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@IsApproved", SqlDbType.Bit, 0, "IsApproved");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@IsLockedOut", SqlDbType.Bit, 0, "IsLockedOut");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@CreateDate", SqlDbType.DateTime, 0, "CreateDate");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@LastLoginDate", SqlDbType.DateTime, 0, "LastLoginDate");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@LastPasswordChangedDate", SqlDbType.DateTime, 0, "LastPasswordChangedDate");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@LastLockoutDate", SqlDbType.DateTime, 0, "LastLockoutDate");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@FailedPasswordAttemptCount", SqlDbType.Int, 0, "FailedPasswordAttemptCount");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@FailedPasswordAttemptWindowStart", SqlDbType.DateTime, 0, "FailedPasswordAttemptWindowStart");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@FailedPasswordAnswerAttemptCount", SqlDbType.Int, 0, "FailedPasswordAnswerAttemptCount");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@FailedPasswordAnswerAttemptWindowStart", SqlDbType.DateTime, 0, "FailedPasswordAnswerAttemptWindowStart");
        //// TODO: Este campo seguramente es MEMO y el valor debería ser cero en lugar de 1073741823
        ////da.InsertCommand.Parameters.Add("@Comment", SqlDbType.NText, 1073741823, "Comment");
        //da.InsertCommand.Parameters.Add("@Comment", SqlDbType.NText, 0, "Comment");
        //
        //
        try{
            da.Fill(dt);
        }catch(Exception ex){
            return "ERROR: " + ex.Message;
        }
        //
        nuevoaspnet_Membership(dt, this);
        //
        try{
            da.Update(dt);
            dt.AcceptChanges();
            return "Se ha creado un nuevo aspnet_Membership";
        }catch(Exception ex){
            return "ERROR: " + ex.Message;
        }
    }
    //
    public string Borrar(){
        // TODO: Poner aquí la selección a realizar para acceder a este registro
        //       yo uso el idSector que es el identificador único de cada registro
        string sel = "SELECT * FROM aspnet_Membership WHERE idSector = " + this.idSector.ToString();
        //
        return Borrar(sel);
    }
    public string Borrar(string sel){
        // Borrar el registro al que apunta esta clase
        // En caso de error, devolverá la cadena de error empezando por ERROR:.
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt = new DataTable("aspnet_Membership");
        //
        cnn = new SqlConnection(cadenaConexion);
        da = new SqlDataAdapter(sel, cnn);
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
        //
        //-------------------------------------------
        // Esta no es la más óptima, pero funcionará
        //-------------------------------------------
        SqlCommandBuilder cb = new SqlCommandBuilder(da);
        da.DeleteCommand = cb.GetDeleteCommand();
        //
        //
        //--------------------------------------------------------------------
        // Esta está más optimizada pero debes comprobar que funciona bien...
        //--------------------------------------------------------------------
        //string sCommand;
        ////
        //// El comando DELETE
        //// TODO: Sólo incluir el campo de clave primaria incremental
        ////       Yo compruebo que sea un campo llamado idSector, pero en tu caso puede ser otro
        //sCommand = "DELETE FROM aspnet_Membership WHERE (idSector = @p1)";
        //da.DeleteCommand = new SqlCommand(sCommand, cnn);
        //// TODO: Comprobar el tipo de datos a usar...
        //da.DeleteCommand.Parameters.Add("@p1", SqlDbType.SmallInt, 0, "idSector");
        //da.DeleteCommand.Parameters.Add("@p2", SqlDbType.Int, 0, "");
        //
        //
        da.Fill(dt);
        //
        if(dt.Rows.Count == 0){
            return "ERROR: No hay datos";
        }else{
            dt.Rows[0].Delete();
        }
        //
        try{
            da.Update(dt);
            dt.AcceptChanges();
            return "Borrado satisfactoriamente";
        }catch(Exception ex){
            return "ERROR: " + ex.Message;
        }
    }
    //
}
