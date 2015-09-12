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
    public partial class DocenteCursoDesktop : AplicationForm
    {
        public DocenteCursoDesktop()
            {
            InitializeComponent();
            }

        private DocenteCurso _UsuarioActual;

        //Propiedad
        public DocenteCurso DocenteCursoActual
        
            {
            get { return _UsuarioActual; }

            set { _UsuarioActual = value; }
            }

        public override void MapearDeDatos()
            {
            this.txtIDDictado.Text = this.DocenteCursoActual.ID.ToString();           
            this.txtIDDocente.Text = this.DocenteCursoActual.Habilitado;            
            this.txtNombre.Text = this.DocenteCursoActual.Nombre;            
            this.txtApellido.Text = this.DocenteCursoActual.Apellido;

            switch (Modo)
                {

                case ModoForm.Alta:
                        {
                        this.btnAceptar.Text = "Guardar";

                        this.DocenteCursoActual.State = BusinessEntity.States.New;
                        }
                    break;
                case ModoForm.Modificacion:
                        {
                        this.btnAceptar.Text = "Guardar";

                        this.DocenteCursoActual.State = BusinessEntity.States.Modified;                        
                        }
                    break;
                case ModoForm.Baja:
                        {
                        this.btnAceptar.Text = "Eliminar";

                        this.DocenteCursoActual.State = BusinessEntity.States.Deleted;
                        } 
                    break;
                case ModoForm.Consulta:
                        {
                        this.btnAceptar.Text = "Aceptar";

                        this.DocenteCursoActual.State = BusinessEntity.States.Unmodified;
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
                DocenteCurso dca = new DocenteCurso();
                 
                DocenteCursoActual = dca;

                this.DocenteCursoActual. = this.txtIDDictado.Text;
                this.DocenteCursoActual. = this.txtIDDocente.Text;                
                this.DocenteCursoActual. = this.txtNombre.Text;                
                this.DocenteCursoActual. = this.txtApellido.Text;                
                }
            else if (Modo == AplicationForm.ModoForm.Modificacion)
                {
                    this.DocenteCursoActual. = Convert.ToInt32(this.txtIDDictado.Text);
                    this.DocenteCursoActual. = this.txtIDDocente.Text;               
                this.DocenteCursoActual. = this.txtClave.Text;              
                this.DocenteCursoActual. = this.txtNombre.Text; 
                }
            }

        public override void GuardarCambios() 
            {

            MapearADatos();

            DocenteCursoLogic DCL = new DocenteCursoLogic();

            DCL.Save(DocenteCursoActual);

            }


      public override bool Validar()
            {

            int ban1,ban2 ,ban3, ban4;

            ban1 = ban2 = ban3 = ban4 = 0;

             if ((this.txtNombre.Text == null) || (this.txtApellido.Text == null) || (this.txtEmail.Text == null) || (this.txtUsuario.Text == null) || (this.txtClave.Text == null) || (this.txtConfirmarClave.Text == null))
                    {
                    ban1 = 1;
                    Notificar("Error", "Todos los campos son obligatorios, por favor completelos a todos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            if (this.txtClave.Text != this.txtConfirmarClave.Text)
                    {
                    ban2 = 1;

                    Notificar("Error","Las contraseñas no coinciden, por favor vuelva a ingresarla nuevamente.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                   }
                

            if ((this.txtClave.Text.Length) < 8)
                    {
                    ban3 = 1;

                    Notificar("Error", "La contraseña debe tener una longitud mínima de 8 caracteres,por favor vuelva a ingresarla nuevamente.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

            if (ValidarEmail(txtEmail)==false)
              
                {
                ban4 = 1;

                Notificar("Error","El email ingresado no se encuentra en el formato adecuado,por favor vuelva a ingresarlo nuevamente.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            if ((ban1 == 1) || (ban2 == 1) || (ban3 == 1) || (ban4==1)) return false;
                
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
        
        public new  void Notificar(string titulo,string mensaje,MessageBoxButtons botones,MessageBoxIcon icono)
            {
            MessageBox.Show(mensaje,titulo, botones, icono);
            }

        public new void Notificar( string mensaje, MessageBoxButtons botones, MessageBoxIcon icono )
            {
            this.Notificar(this.Text, mensaje, botones, icono);
            }


        public DocenteCursoDesktop(ModoForm modo):this()
            {
            this.Modo = modo;   
            }

        public DocenteCursoDesktop(int ID, ModoForm modo): this()
            {
            this.Modo = modo;

            DocenteCursoLogic dcl = new DocenteCursoLogic();

            DocenteCursoActual = dcl.GetOne(ID);

            MapearDeDatos();
            }

        private void btnCancelar_Click( object sender, EventArgs e )
            {
            DialogResult DR = (MessageBox.Show("Seguro que desea cancelar el proceso?","Cancelar", MessageBoxButtons.YesNo));

            if (DR == DialogResult.Yes) this.Close();      
            }
    }
}
