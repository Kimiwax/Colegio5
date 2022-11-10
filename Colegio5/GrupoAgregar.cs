﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colegio5
{
    public partial class GrupoAgregar : Form
    {
        public GrupoAgregar()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("45865743", "Micaela", "Pereyra", "Alumno");
            dataGridView1.Rows.Add("46764562", "Marcos", "Cruz", "Alumno");
            dataGridView1.Rows.Add("46764562", "Abigail", "Paz", "Alumno");
            dataGridView1.Rows.Add("34435434", "Sandra", "Benitez", "Docente");
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "Docente")
            {
                lstBox_Docente.Items.Add(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "  " + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "Alumno"){
                lstBox_Alumnos.Items.Add(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "  " + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        
        private void btn_crearGrupo_Click_1(object sender, EventArgs e)
        {
            Form okcan = new ShowDialogGrupos();

            DialogResult Result = okcan.ShowDialog();

            if (Result == DialogResult.OK)
            {
                MessageBox.Show("Se creo correctamente el grupo", "Aviso");
            }
            else { }
            //btn_crearGrupo.Text = "Cancel";
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
