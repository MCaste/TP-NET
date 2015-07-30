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
    public partial class UsuarioDesktop : AplicationForm
        {
        public UsuarioDesktop()
            {
            InitializeComponent();
            }

        private Usuario _UsuarioActual;


        public Usuario UsuarioActual
        
            {
            get { return _UsuarioActual; }

            set { _UsuarioActual = value; }
            }

        public override void MapearDeDatos()
            {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
           
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            
            this.txtEmail.Text = this.UsuarioActual.Email;
            
            this.txtClave.Text = this.UsuarioActual.Clave;

            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;

            switch (Modo)
                {

                case ModoForm.Alta:
                        {
                        this.btnAceptar.Text = "Guardar";

                        this.UsuarioActual.State = BusinessEntity.States.New;
                        }
                    break;
                case ModoForm.Modificacion:
                        {
                        this.btnAceptar.Text = "Guardar";

                        this.UsuarioActual.State = BusinessEntity.States.Modified;                        
                        }
                    break;
                case ModoForm.Baja:
                        {
                        this.btnAceptar.Text = "Eliminar";

                        this.UsuarioActual.State = BusinessEntity.States.Deleted;
                        } 
                    break;
                case ModoForm.Consulta:
                        {
                        this.btnAceptar.Text = "Aceptar";

                        this.UsuarioActual.State = BusinessEntity.States.Unmodified;
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
                Usuario usu = new Usuario();
                 
                UsuarioActual = usu;
                 
                this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                
                this.UsuarioActual.Clave = this.txtClave.Text;
                
                this.UsuarioActual.Nombre = this.txtNombre.Text;
                
                this.UsuarioActual.Apellido = this.txtApellido.Text;
                
                this.UsuarioActual.Email = this.txtEmail.Text;
                
                this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;                 
                }
            else if (Modo == AplicationForm.ModoForm.Modificacion)
                {
                this.UsuarioActual.ID = Convert.ToInt32(this.txtID.Text);
                
                this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                
                this.UsuarioActual.Clave = this.txtClave.Text;
                
                this.UsuarioActual.Nombre = this.txtNombre.Text;
                
                this.UsuarioActual.Apellido = this.txtApellido.Text;
                
                this.UsuarioActual.Email = this.txtEmail.Text;
                
                this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;  
                }
            }

        public override void GuardarCambios() 
            {

            MapearADatos();

            UsuarioLogic UL = new UsuarioLogic();

            UL.Save(UsuarioActual);

            }

        public override bool Validar()
            {

            int ban1,ban2 ,ban3;

            ban1 = ban2 = ban3=0;

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

                    Notificar("Error", "La contraseña debe tener una longitud mìnima de 8 caracteres.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

            if ((ban1 == 1) || (ban2 == 1) || (ban3 == 1)) return false;
                
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
