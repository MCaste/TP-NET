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
            
            if (Modo == ModoForm.Alta)
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
            else if (Modo == ModoForm.Modificacion)
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
            
            if ((this.txtNombre.Text == null) || (this.txtNombre.Text == null) || (this.txtNombre.Text == null) || (this.txtNombre.Text == null) || (this.txtNombre.Text == null) || (this.txtNombre.Text == null))
                {
                Console.WriteLine("Todos los campos son obligatorios, por favor complete cada uno.\n");

                return false;
                }
                
            if (this.txtClave.Text != this.txtConfirmarClave.Text)
                {
                Console.WriteLine("Las contraseñas no coinciden, por favor vuelva a ingresarla.\n");

                return false;
                }
            if ((this.txtClave.Text.Length) < 8)
                {
                Console.WriteLine("La contraseña debe tener una longitud minima de 8 caracteres.\n");

                return false;
                }

            return true;


            }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
        
         if (Validar() == true) GuardarCambios();

         


         this.Close();
         
        }

        //Agregandole new a los metodos void damos por sabido que el miembro que modificamos oculta el miembro que se hereda de la clase base.
        
        public  new void Notificar( string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono )
            {
            
            
            
            }

        public new void Notificar( string mensaje, MessageBoxButtons botones, MessageBoxIcon icono )
            {
   
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
        }
    }
