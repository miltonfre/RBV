<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecursosValiosos.aspx.cs"
    Inherits="RBV.Matriz.RecursosValiosos" MasterPageFile="~/Master.Master" %>

<%@ Register src="../Maestros/SeleccionEmpresa.ascx" tagname="SeleccionEmpresa" tagprefix="uc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
    <div id="head-image" onclick="redirect()">
    </div>
    <div id="matrix-content">
        <div id="matrix-text">
            <span>Matriz de recursos valiosos</span>
        </div>
        <uc1:SeleccionEmpresa ID="SeleccionEmpresa1" runat="server" OnEmpresaIndexChange="SeleccionEmpresa1_OnEmpresaIndexChange" />
        <div id="matrix-container">

            <script src="../js/jquery-1.10.2.js" type="text/javascript"></script>

            <script type="text/javascript">

                $(document).ready(function() {

                    $("#enviar").click(function() {

                        send();
                    });

                    $(".textbox").change(function() {

                        var info = "";
                        var totales = "";
                        var idFila = $(this).parents("tr").attr("id");
                        var objTr = $(this).parents("tr");
                        $(this).parents("tr").each(function(index) {

                            $(this).children("td").each(function(index2) {

                                if ($(this).children(".textbox").attr("id") != null) {

                                    info += $(this).children(".textbox").attr("id") + "," + $(this).children(".textbox").val() + ";";
                                }

                            });

                        });
                        $(".ValResult").each(function(index) {
                            if ($(this).text().trim() != "Resultado") {
                                totales += $(this).text().trim() + ";";
                            }
                        });

                        $.ajax({
                            type: "POST",
                            url: "RecursosValiosos.aspx/Actualizar",
                            data: "{info:'" + info + "',totales:'" + totales + "',idFila:'" + idFila + "'}",
                            contentType: "application/json; charset=utf-8",
                            dataType: "json",
                            success: function(msg) {

                                $("#r_" + idFila).text(msg.d.TotalLinea);
                                $("#total").text(msg.d.TotalGrupo);
                                if (msg.d.TotalLinea >= msg.d.TotalGrupo) {
                                //TODO: Pasar a una clase
                                    objTr.css("color", "Lime");
                                    objTr.css("border-top-color", "Lime");
                                    objTr.css("border-bottom-style", "double");
                                    objTr.css("border-top-style", "double");
                                    objTr.css("font-weight", "bold");

                                }
                                else {
                                    objTr.css("color", "#A7A6AA");
                                    objTr.css("border-top-color", "#A7A6AA");
                                    objTr.css("font-weight", "normal");
                                    objTr.css("border-bottom-style", "solid");
                                    objTr.css("border-top-style", "solid");
                                }

                            }
                        });
                    });


                });
                function redirect() {
                    window.location.href = '../MemberPages/Default.aspx'
                    //history.back(-1);                
                }
                function send() {

                    var info = "";

                    $(".textbox").each(function(index) {

                        info += $(this).attr("id") + "," + $(this).val() + ";"
                    });

                    //console.log("info: " + info);

                    $.ajax({
                        type: "POST",
                        url: "RecursosValiosos.aspx/Save",
                        data: "{info:'" + info + "'}",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function(msg) {

                            alert(msg.d);
                            window.location.href = '../Matriz/RecursosValiosos.aspx'
                        }
                    });

                }
        
            </script>

            <table class="MatrizStyle" rules="rows" style="width: 1300px;border-top-width:1px">
            
            <tr style="border-top-width:1px; border-top-color:Gray">
            <td class="" visible="false" style="visibility: hidden"> </td>
            <td class=""> </td>
            <%
                foreach (var clasificacion in Clasificaciones)
                {
                    %>
                    <td class="group" colspan='<%=clasificacion.CantidadCaracteristica %>'>
                        <%= clasificacion.Nombre%>
                    </td><%
                }
                 %>
            </tr>
            
                <% 
            
                    bool showColumn = true;
                    int IndiceFila = 0;
                    foreach (var fila in TitulosFilas)
                    {
                %>
                <%
                    if (recursosValiosos[IndiceFila].Valor >= ValorTotal)
                    {
                %>
                <tr id='<%= IndiceFila %>'  style="color: Lime; border-bottom-style: double; border-top-color: Lime; border-top-style: double;
                    font-weight: bold">
                    <%
                        }
                    else
                    { 
                    %>
                    <tr id='<%= IndiceFila %>' >
                        <%
                            }
                        %>
                        <td class="" style="visibility: hidden" visible="false">
                            <%= fila.IdFilas%>
                        </td>
                        <td class="">
                            <%= fila.NombreFilas %>
                        </td>
                        <%
                            foreach (var columna in Titulos)
                            {
                                if (showColumn)
                                {
                        %>
                        <td class="title" style="text-align: center; visibility: hidden" visible="false"
                            align="center">
                            <%= columna.Id%>
                        </td>
                        <td class="colname">
                            <%= columna.Nombre%>
                        </td>
                        <%
                            }
                                else
                                {
                        %>
                        <td class="columns" colspan="2">
                            <select id='<%= string.Format("{0},{1},{2}", fila.IdFilas, columna.Id, columna.IdClasificacion) %>'
                                class="textbox">
                                <% 
                            
                                    foreach (var item in Calificacion)
                                    {
                                        string valor = "1";
                                        foreach (var valorMat in MatrizValoracion)
                                        {
                                            if (valorMat.IdCaracteristica.ToString() == columna.Id && valorMat.IdRecurso.ToString() == fila.IdFilas)
                                            {
                                                valor = valorMat.Valor.ToString();
                                            }
                                        }

                                        if (item.Valor.ToString().Equals(valor))
                                        {
                                %>
                                <option id='Option1' value='<%= item.Valor %>' selected="selected" class='option'>
                                    <%=item.Valor %>
                                </option>
                                <%   
                                    }
                                        else
                                        {
                                %>
                                <option id='<%= item.Valor %>' value='<%= item.Valor %>' class='option'>
                                    <%=item.Valor %>
                                </option>
                                <% 
                                    }


                                    }
                            
                                %>
                            </select>
                        </td>
                        <%
                            }
                            }
                        %>
                        <td>
                            &nbsp;&nbsp;
                        </td>
                        <td class="ValResult" style="width: 150px; text-align: inherit">
                            <%  if (!showColumn)
                                {   
                            %>
                            <span id='r_<%=  IndiceFila %>'>
                                <%= recursosValiosos[IndiceFila].Valor%>
                            </span>
                            <%
                                IndiceFila++;
                                }
                                else
                                { 
                            %>
                            <%= "Resultado" %>
                            <%
                                }
                            %>
                        </td>
                        <%
                            showColumn = false;
            
                        %></tr>
                    <%
                        } 
                    %>
            </table>
            <div style="text-align: right; color: Gray; font-weight: bold; font-size: larger">
                Resultado: <span id="total">
                    <%=ValorTotal.ToString().Substring(0,5) %>
                </span>
            </div>
            <div>
                <input id="enviar" type="button" value="Enviar" class="butt" />
            </div>
        </div>
        
    </div>
</asp:Content>
