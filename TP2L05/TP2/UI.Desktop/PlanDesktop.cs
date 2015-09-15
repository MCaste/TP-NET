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
    public partial class PlanDesktop : AplicationForm
    {
        public PlanDesktop()
        {
            InitializeComponent();
        }

        private Business.Entities.Plan _PlanActual;

        public Business.Entities.Plan PlanActual
        {
            get { return _PlanActual; }

            set { _PlanActual = value; }
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.PlanActual.ID.ToString();

            this.txtDescripcion.Text = this.PlanActual.Descripcion;

            this.txtIDEspecialidad.Text = this.PlanActual.IDEspecialidad.ToString();

            switch (Modo)
            {

                case ModoForm.Alta:
                    {
                        this.btnAceptar.Text = "Guardar";

                        this.PlanActual.State = BusinessEntity.States.New;
                    }
                    break;

                case ModoForm.Modificacion:
                    {
                        this.btnAceptar.Text = "Guardar";

                        this.PlanActual.State = BusinessEntity.States.Modified;
                    }
                    break;

                case ModoForm.Baja:
                    {
                        this.btnAceptar.Text = "Eliminar";

                        this.PlanActual.State = BusinessEntity.States.Deleted;
                    }
                    break;

                case ModoForm.Consulta:
                    {
                        this.btnAceptar.Text = "Aceptar";

                        this.PlanActual.State = BusinessEntity.States.Unmodified;
                    }
                    break;

                default:
                    break;
            }
        }

        public override void MapearADatos()
        {

            if (Modo == AplicationForm.ModoForm.Alta)
            {
                Business.Entities.Plan p = new Business.Entities.Plan();

                PlanActual = p;

                this.PlanActual.IDEspecialidad = Convert.ToInt32(txtIDEspecialidad.Text);

                this.PlanActual.Descripcion = this.txtDescripcion.Text;
            }
            else if (Modo == AplicationForm.ModoForm.Modificacion)
            {
                this.PlanActual.ID = Convert.ToInt32(this.txtID.Text);

                this.PlanActual.Descripcion = this.txtDescripcion.Text;

                this.PlanActual.IDEspecialidad = Convert.ToInt32(this.txtIDEspecialidad.Text);
            }
        }

        public override void GuardarCambios()
        {

            MapearADatos();

            PlanLogic UL = new PlanLogic();

            UL.Save(PlanActual);

        }

        public override bool Validar()
        {

            int ban1;

            ban1 = 0;

            if ((this.txtIDEspecialidad.Text == null) || (this.txtDescripcion.Text == null))
            {
                ban1 = 1;
                Notificar("Error", "Todos los campos son obligatorios, por favor completelos a todos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ban1 == 1) return false;

            else return true;
        }

        public new void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }

        public new void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }


        public PlanDesktop(ModoForm modo)
            : this()
        {
            this.Modo = modo;
        }

        public PlanDesktop(int ID, ModoForm modo)
            : this()
        {
            this.Modo = modo;

            PlanLogic PL = new PlanLogic();

            PlanActual = PL.GetOne(ID);

            MapearDeDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                GuardarCambios();

                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult DR = (MessageBox.Show("Seguro que desea cancelar el proceso?", "Cancelar", MessageBoxButtons.YesNo));

            if (DR == DialogResult.Yes) this.Close();
        }

    }
}