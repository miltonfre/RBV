<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecursosValiosos.aspx.cs"
    Inherits="RBV.Matriz.RecursosValiosos" MasterPageFile="~/Master.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">
    <div style="margin-top:10px; margin-left: 30px">

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

                        alert(msg.d);
                    }
                });

            }
        
        </script>

        <table class="MatrizStyle" rules="rows" style="width:1350px" >
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
                    <tr style="color:Lime;border-bottom-style:double;border-top-color:Lime;border-top-style:double;font-weight:bold" >
                    <%
                }
                else
                { 
                %>
                    <tr>
                <%
                }
                 %>
                <td class=""  style="visibility:hidden" visible="false">
                    <%= fila.IdFilas%>
                </td>
                <td class=""  style="width:80%;color:White">
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
                            <select id='<%= string.Format("{0},{1},{2}", fila.IdFilas, columna.Id, columna.IdClasificacion) %>' class="textbox" >
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
                    %>
                    
                        <td style="color:White;width:150px;text-align:center">
                        <%  if (!showColumn)
                            {   
                        %>
                                <%= recursosValiosos[IndiceFila].Valor%>                       
                                
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
        <div style="text-align:right;color:White;font-weight:bold">
        <%=ValorTotal.ToString().Substring(0,5) %>
        </div>
        <div>
            <input id="enviar" type="button" value="Enviar" />
        </div>
        
    </div>
</asp:Content>
