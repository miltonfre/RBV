//------------------------------------------------------------------------------
// Clase escalaValoracion generada autom�ticamente con CrearClaseSQL
// de la tabla 'escalaValoracion' de la base 'RBV'
// Fecha: 18/ago/2013 23:58:33
//
// �Guillermo 'guille' Som, 2004-2013
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
//
public class escalaValoracion{
    // Las variables privadas
    // TODO: Revisar los tipos de los campos
    private System.Int16 _idCaracteristicaRV;
    private System.String _caracteristicaRV;
    private System.Int16 _idClasificacionRV;
    private System.Int16 _idEmpresa;
    private System.Decimal _Valor;
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
            }
        }
    }
    //
    // Campos y m�todos compartidos (est�ticos) para gestionar la base de datos
    //
    // La cadena de conexi�n a la base de datos
    private static string cadenaConexion = @"Data Source=Milton1; Initial Catalog=RBV; user id=USR_RBV; password=USR_RBV";
    // La cadena de selecci�n
    public static string CadenaSelect = "SELECT * FROM escalaValoracion";
    //
    public escalaValoracion(){
    }
    public escalaValoracion(string conex){
        cadenaConexion = conex;
    }
    //
    // M�todos compartidos (est�ticos) privados
    //
    // asigna una fila de la tabla a un objeto escalaValoracion
    private static escalaValoracion row2escalaValoracion(DataRow r){
        // asigna a un objeto escalaValoracion los datos del dataRow indicado
        escalaValoracion oescalaValoracion = new escalaValoracion();
        //
        oescalaValoracion.idCaracteristicaRV = System.Int16.Parse("0" + r["idCaracteristicaRV"].ToString());
        oescalaValoracion.caracteristicaRV = r["caracteristicaRV"].ToString();
        oescalaValoracion.idClasificacionRV = System.Int16.Parse("0" + r["idClasificacionRV"].ToString());
        oescalaValoracion.idEmpresa = System.Int16.Parse("0" + r["idEmpresa"].ToString());
        oescalaValoracion.Valor = System.Decimal.Parse("0" + r["Valor"].ToString());
        //
        return oescalaValoracion;
    }
    //
    // asigna un objeto escalaValoracion a la fila indicada
    private static void escalaValoracion2Row(escalaValoracion oescalaValoracion, DataRow r){
        // asigna un objeto escalaValoracion al dataRow indicado
        // TODO: Comprueba si esta asignaci�n debe hacerse
        //       pero mejor lo dejas comentado ya que es un campo autoincremental o �nico
        //r["idCaracteristicaRV"] = oescalaValoracion.idCaracteristicaRV;
        r["caracteristicaRV"] = oescalaValoracion.caracteristicaRV;
        r["idClasificacionRV"] = oescalaValoracion.idClasificacionRV;
        r["idEmpresa"] = oescalaValoracion.idEmpresa;
        r["Valor"] = oescalaValoracion.Valor;
    }
    //
    // crea una nueva fila y la asigna a un objeto escalaValoracion
    private static void nuevoescalaValoracion(DataTable dt, escalaValoracion oescalaValoracion){
        // Crear un nuevo escalaValoracion
        DataRow dr = dt.NewRow();
        escalaValoracion oe = row2escalaValoracion(dr);
        //
        oe.idCaracteristicaRV = oescalaValoracion.idCaracteristicaRV;
        oe.caracteristicaRV = oescalaValoracion.caracteristicaRV;
        oe.idClasificacionRV = oescalaValoracion.idClasificacionRV;
        oe.idEmpresa = oescalaValoracion.idEmpresa;
        oe.Valor = oescalaValoracion.Valor;
        //
        escalaValoracion2Row(oe, dr);
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
        // devuelve una tabla con los datos de la tabla escalaValoracion
        SqlDataAdapter da;
        DataTable dt = new DataTable("escalaValoracion");
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
    public static escalaValoracion Buscar(string sWhere){
        // Busca en la tabla los datos indicados en el par�metro
        // el par�metro contendr� lo que se usar� despu�s del WHERE
        escalaValoracion oescalaValoracion = null;
        SqlDataAdapter da;
        DataTable dt = new DataTable("escalaValoracion");
        string sel = "SELECT * FROM escalaValoracion WHERE " + sWhere;
        //
        da = new SqlDataAdapter(sel, cadenaConexion);
        da.Fill(dt);
        //
        if(dt.Rows.Count > 0){
            oescalaValoracion = row2escalaValoracion(dt.Rows[0]);
        }
        return oescalaValoracion;
    }
    //
    // Actualizar: Actualiza los datos en la tabla usando la instancia actual
    //             Si la instancia no hace referencia a un registro existente, se crear� uno nuevo
    //             Para comprobar si el objeto en memoria coincide con uno existente,
    //             se comprueba si el idCaracteristicaRV existe en la tabla.
    //             TODO: Si en lugar de idCaracteristicaRV usas otro campo, indicalo en la cadena SELECT
    //                   Tambi�n puedes usar la sobrecarga en la que se indica la cadena SELECT a usar
    public string Actualizar(){
        // TODO: Poner aqu� la selecci�n a realizar para acceder a este registro
        //       yo uso el idCaracteristicaRV que es el identificador �nico de cada registro
        string sel = "SELECT * FROM escalaValoracion WHERE idCaracteristicaRV = " + this.idCaracteristicaRV.ToString();
        return Actualizar(sel);
    }
    public string Actualizar(string sel){
        // Actualiza los datos indicados
        // El par�metro, que es una cadena de selecci�n, indicar� el criterio de actualizaci�n
        //
        // En caso de error, devolver� la cadena empezando por ERROR.
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt = new DataTable("escalaValoracion");
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
        ////       Yo compruebo que sea un campo llamado idCaracteristicaRV, pero en tu caso puede ser otro
        ////       Ese campo, (en mi caso idCaracteristicaRV) ser� el que hay que poner al final junto al WHERE.
        //sCommand = "UPDATE escalaValoracion SET caracteristicaRV = @caracteristicaRV, idClasificacionRV = @idClasificacionRV, idEmpresa = @idEmpresa, Valor = @Valor  WHERE (idCaracteristicaRV = @idCaracteristicaRV)";
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
            escalaValoracion2Row(this, dt.Rows[0]);
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
        DataTable dt = new DataTable("escalaValoracion");
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
        ////       Yo compruebo que sea un campo llamado idCaracteristicaRV, pero en tu caso puede ser otro
        //sCommand = "INSERT INTO escalaValoracion (caracteristicaRV, idClasificacionRV, idEmpresa, Valor)  VALUES(@caracteristicaRV, @idClasificacionRV, @idEmpresa, @Valor)";
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
        //
        //
        try{
            da.Fill(dt);
        }catch(Exception ex){
            return "ERROR: " + ex.Message;
        }
        //
        nuevoescalaValoracion(dt, this);
        //
        try{
            da.Update(dt);
            dt.AcceptChanges();
            return "Se ha creado un nuevo escalaValoracion";
        }catch(Exception ex){
            return "ERROR: " + ex.Message;
        }
    }
    //
    public string Borrar(){
        // TODO: Poner aqu� la selecci�n a realizar para acceder a este registro
        //       yo uso el idCaracteristicaRV que es el identificador �nico de cada registro
        string sel = "SELECT * FROM escalaValoracion WHERE idCaracteristicaRV = " + this.idCaracteristicaRV.ToString();
        //
        return Borrar(sel);
    }
    public string Borrar(string sel){
        // Borrar el registro al que apunta esta clase
        // En caso de error, devolver� la cadena de error empezando por ERROR:.
        SqlConnection cnn;
        SqlDataAdapter da;
        DataTable dt = new DataTable("escalaValoracion");
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
        ////       Yo compruebo que sea un campo llamado idCaracteristicaRV, pero en tu caso puede ser otro
        //sCommand = "DELETE FROM escalaValoracion WHERE (idCaracteristicaRV = @p1)";
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
