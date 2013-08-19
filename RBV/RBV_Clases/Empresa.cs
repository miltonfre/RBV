//------------------------------------------------------------------------------
// Clase empresa generada automáticamente con CrearClaseSQL
// de la tabla 'empresa' de la base 'RBV'
// Fecha: 18/ago/2013 23:59:04
//
// ©Guillermo 'guille' Som, 2004-2013
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
//
public class empresa{
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
            }
        }
    }
    //
    // Campos y métodos compartidos (estáticos) para gestionar la base de datos
    //
    // La cadena de conexión a la base de datos
    private static string cadenaConexion = @"Data Source=Milton1; Initial Catalog=RBV; user id=USR_RBV; password=USR_RBV";
    // La cadena de selección
    public static string CadenaSelect = "SELECT * FROM empresa";
    //
    public empresa(){
    }
    public empresa(string conex){
        cadenaConexion = conex;
    }
    //
    // Métodos compartidos (estáticos) privados
    //
    // asigna una fila de la tabla a un objeto empresa
    private static empresa row2empresa(DataRow r){
        // asigna a un objeto empresa los datos del dataRow indicado
        empresa oempresa = new empresa();
        //
        oempresa.idCaracteristicaRV = System.Int16.Parse("0" + r["idCaracteristicaRV"].ToString());
        oempresa.caracteristicaRV = r["caracteristicaRV"].ToString();
        oempresa.idClasificacionRV = System.Int16.Parse("0" + r["idClasificacionRV"].ToString());
        oempresa.idEmpresa = System.Int16.Parse("0" + r["idEmpresa"].ToString());
        oempresa.Valor = System.Decimal.Parse("0" + r["Valor"].ToString());
        oempresa.idTipoRecurso = System.Int16.Parse("0" + r["idTipoRecurso"].ToString());
        oempresa.tipoRecurso = r["tipoRecurso"].ToString();
        oempresa.idRecursoEmpresa = System.Int16.Parse("0" + r["idRecursoEmpresa"].ToString());
        oempresa.recurso = r["recurso"].ToString();
        oempresa.Descripcion = r["Descripcion"].ToString();
        oempresa.IdEscalaCalificacion = System.Int16.Parse("0" + r["IdEscalaCalificacion"].ToString());
        oempresa.Escala = r["Escala"].ToString();
        oempresa.nit = r["nit"].ToString();
        oempresa.nombreEmpresa = r["nombreEmpresa"].ToString();
        oempresa.represetanteLegal = r["represetanteLegal"].ToString();
        //
        return oempresa;
    }
    //
    // asigna un objeto empresa a la fila indicada
    private static void empresa2Row(empresa oempresa, DataRow r){
        // asigna un objeto empresa al dataRow indicado
        // TODO: Comprueba si esta asignación debe hacerse
        //       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        //r["idCaracteristicaRV"] = oempresa.idCaracteristicaRV;
        r["caracteristicaRV"] = oempresa.caracteristicaRV;
        r["idClasificacionRV"] = oempresa.idClasificacionRV;
        // TODO: Comprueba si esta asignación debe hacerse
        //       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        //r["idEmpresa"] = oempresa.idEmpresa;
        r["Valor"] = oempresa.Valor;
        // TODO: Comprueba si esta asignación debe hacerse
        //       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        //r["idTipoRecurso"] = oempresa.idTipoRecurso;
        r["tipoRecurso"] = oempresa.tipoRecurso;
        // TODO: Comprueba si esta asignación debe hacerse
        //       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        //r["idRecursoEmpresa"] = oempresa.idRecursoEmpresa;
        r["recurso"] = oempresa.recurso;
        r["Descripcion"] = oempresa.Descripcion;
        // TODO: Comprueba si esta asignación debe hacerse
        //       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        //r["IdEscalaCalificacion"] = oempresa.IdEscalaCalificacion;
        r["Escala"] = oempresa.Escala;
        r["nit"] = oempresa.nit;
        r["nombreEmpresa"] = oempresa.nombreEmpresa;
        r["represetanteLegal"] = oempresa.represetanteLegal;
    }
    //
    // crea una nueva fila y la asigna a un objeto empresa
    private static void nuevoempresa(DataTable dt, empresa oempresa){
        // Crear un nuevo empresa
        DataRow dr = dt.NewRow();
        empresa oe = row2empresa(dr);
        //
        oe.idCaracteristicaRV = oempresa.idCaracteristicaRV;
        oe.caracteristicaRV = oempresa.caracteristicaRV;
        oe.idClasificacionRV = oempresa.idClasificacionRV;
        oe.idEmpresa = oempresa.idEmpresa;
        oe.Valor = oempresa.Valor;
        oe.idTipoRecurso = oempresa.idTipoRecurso;
        oe.tipoRecurso = oempresa.tipoRecurso;
        oe.idRecursoEmpresa = oempresa.idRecursoEmpresa;
        oe.recurso = oempresa.recurso;
        oe.Descripcion = oempresa.Descripcion;
        oe.IdEscalaCalificacion = oempresa.IdEscalaCalificacion;
        oe.Escala = oempresa.Escala;
        oe.nit = oempresa.nit;
        oe.nombreEmpresa = oempresa.nombreEmpresa;
        oe.represetanteLegal = oempresa.represetanteLegal;
        //
        empresa2Row(oe, dr);
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
        // devuelve una tabla con los datos de la tabla empresa
        SqlDataAdapter da;
        DataTable dt = new DataTable("empresa");
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
    public static empresa Buscar(string sWhere){
        // Busca en la tabla los datos indicados en el parámetro
        // el parámetro contendrá lo que se usará después del WHERE
        empresa oempresa = null;
        SqlDataAdapter da;
        DataTable dt = new DataTable("empresa");
        string sel = "SELECT * FROM empresa WHERE " + sWhere;
        //
        da = new SqlDataAdapter(sel, cadenaConexion);
        da.Fill(dt);
        //
        if(dt.Rows.Count > 0){
            oempresa = row2empresa(dt.Rows[0]);
        }
        return oempresa;
    }
    //
    // Actualizar: Actualiza los datos en la tabla usando la instancia actual
    //             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    //             Para comprobar si el objeto en memoria coincide con uno existente,
    //             se comprueba si el IdEscalaCalificacion existe en la tabla.
    //             TODO: Si en lugar de IdEscalaCalificacion usas otro campo, indicalo en la cadena SELECT
    //                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    public string Actualizar(){
        // TODO: Poner aquí la selección a realizar para acceder a este registro
        //       yo uso el IdEscalaCalificacion que es el identificador único de cada registro
        string sel = "SELECT * FROM empresa WHERE IdEscalaCalificacion = " + this.IdEscalaCalificacion.ToString();
        return Actualizar(sel);
    }
    public string Actualizar(string sel){
        // Actualiza los datos indicados
        // El parámetro, que es una cadena de selección, indicará el criterio de actualización
        //
        // En caso de error, devolverá la cadena empezando por ERROR.
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt = new DataTable("empresa");
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
        ////       Yo compruebo que sea un campo llamado IdEscalaCalificacion, pero en tu caso puede ser otro
        ////       Ese campo, (en mi caso IdEscalaCalificacion) será el que hay que poner al final junto al WHERE.
        //sCommand = "UPDATE empresa SET idCaracteristicaRV = @idCaracteristicaRV, caracteristicaRV = @caracteristicaRV, idClasificacionRV = @idClasificacionRV, idEmpresa = @idEmpresa, Valor = @Valor, idTipoRecurso = @idTipoRecurso, tipoRecurso = @tipoRecurso, idRecursoEmpresa = @idRecursoEmpresa, recurso = @recurso, Descripcion = @Descripcion, Escala = @Escala, nit = @nit, nombreEmpresa = @nombreEmpresa, represetanteLegal = @represetanteLegal  WHERE (IdEscalaCalificacion = @IdEscalaCalificacion)";
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
            empresa2Row(this, dt.Rows[0]);
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
        DataTable dt = new DataTable("empresa");
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
        ////       Yo compruebo que sea un campo llamado IdEscalaCalificacion, pero en tu caso puede ser otro
        //sCommand = "INSERT INTO empresa (caracteristicaRV, idClasificacionRV, Valor, tipoRecurso, recurso, Descripcion, Escala, nit, nombreEmpresa, represetanteLegal)  VALUES(@caracteristicaRV, @idClasificacionRV, @Valor, @tipoRecurso, @recurso, @Descripcion, @Escala, @nit, @nombreEmpresa, @represetanteLegal)";
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
        //
        //
        try{
            da.Fill(dt);
        }catch(Exception ex){
            return "ERROR: " + ex.Message;
        }
        //
        nuevoempresa(dt, this);
        //
        try{
            da.Update(dt);
            dt.AcceptChanges();
            return "Se ha creado un nuevo empresa";
        }catch(Exception ex){
            return "ERROR: " + ex.Message;
        }
    }
    //
    public string Borrar(){
        // TODO: Poner aquí la selección a realizar para acceder a este registro
        //       yo uso el IdEscalaCalificacion que es el identificador único de cada registro
        string sel = "SELECT * FROM empresa WHERE IdEscalaCalificacion = " + this.IdEscalaCalificacion.ToString();
        //
        return Borrar(sel);
    }
    public string Borrar(string sel){
        // Borrar el registro al que apunta esta clase
        // En caso de error, devolverá la cadena de error empezando por ERROR:.
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt = new DataTable("empresa");
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
        ////       Yo compruebo que sea un campo llamado IdEscalaCalificacion, pero en tu caso puede ser otro
        //sCommand = "DELETE FROM empresa WHERE (IdEscalaCalificacion = @p1)";
        //da.DeleteCommand = new SqlCommand(sCommand, cnn);
        //// TODO: Comprobar el tipo de datos a usar...
        //da.DeleteCommand.Parameters.Add("@p1", SqlDbType.SmallInt, 0, "IdEscalaCalificacion");
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
