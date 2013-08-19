/*Creado por Daniel López - danypype@gmail.com*/

jQuery.noConflict();

//Previene el evento por defecto de cualquier control o elemento, recibe el evento.
function pde(e) 
{
    e.preventDefault ? e.preventDefault() : e.returnValue = false;
}


// function ExportDivDataToExcel()
//    {
//        alert("Prueba");
//        var html = $("#listado").html();
//        html = $.trim(html);
//        html = html.replace(/>/g,'&gt;');
//        html = html.replace(/</g,'&lt;');
//        $("input[id$='HdnValue']").val(html);
//    }

/*Obtiene la lista de entidades relacionadas con la entidad enviada como parámetro
y las inserta dentro de un control <select> HTML*/
function cargarDatosDistribucionRiesgosAsociados() {
    //Representación string del objeto JSON que recibe el método definido en C#
    /*Funcion ajax que se encarga de obtener la lista de entidades relacionadas
    y posteriormente de insertarlas en el control HTML*/
    jQuery.ajax({
        type: "POST", //Indica que se realizará un POST al método definido en C#
        url: "DistribucionRiesgosPorRiesgosAsociados.aspx/RetornarDistribucion", /*Ruta del método definido en C# que retorna la lista de entidades
                                                             (la ruta es relativa al formulario que ancla este js) */
        data: "", //Representación string del objeto JSON que recibe el método definido en C# (parámetro(s) del método)
        contentType: "application/json; charset=utf-8", //Indica que se enviará contenido tipo JSON
        dataType: "json", //Indica que se recibirá contenido JSON
        //Función que se ejecuta desde el momento en que se envian los datos hasta que llegan
//        beforeSend: function(e) {
//            //if (jQuery("#filtro-" + num).length == 1) {
//            var loadingGif = "<img src='../img/loading-tiny.gif' style='position:absolute;top:20px;left:205px;' id='loadingGif'/>";
//            //jQuery("#filtro-" + num).append(loadingGif);
//            //}
//            //jQuery("#listaFiltros select").attr("disabled", "disabled");
//        },
        //Función que se ejecutará en caso de error
        error: function(request, status, error) {
            alert("Se ha producido un error en el servidor: "+status);
            return;
        },
        //Función que se ejecuta en caso de recepción existosa
        success: function(lineas) {
            jQuery("#listado").setTemplateElement("Template-listado").processTemplate(lineas);            
        }
    });
}

function cargarDatosDistribucionFactoresRiesgo() {
    //Representación string del objeto JSON que recibe el método definido en C#
    /*Funcion ajax que se encarga de obtener la lista de entidades relacionadas
    y posteriormente de insertarlas en el control HTML*/
    jQuery.ajax({
        type: "POST", //Indica que se realizará un POST al método definido en C#
        url: "DistribucionRiesgosPorFactoresRiesgo.aspx/RetornarDistribucion", /*Ruta del método definido en C# que retorna la lista de entidades
                                                             (la ruta es relativa al formulario que ancla este js) */
        data: "", //Representación string del objeto JSON que recibe el método definido en C# (parámetro(s) del método)
        contentType: "application/json; charset=utf-8", //Indica que se enviará contenido tipo JSON
        dataType: "json", //Indica que se recibirá contenido JSON
        //Función que se ejecuta desde el momento en que se envian los datos hasta que llegan
//        beforeSend: function(e) {
//            //if (jQuery("#filtro-" + num).length == 1) {
//            var loadingGif = "<img src='../img/loading-tiny.gif' style='position:absolute;top:20px;left:205px;' id='loadingGif'/>";
//            //jQuery("#filtro-" + num).append(loadingGif);
//            //}
//            //jQuery("#listaFiltros select").attr("disabled", "disabled");
//        },
        //Función que se ejecutará en caso de error
        error: function(request, status, error) {
            alert("Se ha producido un error en el servidor: "+status);
            return;
        },
        //Función que se ejecuta en caso de recepción existosa
        success: function(lineas) {
            jQuery("#listado").setTemplateElement("Template-listado").processTemplate(lineas);            
        }
    });
}
