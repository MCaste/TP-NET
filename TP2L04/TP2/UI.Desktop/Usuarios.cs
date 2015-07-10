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
    public partial class Usuarios : Form
        {
        public Usuarios()
            {
            InitializeComponent();
            }

        private void tlUsuarios_Paint( object sender, PaintEventArgs e )
            {

            }

        public void Listar()
            {
            UsuarioLogic UL = new UsuarioLogic();

            this.dgvUsuarios.DataSource = UL.GetAll();
            }

        private void Usuarios_Load( object sender, EventArgs e )
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

            if ((this.dgvUsuarios.SelectedRows!=null)&&(this.dgvUsuarios.MultiSelect==false)&&this.dgvUsuarios.SelectionMode == DataGridViewSelectionMode.FullRowSelect)
                { 
            
                int ID = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;

                UsuarioDesktop UD = new UsuarioDesktop(ID,AplicationForm.ModoForm.Modificacion);

                UsuarioLogic UL = new UsuarioLogic();

                

                }
            }

        private void tsbEliminar_Click( object sender, EventArgs e )
            {
            if ((this.dgvUsuarios.SelectedRows != null) && (this.dgvUsuarios.MultiSelect == false) && this.dgvUsuarios.SelectionMode == DataGridViewSelectionMode.FullRowSelect)
                {

                int ID = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;

                UsuarioDesktop UD = new UsuarioDesktop(ID, AplicationForm.ModoForm.Baja);

                UsuarioLogic UL = new UsuarioLogic();

                UL.Delete(ID);
               
                }
            }
        }
    }
