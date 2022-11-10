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
using System.Data.OleDb;
using MetodosColeg;

namespace Colegio5
{
    public partial class AlumnoModificar : Form
    {
        public AlumnoModificar(int dni)
        {
            InitializeComponent();
            Variables.RecibirDniAlumno = dni;

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

        private void tP_VerAlumno_Click(object sender, EventArgs e)
        {

        }

        private void AlumnoModificar_Load(object sender, EventArgs e)
        {
            Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
            Variables.ConexionConBD.Open();

            string ConsultaAlumno = "SELECT Persona.Nombre, Persona.Apellido, Persona.FechaNac, Persona.Sexo, Persona.DNI, Caracterizacion.Especificacion, Alumno.FechaIng, Alumno.ObraSocial, Alumno.CUD, Localidad.NomLocalidad, Persona.Direccion, SedIncDom.Detalle" +
                                    " FROM Caracterizacion INNER JOIN((SedIncDom INNER JOIN(Localidad INNER JOIN(Persona INNER JOIN Alumno ON Persona.DNI = Alumno.DNIAlumno) ON Localidad.CP = Persona.CodigoPostal) ON SedIncDom.CodSedIncDom = Alumno.CodigoSedIncDom) INNER JOIN AlumnoCaracterizaciones ON Alumno.DNIAlumno = AlumnoCaracterizaciones.dniAlumno) ON Caracterizacion.CodCaracterizacion = AlumnoCaracterizaciones.CodigoCaracterizaciones" +
                                    " WHERE Persona.DNI = " + Variables.RecibirDniAlumno + ";";

            Variables.Orden = new OleDbCommand(ConsultaAlumno, Variables.ConexionConBD);
            Variables.Lector = Variables.Orden.ExecuteReader();

            while (Variables.Lector.Read())
            {

                dgv_Alumnos.Rows.Add();
                dgv_Alumnos[0, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["Nombre"];
                dgv_Alumnos[1, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["Apellido"];
                dgv_Alumnos[2, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["FechaNac"];
                dgv_Alumnos[3, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["Sexo"];
                dgv_Alumnos[4, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["DNI"];
                dgv_Alumnos[5, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["Especificacion"];
                dgv_Alumnos[6, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["FechaIng"];
                dgv_Alumnos[7, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["ObraSocial"];
                dgv_Alumnos[8, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["CUD"];
                dgv_Alumnos[9, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["NomLocalidad"];
                dgv_Alumnos[10, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["Direccion"];
                dgv_Alumnos[11, dgv_Alumnos.Rows.Count - 1].Value = Variables.Lector["Detalle"];

            }
            dgv_Alumnos.ClearSelection();



            txt_nombreA.Text = dgv_Alumnos.Rows[0].Cells[0].Value.ToString();
            txt_apellidoA.Text = dgv_Alumnos.Rows[0].Cells[1].Value.ToString();
            txt_fecnacA.Text = dgv_Alumnos.Rows[0].Cells[2].Value.ToString().Substring(0, 10);
            txt_sexoA.Text = dgv_Alumnos.Rows[0].Cells[3].Value.ToString();
            txt_dniA.Text = dgv_Alumnos.Rows[0].Cells[4].Value.ToString();
            txt_caracterizacionA.Text = dgv_Alumnos.Rows[0].Cells[5].Value.ToString();
            txt_ingresoA.Text = dgv_Alumnos.Rows[0].Cells[6].Value.ToString().Substring(0, 10);
            txt_osA.Text = dgv_Alumnos.Rows[0].Cells[7].Value.ToString();
            txt_pensionA.Text = dgv_Alumnos.Rows[0].Cells[8].Value.ToString();
            txt_localidadA.Text = dgv_Alumnos.Rows[0].Cells[9].Value.ToString();
            txt_domicilioA.Text = dgv_Alumnos.Rows[0].Cells[10].Value.ToString();
            txt_servicioA.Text = dgv_Alumnos.Rows[0].Cells[11].Value.ToString();

            Variables.Lector.Close();
            Variables.ConexionConBD.Close();
        }
    }
}
