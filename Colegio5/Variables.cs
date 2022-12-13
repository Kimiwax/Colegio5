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
        public static string GuardarNomDocente;
        public static string RecibirNomDocente;
        public static string GuardarApeDocente;
        public static string RecibirApeDocente;

        public static string guardarNomAlumno;
        public static string RecibirNomAlumno;
        public static string RecibirApeAlumno;
        public static string GuardarApeAlumno;
      

        public static string selecLocalidad = "";
        public static string selecCaracterizacion = "";
        public static string selecLocalidad3 = "";
        public static string selecLocalidad4 = "";
        public static string selecCaracterizacion2 = "";
        public static string seleccCud = "";
        public static string selecParentesco = "";
        public static string selecSedeInclusion = "";
        public static string selecCiclo = "";
        public static string selecNivel = "";

        public static string selecLocalidad2 = "";
        public static string selecParentesco2 = "";
        public static string DNIAlumno = "";
        public static string guardarDNI = "";

        public static int guardarDniDocente = 0;
        public static int guardarAlumnGrupo = 0;

        public static List<int> GuardarDocumentos = new List<int>();
        public static List<string> GuardarNomApeAlumnos = new List<string>();

        public static string codigoGrupo = "";
        public static string nomApeDocente = "";

        public static bool fechaDeNacIncorrecta = false;

        public static bool user1 = false;
        public static bool user2 = false;
        public static string nombre = " ";
        public static string apellido = " ";

       
    }
    public class VariablesNoEstaticas
    {
       
        public string contraseñaUser1 = "admin";
        public string contraseñaUser2 = "guess";
    }
}
