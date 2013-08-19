/*Creado por Daniel López - danypype@gmail.com*/

jQuery.noConflict();

/*Ejecuta una serie de acciones imediatamente 
cuando el documento se ha descargado completamente*/
jQuery(document).ready(function(e) {
//cargarDatosLineas();
    jQuery(".btnGenerarReporte").eq(0).click(function(e) {
        pde(e);
        cargarDatosLineas();
    }); 
});

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
function cargarDatosLineas() {
    //Representación string del objeto JSON que recibe el método definido en C#
    
    /*Funcion ajax que se encarga de obtener la lista de entidades relacionadas
    y posteriormente de insertarlas en el control HTML*/
    jQuery.ajax({
        type: "POST", //Indica que se realizará un POST al método definido en C#
        url: "ReporteMatrizLineasOperativas.aspx/RetornarLineas", /*Ruta del método definido en C# que retorna la lista de entidades
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
        error: function(e) {
            alert("Ocurrió un problema en el servidor");
            return;
        },
        //Función que se ejecuta en caso de recepción existosa
        success: function(lineas) {

            jQuery("#listado").setTemplateElement("Template-listado").processTemplate(lineas);
            /*if (jQuery("#filtro-" + num).length == 0) {
            var listItem = '<li id="filtro-' + num + '" style="z-index:' + (1000 - num) + '">' +
            '<p>Entidad # ' + num + '</p>' +
            '<select id="entidadList-' + num + '" class="listaEntidades">' +
            '</select>' +
            '<div class="listaCampos">' +
            '<p>Campos seleccionados: 0</p>' +
            '<a href="" title="Desplegar lista" class="btnDesplegarCampos arrow-down"></a>' +
            '<ul id="camposList-' + num + '" class="listCampoEntidad">' +
            '</ul>' +
            '</div>' +
            '</li>';

                jQuery("#listaFiltros").append(listItem);
            }
            else if (jQuery("#filtro-" + num).length == 1) {
            var x = num + 1;
            while (jQuery("#filtro-" + x).length > 0) {
            jQuery("#filtro-" + x).remove();
            x++;
            }
            }

            jQuery("#entidadList-" + num).html('<option value="seleccione">Seleccione...</option>');

            var entidadesSeleccionadas = new Array();
            for (i = 0; i < jQuery("#listaFiltros select").length; i++) {
            entidadesSeleccionadas[i] = jQuery("#listaFiltros select").eq(i).val();
            }*/

            //for (i = 0; i < entidades.d.length; i++) {
                //alert(entidades.d[i]);
                /*var nombre = entidades[i].substring(0, entidades[i].indexOf(","));
                // ignora el elemento cuando es una entidad que ya está repetida en la lista
                if (jQuery.inArray(nombre, entidadesSeleccionadas) == -1) {
                    var nombreMostrar = entidades[i].substring(entidades[i].indexOf(",") + 1, entidades[i].length);
                    jQuery("#entidadList-" + num).append('<option value="' + nombre + '">' + nombreMostrar + '</option>');
                }*/
            //}

            /*jQuery("#camposList-" + num).html("");

            jQuery("#entidadList-" + num).off("change");
            jQuery("#entidadList-" + num).change(function(e) {
                cargarCamposClasificaciones(num, jQuery(this).val());
                cargarEntidad(num + 1, jQuery(this).val());
            });

            jQuery("#filtro-" + num + " .listaCampos a.btnDesplegarCampos").off("click");
            jQuery("#filtro-" + num + " .listaCampos a.btnDesplegarCampos").click(function(e) {
                pde(e);

                var listaVisible = jQuery(".listCampoEntidad:visible");
                var listaSeleccionada = jQuery("#camposList-" + num);

                if (listaVisible.length > 0 && listaVisible.attr("id") != listaSeleccionada.attr("id")) {
                    jQuery("a.btnDesplegarCampos").each(function() {
                        jQuery(this).addClass("arrow-down");
                        jQuery(this).removeClass("arrow-up");
                    });

                    jQuery(this).addClass("arrow-up");
                    jQuery(this).removeClass("arrow-down");

                    listaVisible.slideUp('fast', function(e) {
                        listaSeleccionada.slideDown();
                    });
                }
                else {
                    if (listaSeleccionada.is(':visible') && !listaSeleccionada.is(':hidden')) {
                        jQuery(this).addClass("arrow-down");
                        jQuery(this).removeClass("arrow-up");

                        listaSeleccionada.slideUp();
                    }
                    else {
                        jQuery(this).addClass("arrow-up");
                        jQuery(this).removeClass("arrow-down");

                        listaSeleccionada.slideDown();
                    }
                }

                e.stopPropagation();
            });

            jQuery("#filtro-" + num + " #loadingGif").remove();
            jQuery("#listaFiltros select").removeAttr("disabled");*/
        }
    });
}
