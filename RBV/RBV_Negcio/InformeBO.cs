using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Novacode;
using Entidades = RBV_Clases;
using System.IO;
using System.Xml;
using System.Xml.Xsl;
using RBV_Negocio;
using System.Drawing;
using System.Threading;
using System.Drawing.Imaging;
using System.Data;
using RBV_Clases;
using System.Web.UI.DataVisualization.Charting;


namespace RBV_Negcio
{
    public class InformeBO
    {

        public string CrearWordWithDocX(Informe informe)
        {
            //se crea una nueva carpeta
            Empresa empresa = informe.Empresa;
           string strDirectorio= string.Concat(Environment.CurrentDirectory, "\\InformesGenerados\\", empresa.NombreEmpresa);
           if (!Directory.Exists(strDirectorio))
           {
               System.IO.Directory.CreateDirectory(strDirectorio);
           }

           
            DateTime fecha = DateTime.Now;
            string strFile = "Informe" + empresa.NombreEmpresa + fecha.ToString("yyyy_MM_dd_hh_mm_ss") + ".docx";
            // string fileName = string.Concat(Environment.CurrentDirectory, "\\InformesGenerados\\", strFile);
           string fileName = string.Concat(strDirectorio,"\\", strFile);
            // Create the document in memory:
            var doc = DocX.Create(fileName);
            doc.MarginTop = 5;
            doc.MarginRight = 3;
            doc.MarginLeft = 3;
            doc.MarginBottom = 3;
            
            implementarHeader(doc);
            implementarFooter(doc);
            implementarPortada(doc, empresa);
            doc.InsertSectionPageBreak(true);
            ingresarEquipoTrabajo(doc, informe.RolesInforme);
            doc.InsertSectionPageBreak(true);
            insertarGraficoBarra(doc, empresa, strDirectorio);
          
            doc.Save();
            return fileName;
        }

        private void ingresarEquipoTrabajo(DocX doc, List<RolesInforme> rolesInforme)
        {
            // Titulo Equipo de Trabajo:
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            var equipoTrabajoFormat = new Novacode.Formatting();
            equipoTrabajoFormat.FontFamily = new System.Drawing.FontFamily("Arial");
            equipoTrabajoFormat.Size = 12D;
            equipoTrabajoFormat.Bold = true;
            Paragraph pTit = doc.InsertParagraph("Equipo de Trabajo", false, equipoTrabajoFormat);
            pTit.Alignment = Alignment.center;

            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();

           Table tab = doc.AddTable(rolesInforme.Count+1, 2);
            tab.AutoFit = AutoFit.Window;
            tab.Alignment = Alignment.center;
            tab.Design = TableDesign.ColorfulGridAccent1;
            tab.Rows[0].Cells[0].Paragraphs.First().Append("Nombre");
            tab.Rows[0].Cells[0].Paragraphs.First().Alignment = Alignment.center;
            tab.Rows[0].Cells[0].Paragraphs.First().Bold();
            tab.Rows[0].Cells[1].Paragraphs.First().Append("Cargo/Rol");
            tab.Rows[0].Cells[1].Paragraphs.First().Alignment = Alignment.center;
            tab.Rows[0].Cells[1].Paragraphs.First().Bold();
            for (int i = 0; i < rolesInforme.Count; i++)
            {
                RolesInforme rolInforme=rolesInforme[i];
                tab.Rows[i+1].Cells[0].Paragraphs.First().Append(rolInforme.NombreParticipante);
                tab.Rows[i+1].Cells[1].Paragraphs.First().Append(rolInforme.Rol);
            }
            doc.InsertTable(tab);
        }
        private void insertarGraficoBarra(DocX doc, Empresa empresa, string strDirectorio)
        {
            string strGrafico = CrearGraficoBarra(empresa, strDirectorio);            
            Novacode.Image i = doc.AddImage(strGrafico);
            Picture p = i.CreatePicture();
            Paragraph pImg = doc.InsertParagraph("").AppendPicture(p);
            pImg.Alignment = Alignment.center;
        }
        private void implementarHeader(DocX doc)
        {
            string headerDes = "Identificación de los recursos valiosos";
            string headerFecha = DateTime.Now.ToShortDateString();
            // Aplicamos la descripción al Header
            doc.AddHeaders();
            Header header_default = doc.Headers.odd;
            Paragraph p1 = header_default.InsertParagraph();
            p1.Append(headerDes);
            p1.Alignment = Alignment.right;

            // Aplicamos la fecha al Header
            Paragraph p2 = header_default.InsertParagraph();
            p2.Append(headerFecha);
            p2.Alignment = Alignment.right;
        }

        private void implementarFooter(DocX doc)
        {
            doc.AddFooters();
            // Footer con número de página
            Footer footer_default = doc.Footers.odd;
            footer_default.PageNumbers = true;
        }

        private void implementarPortada(DocX doc, Empresa empresa)
        {
            //Hacemos la portada
            string strTituloPortada = "Análisis de Recursos Valiosos";
            string strLogoPortada = string.Concat(Environment.CurrentDirectory, "\\RBV\\RBV\\img\\Login\\2.png");
            string strElaboradoPor = "Elaborado por: MyInnovation";
            // A formatting object for our headline:
            var headLineFormat = new Novacode.Formatting();
            headLineFormat.FontFamily = new System.Drawing.FontFamily("Arial");
            headLineFormat.Size = 26D;
            headLineFormat.Position = 32;

            // Ciudad:
            var paraFormat = new Novacode.Formatting();
            paraFormat.FontFamily = new System.Drawing.FontFamily("Arial");
            paraFormat.Size = 22D;

            // Formato elaborado por:
            var elaboradoPorFormat = new Novacode.Formatting();
            elaboradoPorFormat.FontFamily = new System.Drawing.FontFamily("Arial");
            elaboradoPorFormat.Size = 10D;

            // Add an Image into this document.
            Novacode.Image i = doc.AddImage(strLogoPortada);
            // Create a Picture (Custom View) of this Image.
            Picture p = i.CreatePicture();


            Paragraph pImg = doc.InsertParagraph("").AppendPicture(p);
            pImg.Alignment = Alignment.right;

            Paragraph pTit = doc.InsertParagraph(strTituloPortada, false, headLineFormat);
            pTit.Alignment = Alignment.right;

            Paragraph pEmp = doc.InsertParagraph(empresa.NombreEmpresa, false, headLineFormat);
            pEmp.Alignment = Alignment.right;

            Paragraph pElp = doc.InsertParagraph(strElaboradoPor, false, elaboradoPorFormat);
            pElp.Alignment = Alignment.right;

            doc.InsertParagraph();
            doc.InsertParagraph();

            Paragraph pCiud = doc.InsertParagraph("Medellín");
            pCiud.Alignment = Alignment.center;

            Paragraph pAno = doc.InsertParagraph(DateTime.Now.Year.ToString());
            pAno.Alignment = Alignment.center;
        }



        public string CrearGraficoBarra(Empresa empresa, string strDirectorio)
        {
            System.Web.UI.DataVisualization.Charting.Chart Chart1 = new System.Web.UI.DataVisualization.Charting.Chart();
           Chart1.Width=System.Web.UI.WebControls.Unit.Pixel(650);
           Chart1.Height = System.Web.UI.WebControls.Unit.Pixel(400);
           
            Legend legend = new Legend();
            legend.LegendStyle = LegendStyle.Table;
            legend.Docking = Docking.Bottom;
            Chart1.Legends.Add(legend);

            ChartArea ChartArea1=new ChartArea("ChartArea1");

            System.Web.UI.DataVisualization.Charting.Axis axisX = new System.Web.UI.DataVisualization.Charting.Axis();
            axisX.LabelAutoFitStyle = LabelAutoFitStyles.LabelsAngleStep90;
            axisX.LabelAutoFitMaxFontSize = 10;
            axisX.IsLabelAutoFit = true;
            axisX.Interval = 1;

            System.Web.UI.DataVisualization.Charting.Axis axisY = new System.Web.UI.DataVisualization.Charting.Axis();
            axisX.Interval = 0.2;

            ChartArea1.AxisX = axisX;
            ChartArea1.AxisY = axisY;


            Chart1.ChartAreas.Add(ChartArea1);            

            System.Web.UI.DataVisualization.Charting.Series Recursos = new System.Web.UI.DataVisualization.Charting.Series("Recursos");
            Recursos.ShadowColor = Color.Gray;
            Recursos.ChartType = SeriesChartType.Column;
            Recursos.IsVisibleInLegend = true;
            Chart1.Series.Add(Recursos);

            System.Web.UI.DataVisualization.Charting.Series srPromedio = new System.Web.UI.DataVisualization.Charting.Series("Promedio");
            srPromedio.ShadowColor = Color.Red;
            srPromedio.ChartType = SeriesChartType.Line;
            srPromedio.BorderWidth = 2;
            Chart1.Series.Add(srPromedio);

            List<Entidades.MatrizValoracion> MatrizValoracion = new List<RBV_Clases.MatrizValoracion>();
            List<RBV_Clases.RecursoValioso> recursosValiosos = new List<RBV_Clases.RecursoValioso>();
            decimal ValorTotal = 0;
            MatrizValoracion = RBV_Negocio.MatrizBO.ConsultarMatrizValoracion(empresa.IdEmpresa).OrderBy(p => p.IdCaracteristica).ThenBy(p => p.IdRecurso).ToList();

            if (MatrizValoracion.Count > 0)
            {
                recursosValiosos = RBV_Negocio.MatrizBO.CalcularResultadosMatriz(MatrizValoracion, empresa.IdEmpresa);
                ValorTotal = recursosValiosos.Sum(p => p.Valor) / recursosValiosos.Count;
            }
            string[] Titulos = recursosValiosos.Select(p => p.NombreRecurso).ToArray();
            decimal[] Valores = recursosValiosos.Select(p => p.Valor).ToArray();
            decimal[] Promedio = new decimal[Titulos.Length];
           
            Chart1.Series["Recursos"].Points.DataBindXY(Titulos, Valores);
            for (int i = 0; i < Titulos.Length; i++)
            {
                Promedio[i] = ValorTotal;
            }

            Chart1.Series["Promedio"].Points.DataBindXY(Titulos, Promedio);
            string strFile = "Barra" + empresa.NombreEmpresa + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".Jpeg";
            string imgName = string.Concat(strDirectorio, "\\", strFile);
            Chart1.SaveImage(imgName, ChartImageFormat.Jpeg);
            return imgName;
        }
        //private void TortaPorctipoRecurso()
        //{
        //    string[] TitulosTipo = recursosValiosos.Select(p => p.TipoRecurso).Distinct().ToArray();
        //    decimal[] ValoresTipo = (from p in recursosValiosos group p.IdTipoRecurso by p.IdTipoRecurso into g select Math.Round((Convert.ToDecimal(g.Count()) / Convert.ToDecimal(recursosValiosos.Count)) * 100, 2)).ToArray();

        //    TortaRecursos.Series["tipoRecurso"].Points.DataBindXY(TitulosTipo, ValoresTipo);
        //    TortaRecursos.Series["tipoRecurso"].Points[1]["Exploded"] = "true";
        //    for (int i = 0; i < TortaRecursos.Series["tipoRecurso"].Points.Count; i++)
        //    {
        //        TortaRecursos.Series["tipoRecurso"].Points[i].LegendText = TitulosTipo[i].ToString();
        //    }

        //}
        //private void TortaRecValiososSobreValiosos()
        //{
        //    string[] TitulosTipoVal = recursosValiosos.Select(p => p.TipoRecurso).Distinct().ToArray();
        //    decimal[] ValoresTipoVal = (from p in recursosValiosos where p.Valor >= ValorTotal group p.IdTipoRecurso by p.IdTipoRecurso into g select Math.Round((Convert.ToDecimal(g.Count()) / Convert.ToDecimal(recursosValiosos.Count)) * 100, 2)).ToArray();

        //    Array.Resize(ref TitulosTipoVal, TitulosTipoVal.Length + 1);
        //    TitulosTipoVal[TitulosTipoVal.Length - 1] = "No Valiosos";

        //    Array.Resize(ref ValoresTipoVal, ValoresTipoVal.Length + 1);
        //    ValoresTipoVal[ValoresTipoVal.Length - 1] = (100 - ValoresTipoVal.Sum());

        //    TipoRecValioso.Series["tipoRecursoVal"].Points.DataBindXY(TitulosTipoVal, ValoresTipoVal);

        //    TipoRecValioso.Series["tipoRecursoVal"].Points[1]["Exploded"] = "true";
        //    for (int i = 0; i < TipoRecValioso.Series["tipoRecursoVal"].Points.Count; i++)
        //    {
        //        TipoRecValioso.Series["tipoRecursoVal"].Points[i].LegendText = TitulosTipoVal[i].ToString();
        //    }

        //}
        //private void TortaRecValisosoSobreTotal()
        //{
        //    List<RBV_Clases.RecursoValioso> recursosVal = new List<RBV_Clases.RecursoValioso>();
        //    string[] TitulosValVal = recursosValiosos.Select(p => p.TipoRecurso).Distinct().ToArray();
        //    recursosVal = recursosValiosos.Where(p => p.Valor >= ValorTotal).ToList();
        //    decimal[] ValoresValVal = (from p in recursosValiosos where p.Valor >= ValorTotal group p.IdTipoRecurso by p.IdTipoRecurso into g select Math.Round((Convert.ToDecimal(g.Count()) / Convert.ToDecimal(recursosVal.Count)) * 100, 2)).ToArray();

        //    RecValiosoVal.Series["RecursosValioVal"].Points.DataBindXY(TitulosValVal, ValoresValVal);

        //    RecValiosoVal.Series["RecursosValioVal"].Points[1]["Exploded"] = "true";
        //    for (int i = 0; i < RecValiosoVal.Series["RecursosValioVal"].Points.Count; i++)
        //    {
        //        RecValiosoVal.Series["RecursosValioVal"].Points[i].LegendText = TitulosTipo[i].ToString();
        //    }


        //}

     
    }
}
