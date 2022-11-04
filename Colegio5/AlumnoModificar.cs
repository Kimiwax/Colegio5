using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using ClaseVariables;

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

        private void MyDocument()
        {
            //Creamos un Objeto del Tipo Word Application 
            Microsoft.Office.Interop.Word.Application objWordApplication;
            //Creamos otro Objeto del Tipo Word Document  
            Microsoft.Office.Interop.Word.Document objWordDocument;
            // Creamos otro Objeto para interactuar con el Interop 
            Object oMissing = System.Reflection.Missing.Value;
            //Creamos una instancia de una Aplicación Word. 
            objWordApplication = new Microsoft.Office.Interop.Word.Application();
            //Entonces a la aplicación Word, le añadimos un documento.
            objWordDocument = objWordApplication.Documents.Add(ref oMissing);

            //Activamos el documento recien creado, de forma que podamos escribir en el 
            objWordDocument.Activate();
            //Comenzamos a escribir dentro del documento.
       
            objWordApplication.Selection.Font.Size = 12;
            objWordApplication.Selection.Font.Bold = 1;
            objWordApplication.Selection.TypeText(txt_informe.Text);
            objWordDocument.Activate();

            //Hace visible la Aplicacion para que veas lo que se ha escrito 
            objWordApplication.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDocument();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tP_VerAlumno_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
