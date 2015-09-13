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
    public partial class Plan : AplicationForm
    {
        public Plan()
        {
            InitializeComponent();
        }

        public void Listar()
            {
                PlanLogic PL = new PlanLogic();

            this.dgvPlan.DataSource = PL.GetAll();
            }

        private void Plan_Load( object sender, EventArgs e )
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

        private void tsbNuevo_Click( object sender, EventArgs e )
            {
            UsuarioDesktop UD = new UsuarioDesktop(AplicationForm.ModoForm.Alta);

            UD.ShowDialog();

            this.Listar();
            }

        private void tsbEditar_Click( object sender, EventArgs e )
            {
                if (this.dgvPlan.SelectedRows.Count != 0)
                {

                    int ID = ((Plan)this.dgvPlan.SelectedRows[0].DataBoundItem).ID;

                    PlanDesktop UD = new PlanDesktop(ID, AplicationForm.ModoForm.Modificacion);

                UD.ShowDialog();
                }
  
            }

        private void tsbEliminar_Click( object sender, EventArgs e )
            {
                if (this.dgvPlan.SelectedRows.Count != 0)
                {

                    int ID = ((Usuario)this.dgvPlan.SelectedRows[0].DataBoundItem).ID;

                    PlanDesktop UD = new PlanDesktop(ID, AplicationForm.ModoForm.Baja);

                UD.ShowDialog();
                }
            }
        }
    }

