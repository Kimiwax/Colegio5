using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MetodosColeg
{
    public class Metodos
    {

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
