using System;
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
    public partial class ModuloUsuario : Form
    {
        public ModuloUsuario()
        {
            InitializeComponent();
        }
         
        public void Listar()
        {
            ModuloUsuarioLogic MUL = new ModuloUsuarioLogic();

            List<Business.Entities.ModuloUsuario> l = MUL.GetAll();
        }


        private void ModuloUsuario_Load(object sender, EventArgs e)
        {
            Listar();
        }


        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            ModuloUsuarioDesktop MUD = new ModuloUsuarioDesktop(AplicationForm.ModoForm.Alta);

            MUD.ShowDialog();

            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvModuloUsuario.SelectedRows.Count != 0)
            {

                int ID = ((Business.Entities.ModuloUsuario)this.dgvModuloUsuario.SelectedRows[0].DataBoundItem).ID;

                ModuloUsuarioDesktop MUD = new ModuloUsuarioDesktop(ID, AplicationForm.ModoForm.Modificacion);

                MUD.ShowDialog();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvModuloUsuario.SelectedRows.Count != 0)
            {

                int ID = ((Business.Entities.ModuloUsuario)this.dgvModuloUsuario.SelectedRows[0].DataBoundItem).ID;

                ModuloUsuarioDesktop MUD = new ModuloUsuarioDesktop(ID, AplicationForm.ModoForm.Baja);

                MUD.ShowDialog();
            }
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
    }
}

    
