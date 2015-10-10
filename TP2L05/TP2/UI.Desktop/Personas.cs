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
    public partial class Personas : AplicationForm
    {
        public Personas()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            PersonasLogic UL = new PersonasLogic();
            this.dgvPersona.AutoGenerateColumns = true;
            List<Persona> l = UL.GetAll();
            this.dgvPersona.DataSource = l;
        }

        private void Personas_Load(object sender, EventArgs e)
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
            PersonaDesktop UD = new PersonaDesktop(AplicationForm.ModoForm.Alta);
            UD.Text = "Alta persona";
            UD.ShowDialog();

            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvPersona.SelectedRows.Count != 0)
            {

                int ID = ((Persona)this.dgvPersona.SelectedRows[0].DataBoundItem).ID;

                PersonaDesktop UD = new PersonaDesktop(ID, AplicationForm.ModoForm.Modificacion);
                UD.Text = "Editar persona";
                UD.ShowDialog();
            }

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvPersona.SelectedRows.Count != 0)
            {

                int ID = ((Usuario)this.dgvPersona.SelectedRows[0].DataBoundItem).ID;

                UsuarioDesktop UD = new UsuarioDesktop(ID, AplicationForm.ModoForm.Baja);
                UD.Text = "Eliminar persona";
                UD.ShowDialog();
            }
        }
    }
}
