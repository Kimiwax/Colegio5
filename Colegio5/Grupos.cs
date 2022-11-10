﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetodosColeg;
using ClaseVariables;

namespace Colegio5
{
    public partial class Grupos : Form
    {
        public Grupos()
        {
            InitializeComponent();
        }

  

        private void btn_crearGrupo_Click(object sender, EventArgs e)
        {
            Metodos.AbrirFormHijo(new GrupoAgregar(), this.panelPrincipal);
            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Metodos.AbrirFormHijo(new GruposBuscar(), this.panelPrincipal);
           
        }
    }
}
