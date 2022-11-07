using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using ClaseVariables;
using System.Reflection;

namespace Colegio5
{
    public partial class AlumnoModificar : Form
    {
        public AlumnoModificar()
        {
            InitializeComponent();
            txt_nombre.Text = ClaseVariables.Variables.nombre;
            txt_apellido.Text = ClaseVariables.Variables.apellido;

        }


       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void findAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object matchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchdialectitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref matchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchdialectitics, ref matchAlefHamza,
                ref matchControl);
                
        }

        //private void createWordDoc (object filename, object saveAs)
        //{
        //    Word.Application wordApp = new Word.Application();
        //    object missing = Missing.Value;
        //    Word.Document myWordDoc = null;

        //    if (FileDialog.Exists((string)filename))
        //    {
        //        object readOnly = false;
        //        object isVisible = false;
        //        wordApp.Visible = false;

        //        myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
        //                                        ref missing, ref missing, ref missing,
        //                                        ref missing, ref missing, ref missing,
        //                                        ref missing, ref missing, ref missing,
        //                                        ref missing, ref missing, ref missing, ref missing);

        //        myWordDoc.Activate();
        //    }
        //}

        private void btn_cerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_crearDoc_Click(object sender, EventArgs e)
        {
            object ObjMiss = System.Reflection.Missing.Value;

            Word.Application ObjWord = new Word.Application();

            string ruta = Application.StartupPath + @"\ModInformeDeAlumno.docx";
            object parametro = ruta;

            object nomA = "nomape";
            object doc = "docente";
            object docA = "dni";
            object dia = "dia";
            object mes = "mes";
            object anio = "anio";
            object texto = "texto";

            

                Word.Document ObjDoc = ObjWord.Documents.Open(ref parametro,
                ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss,
                ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss,
                ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss);

                DateTime fechaActual = DateTime.Today;

                Word.Range DIA = ObjDoc.Bookmarks.get_Item(ref dia).Range;
                DIA.Text = fechaActual.Day.ToString();

                Word.Range MES = ObjDoc.Bookmarks.get_Item(ref mes).Range;

                System.Globalization.DateTimeFormatInfo dtinfo =
                new System.Globalization.CultureInfo("es-ES", false).DateTimeFormat;
                MES.Text = dtinfo.GetMonthName(fechaActual.Month);

                Word.Range ANIO = ObjDoc.Bookmarks.get_Item(ref anio).Range;

                ANIO.Text = fechaActual.Year.ToString();
                Word.Range NOMAPE = ObjDoc.Bookmarks.get_Item(ref nomA).Range;
                NOMAPE.Text = txt_nomape.Text;

                Word.Range DNI = ObjDoc.Bookmarks.get_Item(ref docA).Range;
                DNI.Text = txt_dni.Text;

                Word.Range DOCENTE = ObjDoc.Bookmarks.get_Item(ref doc).Range;
            DOCENTE.Text = txt_docente.Text;

            Word.Range TEXTO = ObjDoc.Bookmarks.get_Item(ref texto).Range;
            TEXTO.Text = txt_informe.Text;

            object rango1 = DIA;
            object rango2 = MES;
            object rango3 = ANIO;
            object rango4 = NOMAPE;
            object rango5 = DNI;
            object rango6 = DOCENTE;
            object rango7 = TEXTO;

            ObjDoc.Bookmarks.Add("dia", ref rango1);
            ObjDoc.Bookmarks.Add("mes", ref rango2);
            ObjDoc.Bookmarks.Add("anio", ref rango3);
            ObjDoc.Bookmarks.Add("nomape", ref rango4);
            ObjDoc.Bookmarks.Add("dni", ref rango5);
            ObjDoc.Bookmarks.Add("docente", ref rango6);
            ObjDoc.Bookmarks.Add("texto", ref rango7);




            ObjWord.Visible = true;
        }
    }
}
