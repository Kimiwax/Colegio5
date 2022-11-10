using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ClaseVariables
{
    public static class Variables
    {
        public static OleDbConnection ConexionConBD;
        public static string strConexion = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=Escuela501.mdb;";
        public static OleDbCommand Orden;
        public static OleDbDataReader Lector;

        public static int Row = 0;
        public static int GuardarDniDocente = 0;
        public static int RecibirDniDocente = 0;
        public static int RecibirDniAlumno = 0;
        public static int GuardarDniAlumno = 0;

        public static string selecLocalidad = "";
        public static string selecCaracterizacion = "";
        public static string selecLocalidad3 = "";
        public static string selecCaracterizacion2 = "";
        public static string seleccCud = "";
        public static string selecParentesco = "";

        public static string selecLocalidad2 = "";
        public static string selecParentesco2 = "";
        public static string DNIAlumno = "";
        public static string guardarDNI = "";

        public static bool fechaDeNacIncorrecta = false;

        public static bool user1 = false;
        public static bool user2 = false;
        public static string nombre = " ";
        public static string apellido = " ";
    }
    public class VariablesNoEstaticas
    {
        
        public string contraseñaUser1 = "5012022";
        public string contraseñaUser2 = "2022501";
    }
}
