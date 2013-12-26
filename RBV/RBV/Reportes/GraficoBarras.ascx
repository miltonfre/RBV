﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GraficoBarras.ascx.cs" Inherits="RBV.Reportes.GraficoBarras" %>
<%@ Register Src="../Shared/Titulo.ascx" TagName="Titulo" TagPrefix="uc2" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true" />
 <asp:UpdatePanel ID="UpdatePanel6" runat="server" RenderMode="Inline" UpdateMode="always">
        <ContentTemplate>
        <uc2:Titulo ID="Titulo1" runat="server" Titulo="<%$ Resources:Titulo1Titulo %>">
    </uc2:Titulo>
    
    
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
            
            <AxisX LabelAutoFitStyle="LabelsAngleStep90" IsLabelAutoFit="true" Interval="1"></AxisX>
            <AxisY Interval="0.2"></AxisY>
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
    
     </ContentTemplate>
    </asp:UpdatePanel>