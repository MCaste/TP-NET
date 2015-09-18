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

        private Business.Entities.AlumnoInscripciones _AluInscActual;

        //Propiedad
        public Business.Entities.AlumnoInscripciones AluInscActual
        
            {
            get { return _AluInscActual; }

            set { _AluInscActual = value; }
            }

        public override void MapearDeDatos()
            {
            this.txtID.Text = this.AluInscActual.ID.ToString();          
            this.txtIDAlumno.Text = this.AluInscActual.IDAlumno.ToString();            
            this.txtIDCurso.Text = this.AluInscActual.IDCurso.ToString();            
            this.txtCondicion.Text = this.AluInscActual.Condicion;            
            this.txtNota.Text = this.AluInscActual.Nota.ToString();      

            switch (Modo)
                {

                case ModoForm.Alta:
                        {
                        this.btnAceptar.Text = "Guardar";

                        this.AluInscActual.State = BusinessEntity.States.New;
                        }
                    break;
                case ModoForm.Modificacion:
                        {
                        this.btnAceptar.Text = "Guardar";

                        this.AluInscActual.State = BusinessEntity.States.Modified;                        
                        }
                    break;
                case ModoForm.Baja:
                        {
                        this.btnAceptar.Text = "Eliminar";

                        this.AluInscActual.State = BusinessEntity.States.Deleted;
                        } 
                    break;
                case ModoForm.Consulta:
                        {
                        this.btnAceptar.Text = "Aceptar";

                        this.AluInscActual.State = BusinessEntity.States.Unmodified;
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
                Business.Entities.AlumnoInscripciones aluInsc = new Business.Entities.AlumnoInscripciones();
                AluInscActual = aluInsc;
                 
                //this.AluInscActual.ID = this.txtID.Text; -->Es autoincremental?               
                this.AluInscActual.IDAlumno = Convert.ToInt32(this.txtIDAlumno.Text);                
                this.AluInscActual.IDCurso = Convert.ToInt32(this.txtIDCurso.Text);                
                this.AluInscActual.Condicion = this.txtCondicion.Text;                
                this.AluInscActual.Nota = Convert.ToInt32(this.txtNota.Text);
              
                }
            else if (Modo == AplicationForm.ModoForm.Modificacion)
                {
                this.AluInscActual.ID = Convert.ToInt32(this.txtID.Text);                
                this.AluInscActual.IDAlumno = Convert.ToInt32(this.txtIDAlumno.Text);                
                this.AluInscActual.IDCurso = Convert.ToInt32(this.txtIDCurso.Text);                
                this.AluInscActual.Condicion = this.txtCondicion.Text;                
                this.AluInscActual.Nota = Convert.ToInt32(this.txtNota.Text);
 
                }
            }

        public override void GuardarCambios() 
            {

            MapearADatos();

            AlumnoInscripcionLogic AIL = new AlumnoInscripcionLogic();

            AIL.Save(AluInscActual);

            }


      public override bool Validar()
            {

             if ((this.txtIDAlumno.Text == null) || (this.txtIDCurso.Text == null) || (this.txtCondicion.Text == null) || (this.txtNota.Text == null))
                    
                    
             { Notificar("Error", "Todos los campos son obligatorios, por favor completelos a todos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return false;}

             else return true;
            }              


        private void btnAceptar_Click( object sender, EventArgs e )
            {
            if (Validar() == true)
                {
                GuardarCambios();

                this.Close();
                }
            }

        //Agregandole new a los metodos void damos por sabido que el miembro que modificamos oculta el miembro que se hereda de la clase base.
        
        public new void Notificar(string titulo,string mensaje,MessageBoxButtons botones,MessageBoxIcon icono)
            {
            MessageBox.Show(mensaje,titulo, botones, icono);
            }

        public new void Notificar( string mensaje, MessageBoxButtons botones, MessageBoxIcon icono )
            {
            this.Notificar(this.Text, mensaje, botones, icono);
            }


        public AlumnoInscripcionesDesktop(ModoForm modo):this()
            {
            this.Modo = modo;   
            }

        public AlumnoInscripcionesDesktop(int ID, ModoForm modo): this()
            {
            this.Modo = modo;

            AlumnoInscripcionLogic AIL = new AlumnoInscripcionLogic();

            AluInscActual = AIL.GetOne(ID);

            MapearDeDatos();
            }

        private void btnCancelar_Click( object sender, EventArgs e )
            {
            DialogResult DR = (MessageBox.Show("Seguro que desea cancelar el proceso?","Cancelar", MessageBoxButtons.YesNo));

            if (DR == DialogResult.Yes) this.Close();      
            }
    }
}
 
