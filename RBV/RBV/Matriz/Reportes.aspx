<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="RBV.Matriz.Reportes" MasterPageFile="~/Shared/Master.Master" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<%@ Register Src="../Shared/Titulo.ascx" TagName="Titulo" TagPrefix="uc2" %>

<%@ Register src="../Maestros/SeleccionEmpresa.ascx" tagname="SeleccionEmpresa" tagprefix="uc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">

    <uc1:SeleccionEmpresa ID="SeleccionEmpresa1" runat="server" OnEmpresaIndexChange="SeleccionEmpresa1_IndexChange" />
    <div>
    &nbsp;
    </div>
    <asp:Chart ID="BarrasRecursos" runat="server" Width="650" Height="400" >
        <Series >
            <asp:Series Name="Recursos" ChartType="Column" ShadowColor="Gray" IsVisibleInLegend="true" >
            </asp:Series>
            <asp:Series Name="Promedio" ChartType="Line" Color="Red" ></asp:Series>
        </Series>
        <Legends>
        <asp:Legend LegendStyle="Table" Docking="Bottom" ></asp:Legend>
        </Legends>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1" >
            
            <AxisX LabelAutoFitStyle="LabelsAngleStep90"   IsLabelAutoFit="false" Interval="1"></AxisX>
            <AxisY Interval="0.2"></AxisY>
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
     <div>
     Tipo de Recursos
    </div>
    <asp:Chart ID="TortaRecursos" runat="server" Width="650" Height="400" BackGradientStyle="TopBottom" >
        <Series >
            <asp:Series Name="tipoRecurso" MarkerImageTransparentColor="Aqua" Label="#PERCENT{P1}" IsValueShownAsLabel="true" ChartType="Pie"  IsVisibleInLegend="true"  LabelForeColor="White"  XValueType="Auto" ShadowColor="Gray"  >
            
            </asp:Series>            
        </Series>
        
        <Legends>
        <asp:Legend BackColor="Transparent" Alignment="Center" Docking="Bottom" Font="Trebuchet MS, 8.25pt, style=Bold" IsTextAutoFit="False" Name="Default" LegendStyle="Row" ></asp:Legend>
        <asp:Legend ></asp:Legend>
        </Legends>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1"   BorderColor="64, 64, 64, 64" BackSecondaryColor="Transparent" BackColor="Transparent" ShadowColor="Transparent" BorderWidth="0" Area3DStyle-Enable3D="true" >            
            <AxisX LabelAutoFitStyle="LabelsAngleStep90"  IsLabelAutoFit="true" Interval="1"  ></AxisX>
            <AxisY Interval="0.2" ></AxisY>
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
    <div>
     Tipo de Recursos Valiosos Sobre Total
    </div>
    <asp:Chart ID="TipoRecValioso" runat="server" Width="650" Height="400" BackGradientStyle="TopBottom" >
        <Series >
            <asp:Series Name="tipoRecursoVal" MarkerImageTransparentColor="Aqua" Label="#PERCENT{P1}" IsValueShownAsLabel="true" ChartType="Pie"  IsVisibleInLegend="true"  LabelForeColor="White"  XValueType="Auto" ShadowColor="Gray"  >
            
            </asp:Series>            
        </Series>
        
        <Legends>
        <asp:Legend BackColor="Transparent" Alignment="Center" Docking="Bottom" Font="Trebuchet MS, 8.25pt, style=Bold" IsTextAutoFit="False" Name="Default" LegendStyle="Row" ></asp:Legend>
        <asp:Legend ></asp:Legend>
        </Legends>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1"   BorderColor="64, 64, 64, 64" BackSecondaryColor="Transparent" BackColor="Transparent" ShadowColor="Transparent" BorderWidth="0" Area3DStyle-Enable3D="true" >            
            <AxisX LabelAutoFitStyle="LabelsAngleStep90"  IsLabelAutoFit="true" Interval="1"  ></AxisX>
            <AxisY Interval="0.2" ></AxisY>
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
     <div>
     
     <asp:Chart ID="chrBarrasClasi" runat="server" Width="650" Height="400" >
        <Series >
            <asp:Series Name="Recursos"  ChartType="Bar"  ShadowColor="Gray" IsVisibleInLegend="true" >
            </asp:Series>     
            
        </Series>
        <Legends>
        <asp:Legend LegendStyle="Table" Docking="Bottom" ></asp:Legend>
        </Legends>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1" >
            <AxisX LabelAutoFitStyle="LabelsAngleStep90" IsLabelAutoFit="true" Interval="1"></AxisX>
            <AxisY Interval="0.2"></AxisY>
            
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
     
     </div>
</asp:Content>