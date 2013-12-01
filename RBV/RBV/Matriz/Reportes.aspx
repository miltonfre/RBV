<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="RBV.Matriz.Reportes" MasterPageFile="~/Shared/Master.Master" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<%@ Register Src="../Shared/Titulo.ascx" TagName="Titulo" TagPrefix="uc2" %>

<%@ Register src="../Maestros/SeleccionEmpresa.ascx" tagname="SeleccionEmpresa" tagprefix="uc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContenidoPaginas" runat="server">

    <uc1:SeleccionEmpresa ID="SeleccionEmpresa1" runat="server" />
    <div>
    &nbsp;
    </div>
    <asp:Chart ID="Chart1" runat="server" Width="650" Height="400" >
        <Series>
            <asp:Series Name="Series1" ChartType="Column" ShadowColor="Gray"  >
            </asp:Series>
            <asp:Series Name="Promedio" ChartType="Line" Color="Red"></asp:Series>
        </Series>
        
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1" >
            <AxisX LabelAutoFitStyle="LabelsAngleStep90" IsLabelAutoFit="true" Interval="1"></AxisX>
            <AxisY Interval="0.2"></AxisY>
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
</asp:Content>