using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseVariables;


namespace Colegio5
{
    public partial class Talleres : Form
    {
        public Talleres()
        {
            InitializeComponent();
            if (Variables.user2)
            {
                btn_crearTaller.Enabled = false;
                btn_crearTaller.Visible = false;
            }
        }
    }
}
