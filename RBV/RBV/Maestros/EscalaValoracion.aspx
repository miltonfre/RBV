<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EscalaValoracion.aspx.cs"
    Inherits="RBV.Maestros.EscalaValoracion" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script src="../js/jquery-1.10.2.js" type="text/javascript"></script>

        <script type="text/javascript">

            $(document).ready(function() {

            $("#enviar").click(function() {

                    send();
                });


            });

            function send() {

               var valor = 0;

               $(".textbox").each(function(index) {

                   if ($(this).val() == "") {
                       valor = valor + 0;
                   }
                   else {
                       valor = valor + eval($(this).val());
                   }
               });
               if (valor > 100) {
                   alert("La sumatoria de los valores no puede superar el 100%, valor: " + valor);
               }
               else if (valor < 100) {
                   alert("La sumatoria de los valores esta por debajo del 100%, valor: " + valor);
               }            
            }
        
        </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <asp:Repeater ID="rptValoracion" runat="server">
            <itemtemplate>
                <tr>
                    <td>
                        
                            <asp:Label ID="lblCaracteristica" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"NombreCaracteristica") %>'></asp:Label>
                        
                    </td>
                    <td>
                        <asp:TextBox ID="txtValor" runat="server" class="textbox" ></asp:TextBox>
                    </td>
                </tr>
                </itemtemplate>
            </asp:Repeater>
            <tr>
            <td>
            <asp:Button ID="enviar" runat="server" Text="enviar" onclick="enviar_Click"   />
            </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
