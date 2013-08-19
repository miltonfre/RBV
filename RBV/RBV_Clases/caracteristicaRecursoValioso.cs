//------------------------------------------------------------------------------
// Clase caracteristicaRecursoValioso generada automáticamente con CrearClaseSQL
// de la tabla 'caracteristicaRecursoValioso' de la base 'RBV'
// Fecha: 18/ago/2013 23:54:50
//
// ©Guillermo 'guille' Som, 2004-2013
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
//
public class caracteristicaRecursoValioso{
    // Las variables privadas
    // TODO: Revisar los tipos de los campos
    private System.Int16 _idCaracteristicaRV;
    private System.String _caracteristicaRV;
    private System.Int16 _idClasificacionRV;
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
            }
        }
    }
    //
    // Campos y métodos compartidos (estáticos) para gestionar la base de datos
    //
    // La cadena de conexión a la base de datos
    private static string cadenaConexion = @"Data Source=Milton1; Initial Catalog=RBV; user id=USR_RBV; password=USR_RBV";
    // La cadena de selección
    public static string CadenaSelect = "SELECT * FROM caracteristicaRecursoValioso";
    //
    public caracteristicaRecursoValioso(){
    }
    public caracteristicaRecursoValioso(string conex){
        cadenaConexion = conex;
    }
    //
    // Métodos compartidos (estáticos) privados
    //
    // asigna una fila de la tabla a un objeto caracteristicaRecursoValioso
    private static caracteristicaRecursoValioso row2caracteristicaRecursoValioso(DataRow r){
        // asigna a un objeto caracteristicaRecursoValioso los datos del dataRow indicado
        caracteristicaRecursoValioso ocaracteristicaRecursoValioso = new caracteristicaRecursoValioso();
        //
        ocaracteristicaRecursoValioso.idCaracteristicaRV = System.Int16.Parse("0" + r["idCaracteristicaRV"].ToString());
        ocaracteristicaRecursoValioso.caracteristicaRV = r["caracteristicaRV"].ToString();
        ocaracteristicaRecursoValioso.idClasificacionRV = System.Int16.Parse("0" + r["idClasificacionRV"].ToString());
        //
        return ocaracteristicaRecursoValioso;
    }
    //
    // asigna un objeto caracteristicaRecursoValioso a la fila indicada
    private static void caracteristicaRecursoValioso2Row(caracteristicaRecursoValioso ocaracteristicaRecursoValioso, DataRow r){
        // asigna un objeto caracteristicaRecursoValioso al dataRow indicado
        // TODO: Comprueba si esta asignación debe hacerse
        //       pero mejor lo dejas comentado ya que es un campo autoincremental o único
        //r["idCaracteristicaRV"] = ocaracteristicaRecursoValioso.idCaracteristicaRV;
        r["caracteristicaRV"] = ocaracteristicaRecursoValioso.caracteristicaRV;
        r["idClasificacionRV"] = ocaracteristicaRecursoValioso.idClasificacionRV;
    }
    //
    // crea una nueva fila y la asigna a un objeto caracteristicaRecursoValioso
    private static void nuevocaracteristicaRecursoValioso(DataTable dt, caracteristicaRecursoValioso ocaracteristicaRecursoValioso){
        // Crear un nuevo caracteristicaRecursoValioso
        DataRow dr = dt.NewRow();
        caracteristicaRecursoValioso oc = row2caracteristicaRecursoValioso(dr);
        //
        oc.idCaracteristicaRV = ocaracteristicaRecursoValioso.idCaracteristicaRV;
        oc.caracteristicaRV = ocaracteristicaRecursoValioso.caracteristicaRV;
        oc.idClasificacionRV = ocaracteristicaRecursoValioso.idClasificacionRV;
        //
        caracteristicaRecursoValioso2Row(oc, dr);
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
        // devuelve una tabla con los datos de la tabla caracteristicaRecursoValioso
        SqlDataAdapter da;
        DataTable dt = new DataTable("caracteristicaRecursoValioso");
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
    public static caracteristicaRecursoValioso Buscar(string sWhere){
        // Busca en la tabla los datos indicados en el parámetro
        // el parámetro contendrá lo que se usará después del WHERE
        caracteristicaRecursoValioso ocaracteristicaRecursoValioso = null;
        SqlDataAdapter da;
        DataTable dt = new DataTable("caracteristicaRecursoValioso");
        string sel = "SELECT * FROM caracteristicaRecursoValioso WHERE " + sWhere;
        //
        da = new SqlDataAdapter(sel, cadenaConexion);
        da.Fill(dt);
        //
        if(dt.Rows.Count > 0){
            ocaracteristicaRecursoValioso = row2caracteristicaRecursoValioso(dt.Rows[0]);
        }
        return ocaracteristicaRecursoValioso;
    }
    //
    // Actualizar: Actualiza los datos en la tabla usando la instancia actual
    //             Si la instancia no hace referencia a un registro existente, se creará uno nuevo
    //             Para comprobar si el objeto en memoria coincide con uno existente,
    //             se comprueba si el idCaracteristicaRV existe en la tabla.
    //             TODO: Si en lugar de idCaracteristicaRV usas otro campo, indicalo en la cadena SELECT
    //                   También puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    public string Actualizar(){
        // TODO: Poner aquí la selección a realizar para acceder a este registro
        //       yo uso el idCaracteristicaRV que es el identificador único de cada registro
        string sel = "SELECT * FROM caracteristicaRecursoValioso WHERE idCaracteristicaRV = " + this.idCaracteristicaRV.ToString();
        return Actualizar(sel);
    }
    public string Actualizar(string sel){
        // Actualiza los datos indicados
        // El parámetro, que es una cadena de selección, indicará el criterio de actualización
        //
        // En caso de error, devolverá la cadena empezando por ERROR.
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt = new DataTable("caracteristicaRecursoValioso");
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
        ////       Yo compruebo que sea un campo llamado idCaracteristicaRV, pero en tu caso puede ser otro
        ////       Ese campo, (en mi caso idCaracteristicaRV) será el que hay que poner al final junto al WHERE.
        //sCommand = "UPDATE caracteristicaRecursoValioso SET caracteristicaRV = @caracteristicaRV, idClasificacionRV = @idClasificacionRV  WHERE (idCaracteristicaRV = @idCaracteristicaRV)";
        //da.UpdateCommand = new SqlCommand(sCommand, cnn);
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@idCaracteristicaRV", SqlDbType.SmallInt, 0, "idCaracteristicaRV");
        //da.UpdateCommand.Parameters.Add("@caracteristicaRV", SqlDbType.NVarChar, 50, "caracteristicaRV");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.UpdateCommand.Parameters.Add("@idClasificacionRV", SqlDbType.SmallInt, 0, "idClasificacionRV");
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
            caracteristicaRecursoValioso2Row(this, dt.Rows[0]);
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
        DataTable dt = new DataTable("caracteristicaRecursoValioso");
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
        ////       Yo compruebo que sea un campo llamado idCaracteristicaRV, pero en tu caso puede ser otro
        //sCommand = "INSERT INTO caracteristicaRecursoValioso (caracteristicaRV, idClasificacionRV)  VALUES(@caracteristicaRV, @idClasificacionRV)";
        //da.InsertCommand = new SqlCommand(sCommand, cnn);
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@idCaracteristicaRV", SqlDbType.SmallInt, 0, "idCaracteristicaRV");
        //da.InsertCommand.Parameters.Add("@caracteristicaRV", SqlDbType.NVarChar, 50, "caracteristicaRV");
        //// TODO: Comprobar el tipo de datos a usar...
        //da.InsertCommand.Parameters.Add("@idClasificacionRV", SqlDbType.SmallInt, 0, "idClasificacionRV");
        //
        //
        try{
            da.Fill(dt);
        }catch(Exception ex){
            return "ERROR: " + ex.Message;
        }
        //
        nuevocaracteristicaRecursoValioso(dt, this);
        //
        try{
            da.Update(dt);
            dt.AcceptChanges();
            return "Se ha creado un nuevo caracteristicaRecursoValioso";
        }catch(Exception ex){
            return "ERROR: " + ex.Message;
        }
    }
    //
    public string Borrar(){
        // TODO: Poner aquí la selección a realizar para acceder a este registro
        //       yo uso el idCaracteristicaRV que es el identificador único de cada registro
        string sel = "SELECT * FROM caracteristicaRecursoValioso WHERE idCaracteristicaRV = " + this.idCaracteristicaRV.ToString();
        //
        return Borrar(sel);
    }
    public string Borrar(string sel){
        // Borrar el registro al que apunta esta clase
        // En caso de error, devolverá la cadena de error empezando por ERROR:.
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt = new DataTable("caracteristicaRecursoValioso");
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
        ////       Yo compruebo que sea un campo llamado idCaracteristicaRV, pero en tu caso puede ser otro
        //sCommand = "DELETE FROM caracteristicaRecursoValioso WHERE (idCaracteristicaRV = @p1)";
        //da.DeleteCommand = new SqlCommand(sCommand, cnn);
        //// TODO: Comprobar el tipo de datos a usar...
        //da.DeleteCommand.Parameters.Add("@p1", SqlDbType.SmallInt, 0, "idCaracteristicaRV");
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
