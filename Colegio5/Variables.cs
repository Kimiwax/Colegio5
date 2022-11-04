using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ClaseVariables
{
    public static class Variables
    {
        public static OleDbConnection ConexionConBD;
        public static string strConexion = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=Escuela501.mdb;";
        public static OleDbCommand Orden;
        public static OleDbDataReader Lector;


        public static string selecLocalidad = "";
        public static string selecCaracterizacion = "";

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
