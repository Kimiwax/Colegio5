using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ClaseVariables;
using System.Data.OleDb;

namespace MetodosColeg
{
    public class Metodos
    {

        public static void ConectaDB()
        {
            Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
            Variables.ConexionConBD.Open();
        }

        public static OleDbDataReader LecturaDB(string consulta)
        {

            Variables.ConexionConBD = new OleDbConnection(Variables.strConexion);
            Variables.ConexionConBD.Open();

            Variables.Orden = new OleDbCommand(consulta, Variables.ConexionConBD);
            Variables.Lector = Variables.Orden.ExecuteReader();
            return Variables.Lector;

            Variables.ConexionConBD.Close();
        }

        public static void CerrarDB()
        {
            Variables.Lector.Close();
            Variables.ConexionConBD.Close();
        }

        public static void CerrarDB2()
        {
            
            Variables.ConexionConBD.Close();
        }

        public static void CargaDB(string consulta)
        {
            Variables.Orden = new OleDbCommand(consulta, Variables.ConexionConBD);
            Variables.Lector = Variables.Orden.ExecuteReader();
        }

        public static void CargaDB2 (string consulta)
        {
            Variables.Orden = new OleDbCommand(consulta, Variables.ConexionConBD);
            Variables.Orden.ExecuteNonQuery();
        }

        public static void AbrirFormHijo(object formHijo, Panel panelcontenedor)
        {

            if (panelcontenedor.Controls.Count > 0)
               panelcontenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            panelcontenedor.Controls.Add(fh);
            panelcontenedor.Tag = fh;
            fh.Show();

        }


        public static void ValidarLetras(KeyPressEventArgs ele)
        {
            if (!(char.IsLetter(ele.KeyChar)) && (ele.KeyChar != (char)Keys.Back))
            {
                ele.Handled = true;
                return;
            }

        }

        public static void ValidarNumeros(KeyPressEventArgs el)
        {
                if (!(char.IsNumber(el.KeyChar)) && (el.KeyChar != (char)Keys.Back))
                {
                    el.Handled = true;
                    return;
                }
            
        }

        public static void ValidarSoloNumerosYLetras(KeyPressEventArgs el)
        {
            if (!(char.IsLetter(el.KeyChar)) && (el.KeyChar != (char)Keys.Back) && !(char.IsNumber(el.KeyChar)) && !(char.IsSeparator(el.KeyChar)))
            {
                el.Handled = true;
                return;
            }
        }


        public static void Validaremail(KeyPressEventArgs el)
        {
            if (!(char.IsLetter(el.KeyChar)) && (el.KeyChar != (char)Keys.Back) && !(char.IsNumber(el.KeyChar)) && !(char.IsSeparator(el.KeyChar)) && !(el.KeyChar == Convert.ToChar(64)) && !(el.KeyChar == Convert.ToChar(46)))
            {
                el.Handled = true;
                return;
            }
          
        }


    }
}
