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
    public partial class AlumnoInscripcionesDesktop : AplicationForm
    {
        public AlumnoInscripcionesDesktop()
        {
            InitializeComponent();
        }
        //Propiedad
        private AlumnoInscripciones _AIActual;

        public AlumnoInscripciones AIActual
        {
            get { return _AIActual; }
            set { _AIActual = value;}
        }

        //Constructor

        public AlumnoInscripcionesDesktop(ModoForm modo):this()
            {
            this.Modo = modo;   
            }

        public AlumnoInscripcionesDesktop(int ID, ModoForm modo):this()
            {
            this.Modo = modo;

            AlumnoInscripciones ai = new UsuarioLogic();

            _AIActual = ai.GetOne(ID);

            MapearDeDatos();
            }

        private void btnCancelar_Click( object sender, EventArgs e )
            {
            DialogResult DR = (MessageBox.Show("Seguro que desea cancelar el proceso?","Cancelar", MessageBoxButtons.YesNo));

            if (DR == DialogResult.Yes) this.Close();      
            }

        //Metodos
        public override void MapearDeDatos() { }
        public override void MapearADatos()
        {
            base.MapearADatos();
        }
        public override void GuardarCambios()
        {
            base.GuardarCambios();
        }
        public override bool Validar() { return false;  }

        /*
        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }

        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }*/
    }
}
