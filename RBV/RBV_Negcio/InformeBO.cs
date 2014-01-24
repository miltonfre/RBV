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
           //string strDirectorio= string.Concat(Environment.CurrentDirectory, "\\InformesGenerados\\", empresa.NombreEmpresa);
            string strDirectorio = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "InformesGenerados\\" + empresa.NombreEmpresa);
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
            //doc.MarginTop = 5;
            //doc.MarginRight = 3;
            //doc.MarginLeft = 3;
            //doc.MarginBottom = 3;
            
            implementarHeader(doc);
            implementarFooter(doc);
            implementarPortada(doc, empresa);
            doc.InsertSectionPageBreak(true);
            ingresarEquipoTrabajo(doc, informe.RolesInforme);
            doc.InsertSectionPageBreak(true);
            insertarGraficoBarra(doc, empresa, strDirectorio);
            insertarGraficosTortas(doc, empresa, strDirectorio);
            insertarRecursosValiosos(doc, empresa);
          
            doc.Save();
            return fileName;
        }

        /// <summary>
        /// Crea la tabla de recursos valiosos
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="empresa"></param>
        private void insertarRecursosValiosos(DocX doc, Empresa empresa)
        {
            List<RecursoValioso> listadoRecursoValioso = MatrizBO.ConsultarRecursosValiosos(empresa.IdEmpresa);
            int cantidadRecursos = listadoRecursoValioso.Count;
            var RVParrafo = new Novacode.Formatting();
            RVParrafo.FontFamily = new System.Drawing.FontFamily("Calibri");
            RVParrafo.Size = 12D;
            RVParrafo.Position = 3;
          
            Paragraph pParr = doc.InsertParagraph("En este sentido se identifican "+cantidadRecursos+" recursos por encima del promedio, los cuales se convierten en valiosos y se listan a continuación", false, RVParrafo);
            pParr.Alignment = Alignment.left;            
        
            Table tab = doc.AddTable(cantidadRecursos + 1, 2);
            tab.AutoFit = AutoFit.Contents;
            tab.Alignment = Alignment.center;
            tab.Design = TableDesign.ColorfulGridAccent1;
            tab.Rows[0].Cells[0].Paragraphs.First().Append("Recurso Valioso");
            tab.Rows[0].Cells[0].Paragraphs.First().Alignment = Alignment.center;
            tab.Rows[0].Cells[0].Paragraphs.First().Bold();
            tab.Rows[0].Cells[1].Paragraphs.First().Append("Observaciones");
            tab.Rows[0].Cells[1].Paragraphs.First().Alignment = Alignment.center;
            tab.Rows[0].Cells[1].Paragraphs.First().Bold();

            for (int i = 0; i < cantidadRecursos; i++)
            {
                RecursoValioso recursoValioso = listadoRecursoValioso[i];
                tab.Rows[i + 1].Cells[0].Paragraphs.First().Append(recursoValioso.NombreRecurso);
                
            }
            doc.InsertTable(tab);
        }
        private void ingresarEquipoTrabajo(DocX doc, List<RolesInforme> rolesInforme)
        {
            // Titulo Equipo de Trabajo:
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            var equipoTrabajoFormat = new Novacode.Formatting();
            equipoTrabajoFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
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
            var RVFormat = new Novacode.Formatting();
            RVFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
            RVFormat.Size = 12D;
            RVFormat.Bold = true;
            Paragraph pTit = doc.InsertParagraph("Recursos Valiosos " + empresa.NombreEmpresa.ToUpper(), false, RVFormat);
            pTit.Alignment = Alignment.left;

            var RVParrafo = new Novacode.Formatting();
            RVParrafo.FontFamily = new System.Drawing.FontFamily("Calibri");
            RVParrafo.Size = 12D;
            RVParrafo.Position = 3;
            Paragraph pParr = doc.InsertParagraph("Se definen los recursos físicos, organizacionales e intangibles con los que cuenta " + empresa.NombreEmpresa.ToUpper() + ". Los recursos definidos son evaluados por parte del equipo técnico – gerencial desde la perspectiva de inimitable, durabilidad, apropiación, sustitución y superioridad competitiva.", false, RVParrafo);
            pParr.Alignment = Alignment.left;

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

            //string strLogoPortada = string.Concat(Environment.CurrentDirectory, "\\RBV\\RBV\\img\\Login\\2.png");
            string strLogoPortada = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img\\Login\\2.png");
            string strElaboradoPor = "Elaborado por: MyInnovation";
            // A formatting object for our headline:
            var headLineFormat = new Novacode.Formatting();
            headLineFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
            headLineFormat.Size = 26D;

            // Ciudad:
            var paraFormat = new Novacode.Formatting();
            paraFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
            paraFormat.Size = 18D;

            // Formato elaborado por:
            var elaboradoPorFormat = new Novacode.Formatting();
            elaboradoPorFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
            elaboradoPorFormat.Size = 10D;

            // Add an Image into this document.
            //Novacode.Image i = doc.AddImage(strLogoPortada);
            //// Create a Picture (Custom View) of this Image.
            //Picture p = i.CreatePicture();


            //Paragraph pImg = doc.InsertParagraph("").AppendPicture(p);
            //pImg.Alignment = Alignment.right;
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            Paragraph pTit = doc.InsertParagraph(strTituloPortada, false, headLineFormat);
            pTit.Alignment = Alignment.center;
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph(); 
            doc.InsertParagraph();
            doc.InsertParagraph();

             Paragraph pEmp = doc.InsertParagraph("Milton Fredy González Díaz" , false, headLineFormat);
            pEmp.Alignment = Alignment.center;
            pEmp = doc.InsertParagraph("Diego León Pineda Montoya", false, headLineFormat);
            pEmp.Alignment = Alignment.center;


            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            doc.InsertParagraph();
            pEmp = doc.InsertParagraph(empresa.NombreEmpresa, false, paraFormat);
            pEmp.Alignment = Alignment.center;

            //Paragraph pElp = doc.InsertParagraph(strElaboradoPor, false, elaboradoPorFormat);
            //pElp.Alignment = Alignment.right;


            Paragraph pCiud = doc.InsertParagraph("Medellín", false, paraFormat);
            pCiud.Alignment = Alignment.center;

            Paragraph pAno = doc.InsertParagraph(DateTime.Now.Year.ToString(), false, paraFormat);
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


        #region TORTA
        /// <summary>
        /// Metodo que se encarga de crear el 'Coco' de los gráficos de barra
        /// </summary>
        /// <returns></returns>
        public System.Web.UI.DataVisualization.Charting.Chart CrearTorta()
        {
            System.Web.UI.DataVisualization.Charting.Chart TortaRecursos = new System.Web.UI.DataVisualization.Charting.Chart();
            TortaRecursos.Width = System.Web.UI.WebControls.Unit.Pixel(650);
            TortaRecursos.Height = System.Web.UI.WebControls.Unit.Pixel(400);
            TortaRecursos.BackGradientStyle = GradientStyle.TopBottom;

            Legend Default = new Legend();
            Default.LegendStyle = LegendStyle.Row;
            Default.Docking = Docking.Bottom;
            Default.Alignment = StringAlignment.Center;
            Default.BackColor = Color.Transparent;
            Default.IsTextAutoFit = false;
            //Font font = new Font();
            //font.FontFamily=FontFamily.
            //Default.Font=
            TortaRecursos.Legends.Add(Default);

            

            ChartArea ChartArea1 = new ChartArea("ChartArea1");

            System.Web.UI.DataVisualization.Charting.Axis axisX = new System.Web.UI.DataVisualization.Charting.Axis();
            axisX.LabelAutoFitStyle = LabelAutoFitStyles.LabelsAngleStep90;
            axisX.IsLabelAutoFit = true;
            axisX.Interval = 1;
           
          
            System.Web.UI.DataVisualization.Charting.Axis axisY = new System.Web.UI.DataVisualization.Charting.Axis();
            axisX.Interval = 0.2;

            ChartArea1.AxisX = axisX;
            ChartArea1.AxisY = axisY;

            //Color borderColor = new Color();
            //borderColor.A = 64;
            //borderColor.B = 64;
            //borderColor.G = 64;
            //borderColor.R = 64;
            //ChartArea1.BorderColor=borderColor;
            ChartArea1.BackColor = Color.Transparent;
            ChartArea1.BackSecondaryColor = Color.Transparent;
            ChartArea1.Area3DStyle.Enable3D = true;
            ChartArea1.BorderWidth = 0;

            TortaRecursos.ChartAreas.Add(ChartArea1);

            System.Web.UI.DataVisualization.Charting.Series tipoRecurso = new System.Web.UI.DataVisualization.Charting.Series("Recursos");
            tipoRecurso.ShadowColor = Color.Gray;
            tipoRecurso.ChartType = SeriesChartType.Pie;
            tipoRecurso.IsVisibleInLegend = true;
            tipoRecurso.MarkerImageTransparentColor = Color.Aqua;
            tipoRecurso.Label = "#PERCENT{P1}";
            tipoRecurso.IsValueShownAsLabel = true;
            tipoRecurso.LabelForeColor = Color.White;
            tipoRecurso.XValueType = ChartValueType.Auto;
            TortaRecursos.Series.Add(tipoRecurso);


            return TortaRecursos;
        }

        /// <summary>
        /// Método que se encarga de llenar los datos de la torta por porcentaje de recursos
        /// </summary>
        /// <param name="empresa"></param>
        /// <param name="strDirectorio"></param>
        /// <returns></returns>
        public string CrearTortaRecursos(Empresa empresa, string strDirectorio, List<RBV_Clases.RecursoValioso> recursosValiosos)
        {
            System.Web.UI.DataVisualization.Charting.Chart TortaRecursos = CrearTorta();
                      
            string[] TitulosTipo = recursosValiosos.Select(p => p.TipoRecurso).Distinct().ToArray();
            decimal[] ValoresTipo = (from p in recursosValiosos group p.IdTipoRecurso by p.IdTipoRecurso into g select Math.Round((Convert.ToDecimal(g.Count()) / Convert.ToDecimal(recursosValiosos.Count)) * 100, 2)).ToArray();

            TortaRecursos.Series["Recursos"].Points.DataBindXY(TitulosTipo, ValoresTipo);
            TortaRecursos.Series["Recursos"].Points[1]["Exploded"] = "true";
            for (int i = 0; i < TortaRecursos.Series["Recursos"].Points.Count; i++)
            {
                TortaRecursos.Series["Recursos"].Points[i].LegendText = TitulosTipo[i].ToString();
            }
            string strFile = "TortaRec" + empresa.NombreEmpresa + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".Jpeg";
            string imgName = string.Concat(strDirectorio, "\\", strFile);
            TortaRecursos.SaveImage(imgName, ChartImageFormat.Jpeg);
            return imgName;
        }

        /// <summary>
        /// Método que se encarga de llenar los datos de la torta por Tipo de Recursos Valiosos Sobre Total
        /// </summary>
        /// <param name="empresa"></param>
        /// <param name="strDirectorio"></param>
        /// <returns></returns>
        public string CrearTortaRecursosSobreTotal(Empresa empresa, string strDirectorio, List<RBV_Clases.RecursoValioso> recursosValiosos, decimal ValorTotal)
        {
            System.Web.UI.DataVisualization.Charting.Chart TortaRecursos = CrearTorta();


            string[] TitulosTipoVal = recursosValiosos.Where(p => p.Valor >= ValorTotal).Select(p => p.TipoRecurso).Distinct().ToArray();
            decimal[] ValoresTipoVal = (from p in recursosValiosos where p.Valor >= ValorTotal group p.IdTipoRecurso by p.IdTipoRecurso into g select Math.Round((Convert.ToDecimal(g.Count()) / Convert.ToDecimal(recursosValiosos.Count)) * 100, 2)).ToArray();


            Array.Resize(ref TitulosTipoVal, TitulosTipoVal.Length + 1);
            TitulosTipoVal[TitulosTipoVal.Length - 1] = "No Valiosos";

            Array.Resize(ref ValoresTipoVal, ValoresTipoVal.Length + 1);
            ValoresTipoVal[ValoresTipoVal.Length - 1] = (100 - ValoresTipoVal.Sum());
            TortaRecursos.Series["Recursos"].Points.DataBindXY(TitulosTipoVal, ValoresTipoVal);

            //TortaRecursos.Series["Recursos"].Points[1]["Exploded"] = "true";
            for (int i = 0; i < TortaRecursos.Series["Recursos"].Points.Count; i++)
            {
                TortaRecursos.Series["Recursos"].Points[i].LegendText = TitulosTipoVal[i].ToString();
            }
            string strFile = "TortaRecSobret" + empresa.NombreEmpresa + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".Jpeg";
            string imgName = string.Concat(strDirectorio, "\\", strFile);
            TortaRecursos.SaveImage(imgName, ChartImageFormat.Jpeg);
            return imgName;
        }

        /// <summary>
        /// Método que se encarga de llenar los datos de la torta por Tipo de Recursos Valiosos Sobre Valiosos
        /// </summary>
        /// <param name="empresa"></param>
        /// <param name="strDirectorio"></param>
        /// <returns></returns>
        public string CrearTortaRecursosValiososSobreValiosos(Empresa empresa, string strDirectorio, List<RBV_Clases.RecursoValioso> recursosValiosos, decimal ValorTotal)
        {
            System.Web.UI.DataVisualization.Charting.Chart TortaRecursos = CrearTorta();
            string[] TitulosTipo = recursosValiosos.Select(p => p.TipoRecurso).Distinct().ToArray();
            List<RBV_Clases.RecursoValioso> recursosVal = new List<RBV_Clases.RecursoValioso>();
            
            string[] TitulosValVal = recursosValiosos.Where(p => p.Valor >= ValorTotal).Select(p => p.TipoRecurso).Distinct().ToArray();
            recursosVal = recursosValiosos.Where(p => p.Valor >= ValorTotal).ToList();
            decimal[] ValoresValVal = (from p in recursosValiosos where p.Valor >= ValorTotal group p.IdTipoRecurso by p.IdTipoRecurso into g select Math.Round((Convert.ToDecimal(g.Count()) / Convert.ToDecimal(recursosVal.Count)) * 100, 2)).ToArray();


            TortaRecursos.Series["Recursos"].Points.DataBindXY(TitulosValVal, ValoresValVal);
            for (int i = 0; i < TortaRecursos.Series["Recursos"].Points.Count; i++)
            {
                TortaRecursos.Series["Recursos"].Points[i].LegendText = TitulosTipo[i].ToString();
            }
            string strFile = "TortaRecsobreVal" + empresa.NombreEmpresa + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".Jpeg";
            string imgName = string.Concat(strDirectorio, "\\", strFile);
            TortaRecursos.SaveImage(imgName, ChartImageFormat.Jpeg);
            return imgName;
        }

        private void insertarGraficosTortas(DocX doc, Empresa empresa, string strDirectorio)
        {

            List<RBV_Clases.RecursoValioso> recursosValiosos = new List<RBV_Clases.RecursoValioso>();
            List<Entidades.MatrizValoracion> MatrizValoracion = new List<RBV_Clases.MatrizValoracion>();
            decimal ValorTotal = 0;
            MatrizValoracion = RBV_Negocio.MatrizBO.ConsultarMatrizValoracion(empresa.IdEmpresa).OrderBy(p => p.IdCaracteristica).ThenBy(p => p.IdRecurso).ToList();

            if (MatrizValoracion.Count > 0)
            {
                recursosValiosos = RBV_Negocio.MatrizBO.CalcularResultadosMatriz(MatrizValoracion, empresa.IdEmpresa);
                ValorTotal = recursosValiosos.Sum(p => p.Valor) / recursosValiosos.Count;
            }



            var RVFormat = new Novacode.Formatting();
            RVFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
            RVFormat.Size = 12D;
            RVFormat.Bold = true;


            var RVParrafo = new Novacode.Formatting();
            RVParrafo.FontFamily = new System.Drawing.FontFamily("Calibri");
            RVParrafo.Size = 12D;
            RVParrafo.Position = 3;


            string strGraficoTortaRecursos = CrearTortaRecursos(empresa, strDirectorio, recursosValiosos);
            string strGraficoTortaRecursosSobreTotal = CrearTortaRecursosSobreTotal(empresa, strDirectorio, recursosValiosos, ValorTotal);
            string strGraficoTortaRecursosSobreValiosos = CrearTortaRecursosValiososSobreValiosos(empresa, strDirectorio, recursosValiosos, ValorTotal);

            //Torta de porcentajes
            Paragraph pTit = doc.InsertParagraph("Porcentajes de Recursos", false, RVFormat);
            pTit.Alignment = Alignment.left;
            Paragraph pParr = doc.InsertParagraph("Aquí va el análisis a la torta de porcentaje ", false, RVParrafo);
            pParr.Alignment = Alignment.left;

            Novacode.Image i = doc.AddImage(strGraficoTortaRecursos);
            Picture pic = i.CreatePicture();
            Paragraph pImg = doc.InsertParagraph("").AppendPicture(pic);
            pImg.Alignment = Alignment.center;

            //Torta de porcentajes sobre recursos total
            pTit = doc.InsertParagraph("Porcentajes de Recursos valiosos sobre el total de los recursos", false, RVFormat);
            pTit.Alignment = Alignment.left;
            pParr = doc.InsertParagraph("Aquí va el análisis a la torta de porcentaje ", false, RVParrafo);
            pParr.Alignment = Alignment.left;

            i = doc.AddImage(strGraficoTortaRecursosSobreTotal);
            pic = i.CreatePicture();
            pImg = doc.InsertParagraph("").AppendPicture(pic);
            pImg.Alignment = Alignment.center;

            //Torta de porcentajes sobre valiosos
            pTit = doc.InsertParagraph("Porcentajes de Recursos valiosos sobre el total de los valiosos", false, RVFormat);
            pTit.Alignment = Alignment.left;
            pParr = doc.InsertParagraph("Aquí va el análisis a la torta de porcentaje", false, RVParrafo);
            pParr.Alignment = Alignment.left;

            i = doc.AddImage(strGraficoTortaRecursosSobreValiosos);
            pic = i.CreatePicture();
            pImg = doc.InsertParagraph("").AppendPicture(pic);
            pImg.Alignment = Alignment.center;
        }
        #endregion
    }
}
