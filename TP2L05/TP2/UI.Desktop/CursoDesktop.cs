using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Business.Entities;
using Business.Logic;


namespace UI.Desktop
{
    public partial class CursoDesktop : AplicationForm
    {
         public CursoDesktop()
            {
            InitializeComponent();
            }

        private Curso _CursoActual;

        //Propiedad
        public Curso CursoActual
        
            {
            get { return _CursoActual; }

            set { _CursoActual = value; }
            }

        public override void MapearDeDatos()
            {
            this.txtIDCurso.Text = this.CursoActual. ID.ToString();           
            this.txtIDComision.Text = this.CursoActual.Nombre;            
            this.txtIDMateria.Text = this.CursoActual.Apellido;        
            this.txtCupo.Text = this.CursoActual.Email;           
            this.txtAnioCalendario.Text = this.CursoActual.Clave;

            switch (Modo)
                {

                case ModoForm.Alta:
                        {
                        this.btnAceptar.Text = "Guardar";

                        this.CursoActual.State = BusinessEntity.States.New;
                        }
                    break;
                case ModoForm.Modificacion:
                        {
                        this.btnAceptar.Text = "Guardar";

                        this.CursoActual.State = BusinessEntity.States.Modified;                        
                        }
                    break;
                case ModoForm.Baja:
                        {
                        this.btnAceptar.Text = "Eliminar";

                        this.CursoActual.State = BusinessEntity.States.Deleted;
                        } 
                    break;
                case ModoForm.Consulta:
                        {
                        this.btnAceptar.Text = "Aceptar";

                        this.CursoActual.State = BusinessEntity.States.Unmodified;
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
                Curso cur = new Curso();
                 
                CursoActual = cur;
                 
                this.CursoActual.NombreUsuario = this.txtUsuario.Text;
                
                this.CursoActual.Clave = this.txtClave.Text;
                
                this.CursoActual.Nombre = this.txtNombre.Text;
                
                this.CursoActual.Apellido = this.txtApellido.Text;
                
                this.CursoActual.Email = this.txtEmail.Text;
                
                this.CursoActual.Habilitado = this.chkHabilitado.Checked;                 
                }
            else if (Modo == AplicationForm.ModoForm.Modificacion)
                {
                this.CursoActual.ID = Convert.ToInt32(this.txtID.Text);
                
                this.CursoActual.NombreUsuario = this.txtUsuario.Text;
                
                this.CursoActual.Clave = this.txtClave.Text;
                
                this.CursoActual.Nombre = this.txtNombre.Text;
                
                this.CursoActual.Apellido = this.txtApellido.Text;
                
                this.CursoActual.Email = this.txtEmail.Text;
                
                this.CursoActual.Habilitado = this.chkHabilitado.Checked;  
                }
            }

        public override void GuardarCambios() 
            {

            MapearADatos();

            UsuarioLogic UL = new UsuarioLogic();

            UL.Save(CursoActual);

            }

      public static bool ValidarEmail(TextBox txtEmail)
        {
          string formato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

          string email = txtEmail.Text;

          if (Regex.IsMatch(email, formato))
              {
              if (Regex.Replace(email, formato, String.Empty).Length == 0)
                  {
                  return true;
                  }
              else return false;
              }
          else return false;

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


        public UsuarioDesktop(ModoForm modo):this()
            {
            this.Modo = modo;   
            }

        public UsuarioDesktop(int ID, ModoForm modo):this()
            {
            this.Modo = modo;

            UsuarioLogic UL = new UsuarioLogic();

            UsuarioActual = UL.GetOne(ID);

            MapearDeDatos();
            }

        private void btnCancelar_Click( object sender, EventArgs e )
            {
            DialogResult DR = (MessageBox.Show("Seguro que desea cancelar el proceso?","Cancelar", MessageBoxButtons.YesNo));

            if (DR == DialogResult.Yes) this.Close();      
            }
        
    }
}
