<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecursosValiosos.aspx.cs"
    Inherits="RBV.Matriz.RecursosValiosos" MasterPageFile="~/Master.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
    <div style="margin-top:10px; margin-left: 50px">

        <script src="../js/jquery-1.10.2.js" type="text/javascript"></script>

        <script type="text/javascript">

            $(document).ready(function() {

                $("#enviar").click(function() {

                    send();
                });
            });

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

                        //alert(msg.d);
                    }
                });

            }
        
        </script>

        <table class="MatrizStyle" rules="rows" style="width:1400px" >
            <% 
            
                bool showColumn = true;

                foreach (var fila in TitulosFilas)
                {
            %>
            <tr  >
                <td class=""  style="visibility:hidden" visible="false">
                    <%= fila.IdFilas%>
                </td>
                <td class=""  style="width:100%;color:White">
                    <%= fila.NombreFilas %>
                </td>
                <%
                    foreach (var columna in Titulos)
                    {
                        if (showColumn)
                        {
                            %>
                            <td class="" style="text-align :center;visibility:hidden" visible="false">
                                <%= columna.Id%>
                            </td>
                            <td class="" style="width:100%;text-align :center;color:White">
                                <%= columna.Nombre%>
                            </td>
                            <%
                        }
                        else
                        {
                            %>
                            <td colspan="2" style="text-align:center">
                            <select id='<%= string.Format("{0},{1}", fila.IdFilas, columna.Id) %>' class="textbox" >
                                   <% 
                            
                                    foreach(var item in Calificacion)
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
                                             <option id='Option1' value='<%= item.Valor %>' selected="selected">
                                            <%=item.Valor %>
                                            </option>
                                         <%   
                                        }
                                        else
                                        {
                                        %>                                     
                                            <option id='<%= item.Valor %>' value='<%= item.Valor %>' >
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

                showColumn = false;
            
           %></tr>
            <%
                } 
            %>
        </table>
        <div>
            <input id="enviar" type="button" value="Enviar" />
        </div>
    </div>
</asp:Content>
