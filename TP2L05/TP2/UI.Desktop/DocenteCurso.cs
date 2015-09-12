﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class DocenteCurso : AplicationForm
    {
        public DocenteCurso()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            DocenteCursoLogic DCL = new DocenteCursoLogic();

            this.dgvUsuarios.DataSource = UL.GetAll();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            DialogResult DR = (MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo));

            if (DR == DialogResult.Yes) this.Close();

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            UsuarioDesktop UD = new UsuarioDesktop(AplicationForm.ModoForm.Alta);

            UD.ShowDialog();

            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.SelectedRows.Count != 0)
            {

                int ID = ((Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;

                UsuarioDesktop UD = new UsuarioDesktop(ID, AplicationForm.ModoForm.Modificacion);

                UD.ShowDialog();
            }

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.SelectedRows.Count != 0)
            {

                int ID = ((Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;

                UsuarioDesktop UD = new UsuarioDesktop(ID, AplicationForm.ModoForm.Baja);

                UD.ShowDialog();
            }
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}