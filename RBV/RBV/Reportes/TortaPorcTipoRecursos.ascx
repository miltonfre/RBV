<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TortaPorctipoRecurso.ascx.cs" Inherits="RBV.Reportes.TortaPorctipoRecurso" %>
<%@ Register Src="../Shared/Titulo.ascx" TagName="Titulo" TagPrefix="uc2" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true" />
 <asp:UpdatePanel ID="UpdatePanel6" runat="server" RenderMode="Inline" UpdateMode="always">
        <ContentTemplate>
        <uc2:Titulo ID="Titulo1" runat="server" Titulo="<%$ Resources:Titulo1Titulo %>">
    </uc2:Titulo>
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
     </ContentTemplate>
    </asp:UpdatePanel>