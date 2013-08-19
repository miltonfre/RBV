//------------------------------------------------------------------------------
// Clase matrizValoracion generada autom�ticamente con CrearClaseSQL
// de la tabla 'matrizValoracion' de la base 'RBV'
// Fecha: 18/ago/2013 23:58:47
//
// �Guillermo 'guille' Som, 2004-2013
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
//
public class matrizValoracion{
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
    //
    public string this[int index]{
        // Devuelve el contenido del campo indicado en index
        // (el �ndice corresponde con la columna de la tabla)
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
            }
        }
    }
    public string this[string index]{
        // Devuelve el contenido del campo indicado en index
        // (el �ndice corresponde al nombre de la columna)
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
            }
        }
    }
    //
    // Campos y m�todos compartidos (est�ticos) para gestionar la base de datos
    //
    // La cadena de conexi�n a la base de datos
    private static string cadenaConexion = @"Data Source=Milton1; Initial Catalog=RBV; user id=USR_RBV; password=USR_RBV";
    // La cadena de selecci�n
    public static string CadenaSelect = "SELECT * FROM matrizValoracion";
    //
    public matrizValoracion(){
    }
    public matrizValoracion(string conex){
        cadenaConexion = conex;
    }
    //
    // M�todos compartidos (est�ticos) privados
    //
    // asigna una fila de la tabla a un objeto matrizValoracion
    private static matrizValoracion row2matrizValoracion(DataRow r){
        // asigna a un objeto matrizValoracion los datos del dataRow indicado
        matrizValoracion omatrizValoracion = new matrizValoracion();
        //
        omatrizValoracion.idCaracteristicaRV = System.Int16.Parse("0" + r["idCaracteristicaRV"].ToString());
        omatrizValoracion.caracteristicaRV = r["caracteristicaRV"].ToString();
        omatrizValoracion.idClasificacionRV = System.Int16.Parse("0" + r["idClasificacionRV"].ToString());
        omatrizValoracion.idEmpresa = System.Int16.Parse("0" + r["idEmpresa"].ToString());
        omatrizValoracion.Valor = System.Decimal.Parse("0" + r["Valor"].ToString());
        omatrizValoracion.idTipoRecurso = System.Int16.Parse("0" + r["idTipoRecurso"].ToString());
        omatrizValoracion.tipoRecurso = r["tipoRecurso"].ToString();
        omatrizValoracion.idRecursoEmpresa = System.Int16.Parse("0" + r["idRecursoEmpresa"].ToString());
        //
        return omatrizValoracion;
    }
    //
    // asigna un objeto matrizValoracion a la fila indicada
    private static void matrizValoracion2Row(matrizValoracion omatrizValoracion, DataRow r){
        // asigna un objeto matrizValoracion al dataRow indicado
        // TODO: Comprueba si esta asignaci�n debe hacerse
        //       pero mejor lo dejas comentado ya que es un campo autoincremental o �nico
        //r["idCaracteristicaRV"] = omatrizValoracion.idCaracteristicaRV;
        r["caracteristicaRV"] = omatrizValoracion.caracteristicaRV;
        r["idClasificacionRV"] = omatrizValoracion.idClasificacionRV;
        r["idEmpresa"] = omatrizValoracion.idEmpresa;
        r["Valor"] = omatrizValoracion.Valor;
        // TODO: Comprueba si esta asignaci�n debe hacerse
        //       pero mejor lo dejas comentado ya que es un campo autoincremental o �nico
        //r["idTipoRecurso"] = omatrizValoracion.idTipoRecurso;
        r["tipoRecurso"] = omatrizValoracion.tipoRecurso;
        r["idRecursoEmpresa"] = omatrizValoracion.idRecursoEmpresa;
    }
    //
    // crea una nueva fila y la asigna a un objeto matrizValoracion
    private static void nuevomatrizValoracion(DataTable dt, matrizValoracion omatrizValoracion){
        // Crear un nuevo matrizValoracion
        DataRow dr = dt.NewRow();
        matrizValoracion om = row2matrizValoracion(dr);
        //
        om.idCaracteristicaRV = omatrizValoracion.idCaracteristicaRV;
        om.caracteristicaRV = omatrizValoracion.caracteristicaRV;
        om.idClasificacionRV = omatrizValoracion.idClasificacionRV;
        om.idEmpresa = omatrizValoracion.idEmpresa;
        om.Valor = omatrizValoracion.Valor;
        om.idTipoRecurso = omatrizValoracion.idTipoRecurso;
        om.tipoRecurso = omatrizValoracion.tipoRecurso;
        om.idRecursoEmpresa = omatrizValoracion.idRecursoEmpresa;
        //
        matrizValoracion2Row(om, dr);
        //
        dt.Rows.Add(dr);
    }
    //
    // M�todos p�blicos
    //
    // devuelve una tabla con los datos indicados en la cadena de selecci�n
    public static DataTable Tabla(){
        return Tabla(CadenaSelect);
    }
    public static DataTable Tabla(string sel){
        // devuelve una tabla con los datos de la tabla matrizValoracion
        SqlDataAdapter da;
        DataTable dt = new DataTable("matrizValoracion");
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
    public static matrizValoracion Buscar(string sWhere){
        // Busca en la tabla los datos indicados en el par�metro
        // el par�metro contendr� lo que se usar� despu�s del WHERE
        matrizValoracion omatrizValoracion = null;
        SqlDataAdapter da;
        DataTable dt = new DataTable("matrizValoracion");
        string sel = "SELECT * FROM matrizValoracion WHERE " + sWhere;
        //
        da = new SqlDataAdapter(sel, cadenaConexion);
        da.Fill(dt);
        //
        if(dt.Rows.Count > 0){
            omatrizValoracion = row2matrizValoracion(dt.Rows[0]);
        }
        return omatrizValoracion;
    }
    //
    // Actualizar: Actualiza los datos en la tabla usando la instancia actual
    //             Si la instancia no hace referencia a un registro existente, se crear� uno nuevo
    //             Para comprobar si el objeto en memoria coincide con uno existente,
    //             se comprueba si el idTipoRecurso existe en la tabla.
    //             TODO: Si en lugar de idTipoRecurso usas otro campo, indicalo en la cadena SELECT
    //                   Tambi�n puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    public string Actualizar(){
        // TODO: Poner aqu� la selecci�n a realizar para acceder a este registro
        //       yo uso el idTipoRecurso que es el identificador �nico de cada registro
        string sel = "SELECT * FROM matrizValoracion WHERE idTipoRecurso = " + this.idTipoRecurso.ToString();
        return Actualizar(sel);
    }
    public string Actualizar(string sel){
        // Actualiza los datos indicados
        // El par�metro, que es una cadena de selecci�n, indicar� el criterio de actualizaci�n
        //
        // En caso de error, devolver� la cadena empezando por ERROR.
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt = new DataTable("matrizValoracion");
        //
        cnn = new SqlConnection(cadenaConexion);
        //da = new SqlDataAdapter(CadenaSelect, cnn);
        da = new SqlDataAdapter(sel, cnn);
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
        //
        //-------------------------------------------
        // Esta no es la m�s �ptima, pero funcionar�
        //-------------------------------------------
        SqlCommandBuilder cb = new SqlCommandBuilder(da);
        da.UpdateCommand = cb.GetUpdateCommand();
        //
        //--------------------------------------------------------------------
        // Esta est� m�s optimizada pero debes comprobar que funciona bien...
        //--------------------------------------------------------------------
        //string sCommand;
        ////
        //// El comando UPDATE
        //// TODO: Comprobar cual es el campo de �ndice principal (sin duplicados)
        ////       Yo compruebo que sea un campo llamado idTipoRecurso, pero en tu caso puede ser otro
        ////       Ese campo, (en mi caso idTipoRecurso) ser� el que hay que poner al final junto al WHERE.
        //sCommand = "UPDATE matrizValoracion SET idCaracteristicaRV = @idCaracteristicaRV, caracteristicaRV = @caracteristicaRV, idClasificacionRV = @idClasificacionRV, idEmpresa = @idEmpresa, Valor = @Valor, tipoRecurso = @tipoRecurso, idRecursoEmpresa = @idRecursoEmpresa  WHERE (idTipoRecurso = @idTipoRecurso)";
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
            matrizValoracion2Row(this, dt.Rows[0]);
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
        // En caso de error, devolver� la cadena de error empezando por ERROR:.
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt = new DataTable("matrizValoracion");
        //
        cnn = new SqlConnection(cadenaConexion);
        da = new SqlDataAdapter(CadenaSelect, cnn);
        //da = new SqlDataAdapter(CadenaSelect, cadenaConexion);
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
        //
        //-------------------------------------------
        // Esta no es la m�s �ptima, pero funcionar�
        //-------------------------------------------
        SqlCommandBuilder cb = new SqlCommandBuilder(da);
        da.InsertCommand = cb.GetInsertCommand();
        //
        //--------------------------------------------------------------------
        // Esta est� m�s optimizada pero debes comprobar que funciona bien...
        //--------------------------------------------------------------------
        //string sCommand;
        ////
        //// El comando INSERT
        //// TODO: No incluir el campo de clave primaria incremental
        ////       Yo compruebo que sea un campo llamado idTipoRecurso, pero en tu caso puede ser otro
        //sCommand = "INSERT INTO matrizValoracion (caracteristicaRV, idClasificacionRV, idEmpresa, Valor, tipoRecurso, idRecursoEmpresa)  VALUES(@caracteristicaRV, @idClasificacionRV, @idEmpresa, @Valor, @tipoRecurso, @idRecursoEmpresa)";
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
        //
        //
        try{
            da.Fill(dt);
        }catch(Exception ex){
            return "ERROR: " + ex.Message;
        }
        //
        nuevomatrizValoracion(dt, this);
        //
        try{
            da.Update(dt);
            dt.AcceptChanges();
            return "Se ha creado un nuevo matrizValoracion";
        }catch(Exception ex){
            return "ERROR: " + ex.Message;
        }
    }
    //
    public string Borrar(){
        // TODO: Poner aqu� la selecci�n a realizar para acceder a este registro
        //       yo uso el idTipoRecurso que es el identificador �nico de cada registro
        string sel = "SELECT * FROM matrizValoracion WHERE idTipoRecurso = " + this.idTipoRecurso.ToString();
        //
        return Borrar(sel);
    }
    public string Borrar(string sel){
        // Borrar el registro al que apunta esta clase
        // En caso de error, devolver� la cadena de error empezando por ERROR:.
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt = new DataTable("matrizValoracion");
        //
        cnn = new SqlConnection(cadenaConexion);
        da = new SqlDataAdapter(sel, cnn);
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
        //
        //-------------------------------------------
        // Esta no es la m�s �ptima, pero funcionar�
        //-------------------------------------------
        SqlCommandBuilder cb = new SqlCommandBuilder(da);
        da.DeleteCommand = cb.GetDeleteCommand();
        //
        //
        //--------------------------------------------------------------------
        // Esta est� m�s optimizada pero debes comprobar que funciona bien...
        //--------------------------------------------------------------------
        //string sCommand;
        ////
        //// El comando DELETE
        //// TODO: S�lo incluir el campo de clave primaria incremental
        ////       Yo compruebo que sea un campo llamado idTipoRecurso, pero en tu caso puede ser otro
        //sCommand = "DELETE FROM matrizValoracion WHERE (idTipoRecurso = @p1)";
        //da.DeleteCommand = new SqlCommand(sCommand, cnn);
        //// TODO: Comprobar el tipo de datos a usar...
        //da.DeleteCommand.Parameters.Add("@p1", SqlDbType.SmallInt, 0, "idTipoRecurso");
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
