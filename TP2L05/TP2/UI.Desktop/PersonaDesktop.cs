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
    public partial class PersonaDesktop : AplicationForm
    {
        public PersonaDesktop()
        {
            InitializeComponent();
        }
        private Persona _PersonaActual;

        //Propiedad
        public Persona PersonaActual
        
            {
            get { return _PersonaActual; }

            set { _PersonaActual = value; }
            }

        public override void MapearDeDatos()
            {
            this.txtIDPersona.Text = this.PersonaActual.ID.ToString();        
            this.txtApellido.Text = this.PersonaActual.Apellido;           
            this.txtNombre.Text = this.PersonaActual.Nombre;           
            this.txtDireccion.Text = this.PersonaActual.Direccion;      
            this.txtEmail.Text = this.PersonaActual.Email;            
            this.txtLegajo.Text = this.PersonaActual.Legajo.ToString();
            this.txtTelefono.Text = this.PersonaActual.Telefono;
            this.txtTIpoPersona.Text = this.PersonaActual.TiposPersona.ToString();
            this.txtIDPlan.Text = this.PersonaActual.IDPlan.ToString();

            switch (Modo)
                {

                case ModoForm.Alta:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.PersonaActual.State = BusinessEntity.States.New;
                        
                        }
                    break;
                case ModoForm.Modificacion:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.PersonaActual.State = BusinessEntity.States.Modified;                        
                        }
                    break;
                case ModoForm.Baja:
                        {
                        this.btnAceptar.Text = "Eliminar";
                        this.PersonaActual.State = BusinessEntity.States.Deleted;
                        } 
                    break;
                case ModoForm.Consulta:
                        {
                        this.btnAceptar.Text = "Aceptar";
                        this.PersonaActual.State = BusinessEntity.States.Unmodified;
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
                Persona per = new Business.Entities.Persona();                
                PersonaActual = per;
                 
                this.PersonaActual.ID = Convert.ToInt32(this.txtIDPersona.Text);                
                this.PersonaActual.Direccion = this.txtDireccion.Text;                
                this.PersonaActual.Nombre = this.txtNombre.Text;                
                this.PersonaActual.Apellido = this.txtApellido.Text;                
                this.PersonaActual.Legajo = Convert.ToInt32(txtLegajo.Text);
                this.PersonaActual.IDPlan = Convert.ToInt32(this.txtIDPlan.Text); 
                this.PersonaActual.Telefono = this.txtTelefono.Text;
                this.PersonaActual.TiposPersona = Convert.ToInt32(this.txtTIpoPersona);

              
                }
            else if (Modo == AplicationForm.ModoForm.Modificacion)
                {
                    this.PersonaActual.ID = Convert.ToInt32(this.txtIDPersona.Text);
                    this.PersonaActual.Direccion = this.txtDireccion.Text;
                    this.PersonaActual.Nombre = this.txtNombre.Text;
                    this.PersonaActual.Apellido = this.txtApellido.Text;
                    this.PersonaActual.Legajo = Convert.ToInt32(txtLegajo.Text);
                    this.PersonaActual.IDPlan = Convert.ToInt32(this.txtIDPlan.Text);
                    this.PersonaActual.Telefono = this.txtTelefono.Text;
                    this.PersonaActual.TiposPersona = Convert.ToInt32(this.txtTIpoPersona);  
                }
            }

        public override void GuardarCambios() 
            {
            MapearADatos();
            PersonasLogic UL = new PersonasLogic();
            UL.Save(PersonaActual);
            }


      public override bool Validar()
      {
          /*string mensaje = "";
          bool ok = true;

          foreach(Control c in this.Controls)
          {
              if ((c is TextBox) && (c.Tag.ToString() != "ID") && (!Util.Util.IsComplete(c.Text))) mensaje += " - " + c.Tag.ToString() + "\n";
          }

          if (!string.IsNullOrEmpty(mensaje))
          {
              mensaje = "Por favor complete los siguientes campos:\n" + mensaje;
              ok = false;
          }

          if ((!string.IsNullOrWhiteSpace(txtEmail.Text)) && (!Util.Util.IsValidEMail(this.txtEmail.Text)))
          {
              mensaje += "El email ingresado no es válido.\n";
              ok = false;
          }

          if (!(this.txtClave.Text.Equals(this.txtConfirmarClave.Text)) || (this.txtClave.Text.Length < 8))
          {
              mensaje += "La contraseña ingresada no coincide o posee menos de 8 caracteres.\n";
              ok = false;
          }

          if (!string.IsNullOrEmpty(mensaje)) Notificar(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return ok;*/
          return true;
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

        public PersonaDesktop(ModoForm modo):this()
            {
            this.Modo = modo;   
            }

        public PersonaDesktop(int ID, ModoForm modo)
            : this()
            {
            this.Modo = modo;
            PersonasLogic UL = new PersonasLogic();
            PersonaActual = UL.GetOne(ID);
            MapearDeDatos();
            }

        private void btnCancelar_Click( object sender, EventArgs e )
            {
            DialogResult DR = (MessageBox.Show("Seguro que desea cancelar el proceso?","Cancelar", MessageBoxButtons.YesNo));
            if (DR == DialogResult.Yes) this.Close();      
            }
    }
}
