/*Creado por Daniel López - danypype@gmail.com*/

jQuery.noConflict();

/*Ejecuta una serie de acciones imediatamente 
cuando el documento se ha descargado completamente*/
jQuery(document).ready(function(e) {
    cargarEntidad(1, "");

    jQuery(".btnGenerarReporte").eq(0).click(function(e) {
        pde(e);
        if (validarFormulario()) {
            enviarFiltros();
        }
    });

    jQuery("body").click(function(e) {
        jQuery("a.btnDesplegarCampos").addClass("arrow-down");
        jQuery("a.btnDesplegarCampos").removeClass("arrow-up");
        jQuery(".listCampoEntidad:visible").slideUp();
    });
});

//Previene el evento por defecto de cualquier control o elemento, recibe el evento.
function pde(e) 
{
    e.preventDefault ? e.preventDefault() : e.returnValue = false;
}

/*Obtiene la lista de entidades relacionadas con la entidad enviada como parámetro
y las inserta dentro de un control <select> HTML*/
function cargarEntidad(num, entidad) {
    //Representación string del objeto JSON que recibe el método definido en C#
    
    //Entidades seleccionadas en las opciones anteriores
    var entidadesPadre = '';
    for (i = 1; i <= num - 1; i++) {
        entidadesPadre += "'"+jQuery("#entidadList-" + i).val() + "',";
    }
    entidadesPadre = entidadesPadre.substring(0, entidadesPadre.length - 1);
    
    var dataToSend = "{nombreEntidad:'" + entidad + "', entidadesPadre:[" + entidadesPadre + "]}";

    if (entidad != "seleccione") {
        /*Funcion ajax que se encarga de obtener la lista de entidades relacionadas
        y posteriormente de insertarlas en el control HTML*/
        jQuery.ajax({
            type: "POST", //Indica que se realizará un POST al método definido en C#
            url: "FiltrosReporteGeneral.aspx/ListarEntidades", /*Ruta del método definido en C# que retorna la lista de entidades
                                                                 (la ruta es relativa al formulario que ancla este js) */
            data: dataToSend, //Representación string del objeto JSON que recibe el método definido en C# (parámetro(s) del método)
            contentType: "application/json; charset=utf-8", //Indica que se enviará contenido tipo JSON
            dataType: "json", //Indica que se recibirá contenido JSON
            //Función que se ejecuta desde el momento en que se envian los datos hasta que llegan
            beforeSend: function(e) {
                if (jQuery("#filtro-" + num).length == 1) {
                    var loadingGif = "<img src='../img/loading-tiny.gif' style='position:absolute;top:20px;left:205px;' id='loadingGif'/>";
                    jQuery("#filtro-" + num).append(loadingGif);
                }
                jQuery("#listaFiltros select").attr("disabled", "disabled");
            },
            //Función que se ejecutará en caso de error
            error: function(e) {
                alert("Ocurrió un problema en el servidor");
                return;
            },
            //Función que se ejecuta en caso de recepción existosa
            success: function(entidades) {
                if (jQuery("#filtro-" + num).length == 0) {
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
                }

                for (i = 0; i < entidades.length; i++) {
                    var nombre = entidades[i].substring(0, entidades[i].indexOf(","));
                    // ignora el elemento cuando es una entidad que ya está repetida en la lista
                    if (jQuery.inArray(nombre, entidadesSeleccionadas) == -1) {
                        var nombreMostrar = entidades[i].substring(entidades[i].indexOf(",") + 1, entidades[i].length);
                        jQuery("#entidadList-" + num).append('<option value="' + nombre + '">' + nombreMostrar + '</option>');
                    }
                }

                jQuery("#camposList-" + num).html("");

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
                jQuery("#listaFiltros select").removeAttr("disabled");
            }
        });
    }
    else 
    {
        if (jQuery("#filtro-" + num).length > 0) 
        {
            var x = num;
            while (jQuery("#filtro-" + x).length > 0) 
            {
                jQuery("#filtro-" + x).remove();
                x++;
            }
        }
    }
}

function cargarClasificaciones(dataToSend, camposList, num) {
    jQuery.ajax({
        type: "POST",
        url: "FiltrosReporteGeneral.aspx/ListarClasificacionesEntidad",
        data: dataToSend,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        error: function(e) {
            alert("Ocurrió un problema en el servidor");
        },
        success: function(listaClasificaciones) {
            var clasiItems = "";

            for (i = 0; i < listaClasificaciones.length; i++) {
                var nombre = listaClasificaciones[i].substring(0, listaClasificaciones[i].indexOf(","));
                var nombreMostrar = listaClasificaciones[i].substring(listaClasificaciones[i].indexOf(",") + 1, listaClasificaciones[i].length);
                clasiItems += '<li>' +
                                '<input type="checkbox" value="' + nombre + '" class="clasificacion"/>' +
                                '<p>' + nombreMostrar + '</p>' +
                              '</li>';

            }

            camposList.append(clasiItems);

            setUpCheck(num, "clasificacion");
        }
    });
}

/*Obtiene la lista de campos y clasificaciones de la entidad seleccionada por el usuario,
posteriormente los carga dentro de una lista de checkbox*/
function cargarCamposClasificaciones(num, entidad) 
{
    var dataToSend = "{nombreEntidad:'" + entidad + "'}";
    var camposList = jQuery("#camposList-" + num);
    camposList.html("");
    jQuery("#filtro-" + num + " .listaCampos > p").text("Campos seleccionados: 0");

    jQuery.ajax({
        type: "POST",
        url: "FiltrosReporteGeneral.aspx/ListarCamposEntidad",
        data: dataToSend,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        error: function(e)
        {
            alert("Ocurrió un problema en el servidor");
        },
        success: function(listaCampos)
        {
            var campoItems = "";

            for (i = 0; i < listaCampos.length; i++)
            {
                var nombre = listaCampos[i].substring(0, listaCampos[i].indexOf(","));
                var nombreMostrar = listaCampos[i].substring(listaCampos[i].indexOf(",") + 1, listaCampos[i].length);
                campoItems += '<li>' +
                                '<input type="checkbox" value="' + nombre + '" class="campo"/>' +
                                '<p>' + nombreMostrar + '</p>' +
                              '</li>';
            }

            camposList.append(campoItems);

            setUpCheck(num, "campo");

            if (entidad == "Controles")
            {
                jQuery.ajax({
                    type: "POST",
                    url: "FiltrosReporteGeneral.aspx/ListarClasificacionesEntidad",
                    data: dataToSend,
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    error: function(e)
                    {
                        alert("Ocurrió un problema en el servidor");
                    },
                    success: function(listaClasificaciones)
                    {
                        var clasiItems = "";

                        for (i = 0; i < listaClasificaciones.length; i++)
                        {
                            var nombre = listaClasificaciones[i].substring(0, listaClasificaciones[i].indexOf(","));
                            var nombreMostrar = listaClasificaciones[i].substring(listaClasificaciones[i].indexOf(",") + 1, listaClasificaciones[i].length);
                            clasiItems += '<li>' +
                                '<input type="checkbox" value="' + nombre + '" class="clasificacion"/>' +
                                '<p>' + nombreMostrar + '</p>' +
                              '</li>';

                        }

                        camposList.append(clasiItems);

                        setUpCheck(num, "clasificacion");

                        jQuery.ajax({
                            type: "POST",
                            url: "FiltrosReporteGeneral.aspx/ListarObjetivosControl",
                            data: dataToSend,
                            contentType: "application/json; charset=utf-8",
                            dataType: "json",
                            error: function(e)
                            {
                                alert("Ocurrió un problema en el servidor");
                            },
                            success: function(listaObjetivos)
                            {
                                var ocItems = "";

                                for (i = 0; i < listaObjetivos.length; i++)
                                {
                                    var objetivo = listaObjetivos[i].split("|");
                                    ocItems += '<li>' +
                                    '<input type="checkbox" value="' + objetivo[0] + '" class="oc" texto="' + listaObjetivos[i] + '" />' +
                                    '<p>' + objetivo[1] + '</p>' +
                                    '</li>';
                                }

                                camposList.append(ocItems);

                                setUpCheck(num, "oc");
                            }
                        });
                    }
                });
            }
            else if (entidad == "RiesgosLaft")
            {
                jQuery.ajax({
                    type: "POST",
                    url: "FiltrosReporteGeneral.aspx/ListarClasificacionesEntidad",
                    data: dataToSend,
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    error: function(e)
                    {
                        alert("Ocurrió un problema en el servidor");
                    },
                    success: function(listaClasificaciones)
                    {
                        var clasiItems = "";

                        for (i = 0; i < listaClasificaciones.length; i++)
                        {
                            var nombre = listaClasificaciones[i].substring(0, listaClasificaciones[i].indexOf(","));
                            var nombreMostrar = listaClasificaciones[i].substring(listaClasificaciones[i].indexOf(",") + 1, listaClasificaciones[i].length);
                            clasiItems += '<li>' +
                                    '<input type="checkbox" value="' + nombre + '" class="clasificacion"/>' +
                                    '<p>' + nombreMostrar + '</p>' +
                                  '</li>';

                        }

                        camposList.append(clasiItems);

                        setUpCheck(num, "clasificacion");

                        jQuery.ajax({
                            type: "POST",
                            url: "FiltrosReporteGeneral.aspx/ListarRiesgosAsociados",
                            data: dataToSend,
                            contentType: "application/json; charset=utf-8",
                            dataType: "json",
                            error: function(e)
                            {
                                alert("Ocurrió un problema en el servidor");
                            },
                            success: function(listaRiesgosAsociados)
                            {
                                var ocItems = "";

                                for (i = 0; i < listaRiesgosAsociados.length; i++)
                                {
                                    ocItems += '<li>' +
                                    '<input type="checkbox" value="' + listaRiesgosAsociados[i] + '" class="ra"/>' +
                                    '<p>' + listaRiesgosAsociados[i] + '</p>' +
                                  '</li>';
                                }

                                camposList.append(ocItems);

                                setUpCheck(num, "ra");
                            }
                        });
                    }
                });
            }
            else
            {
                cargarClasificaciones(dataToSend, camposList, num);
            }
        }
    });
}

function setUpCheck(num, clase) 
{
    jQuery("#camposList-" + num + " input[type=checkbox]." + clase).click(function(e) {
        e.stopPropagation();
        jQuery("#filtro-" + num + " .listaCampos > p").text("Campos seleccionados: " +
            jQuery("#camposList-" + num + " input[type=checkbox]:checked").length);
    });
    
    jQuery("#camposList-" + num + " > li").click(function(e) {
        var chk = jQuery(this).children("input[type=checkbox]." + clase);
        chk.attr("checked", !chk.attr("checked"));
        jQuery("#filtro-" + num + " .listaCampos > p").text("Campos seleccionados: " +
            jQuery("#camposList-" + num + " input[type=checkbox]:checked").length);
        e.stopPropagation();
    });
}

/*Returna true en caso que el formulario sea válido, en caso contrario,
muestra un mensaje indicando el error y retorna false*/
function validarFormulario() {
    var entidades = 0;
    var campos = true;

    jQuery("#listaFiltros select").each(function(e) {
        if (jQuery(this).val() != "seleccione") {
            entidades++;
        }
    });

    jQuery(".listCampoEntidad").each(function(e) {
        if (jQuery("#" + jQuery(this).attr("id") + " li").length > 0) {
            if (jQuery("#" + jQuery(this).attr("id") + " input[type=checkbox].campo:checked").length == 0) {
               campos = false;
            }
        }
    });

    if (entidades >= 1 && campos) {
        return true;
    }
    else if (entidades < 1) {
        alert("Debe seleccionar por lo menos una entidad");
        return false;
    }
    else if (!campos) {
        alert("Por cada entidad debe seleccionar por lo menos un campo");
        return false;
    }

    return true;
}

/*Función encargada de enviar los filtros seleccionados por el usuario
al método definido en C# que genera el reporte.
Solo debe invocarse cuando el formulario es válido*/
function enviarFiltros() {
    var entidades = new Array();
    var campos = new Array();
    var clasificaciones = new Array();
    var objetivosControl = new Array();
    var riesgosAsociados = new Array();

    var i = 0;
    jQuery("#listaFiltros select").each(function(e) {
        if (jQuery(this).val() != "seleccione") {
            entidades[i] = jQuery(this).val();
            i++;
        }
    });
    
    var j = 0;
    jQuery(".listCampoEntidad").each(function(e) {
        if (jQuery("#" + jQuery(this).attr("id") + " li").length > 0) {
            var k = 0;
            var camposSub = new Array();
            jQuery("#" + jQuery(this).attr("id") + " input[type=checkbox].campo:checked").each(function(e) {
                camposSub[k] = jQuery(this).val();
                k++;
            });
            campos[j] = camposSub;

            var l = 0;
            var clasificacionesSub = new Array();
            jQuery("#" + jQuery(this).attr("id") + " input[type=checkbox].clasificacion:checked").each(function(e) {
                clasificacionesSub[l] = jQuery(this).val();
                l++;
            });
            clasificaciones[j] = clasificacionesSub;
            j++;
        }
    });

    var oc = 0;
    jQuery("input[type=checkbox].oc:checked").each(function(e)
    {
        objetivosControl[oc] = this.texto;
        oc++;
    });

    var ra = 0;
    jQuery("input[type=checkbox].ra:checked").each(function(e) {
        riesgosAsociados[ra] = jQuery(this).val();
        ra++;
    });

    var camposStr = "";
    for (x = 0; x < campos.length; x++) {
        camposStr+="["
        for (y = 0; y < campos[x].length; y++) {
            if(y == campos[x].length -1)
                camposStr += "'" + campos[x][y] + "'";
            else
                camposStr += "'" + campos[x][y] + "',";
        }
        if (x == campos.length - 1)
            camposStr += "]";
        else
            camposStr += "],";
    }

    var clasificacionesStr = "";
    for (x = 0; x < clasificaciones.length; x++) {
        clasificacionesStr += "["
        for (y = 0; y < clasificaciones[x].length; y++) {
            if (y == clasificaciones[x].length - 1)
                clasificacionesStr += "'" + clasificaciones[x][y] + "'";
            else
                clasificacionesStr += "'" + clasificaciones[x][y] + "',";
        }
        if (x == clasificaciones.length - 1)
            clasificacionesStr += "]";
        else
            clasificacionesStr += "],";
    }

    var objetivosControlSend = objetivosControl.length > 0 ? "'" + objetivosControl.join("','") + "'" : "";
    var riesgosAsociadosSend = riesgosAsociados.length > 0 ? "'" + riesgosAsociados.join("','") + "'" : "";
    var dataToSend = "{entidades:['" + entidades.join("','") + "']," +
                     "camposSeleccionados:[" + camposStr + "]," +
                     "clasificacionesSeleccionadas:[" + clasificacionesStr + "]," +
                     "objetivosControl:[" + objetivosControlSend + "]," +
                     "riesgosAsociados:[" + riesgosAsociadosSend + "]}";

    jQuery.ajax({
        type: "POST",
        url: "FiltrosReporteGeneral.aspx/GenerarReporte_Click",
        data: dataToSend,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        error: function(e) {
            alert("No se pudo generar el reporte");
        },
        success: function(e) {
            window.open("ReporteGeneral.aspx");
        }
    });
}