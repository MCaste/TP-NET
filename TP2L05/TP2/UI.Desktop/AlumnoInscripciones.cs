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
    public partial class AlumnoInscripciones : Form
    {
        public AlumnoInscripciones()
        {
            InitializeComponent();
        }

        public void Listar()
            {
            AlumnoInscripcionLogic AIL = new AlumnoInscripcionLogic();

            List<Business.Entities.AlumnoInscripciones> l = AIL.GetAll();
            }

        private void AlumnoInscripciones_Load( object sender, EventArgs e )
            {
            Listar();
            }

        private void btnActualizar_Click( object sender, EventArgs e )
            {
            Listar();
            }

        private void btnSalir_Click( object sender, EventArgs e )
            {    
            
            DialogResult DR = (MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo));

            if (DR == DialogResult.Yes) this.Close();        

            }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            AlumnoInscripcionesDesktop AID = new AlumnoInscripcionesDesktop(AplicationForm.ModoForm.Alta);

            AID.ShowDialog();

            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvAlumnoInscripciones.SelectedRows.Count != 0)
            {

                int ID = ((Business.Entities.AlumnoInscripciones)this.dgvAlumnoInscripciones.SelectedRows[0].DataBoundItem).ID;

                AlumnoInscripcionesDesktop AID = new AlumnoInscripcionesDesktop(ID, AplicationForm.ModoForm.Modificacion);

                AID.ShowDialog();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
                if (this.dgvAlumnoInscripciones.SelectedRows.Count != 0)
                {

                int ID = ((Business.Entities.AlumnoInscripciones)this.dgvAlumnoInscripciones.SelectedRows[0].DataBoundItem).ID;

                AlumnoInscripcionesDesktop AID = new AlumnoInscripcionesDesktop(ID, AplicationForm.ModoForm.Baja);

                AID.ShowDialog();
                }
        }
    }    
}

