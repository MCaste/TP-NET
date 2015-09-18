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
    public partial class ComisionDesktop : AplicationForm
    {
        public ComisionDesktop()
        {
            InitializeComponent();
        }

        private Comision _ComisionActual;

        //Propiedad
        public Comision ComisionActual
        
            {
            get { return _ComisionActual; }

            set { _ComisionActual = value; }
            }

        public override void MapearDeDatos()
            {
            this.txtID.Text = this.ComisionActual.ID.ToString();          
            this.txtDescripcion.Text = this.ComisionActual.Descripcion;            
            this.txtAnioEspecialidad.Text = this.ComisionActual.AnioEspecialidad.ToString();           
            this.txtIDPlan.Text = this.ComisionActual.IDPlan.ToString();            
            
            switch (Modo)
                {

                case ModoForm.Alta:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.ComisionActual.State = BusinessEntity.States.New;
                        }
                    break;
                case ModoForm.Modificacion:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.ComisionActual.State = BusinessEntity.States.Modified;                        
                        }
                    break;
                case ModoForm.Baja:
                        {
                        this.btnAceptar.Text = "Eliminar";
                        this.ComisionActual.State = BusinessEntity.States.Deleted;
                        } 
                    break;
                case ModoForm.Consulta:
                        {
                        this.btnAceptar.Text = "Aceptar";
                        this.ComisionActual.State = BusinessEntity.States.Unmodified;
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
                Comision com = new Comision();                
                ComisionActual = com;
                 
                this.ComisionActual.Descripcion = this.txtDescripcion.Text;                
                this.ComisionActual.AnioEspecialidad = Convert.ToInt32(this.txtAnioEspecialidad.Text);                
                this.ComisionActual.IDPlan = Convert.ToInt32(this.txtIDPlan.Text);                                            
                }
            else if (Modo == AplicationForm.ModoForm.Modificacion)
                {
                this.ComisionActual.ID = Convert.ToInt32(this.txtID.Text);            
                this.ComisionActual.Descripcion = this.txtDescripcion.Text;                
                this.ComisionActual.AnioEspecialidad = Convert.ToInt32(this.txtAnioEspecialidad.Text);                
                this.ComisionActual.IDPlan = Convert.ToInt32(this.txtIDPlan.Text);   
                }
            }

        public override void GuardarCambios() 
            {
            MapearADatos();
            ComisionLogic cl = new ComisionLogic();
            cl.Save(ComisionActual);
            }

      public override bool Validar()
            {         
             if ((this.txtDescripcion.Text == null) || (this.txtAnioEspecialidad.Text == null) || (this.txtIDPlan.Text == null))
                    {
                    Notificar("Error", "Todos los campos son obligatorios, por favor completelos a todos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                    }                
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

        public ComisionDesktop(ModoForm modo):this()
            {
            this.Modo = modo;   
            }

        public ComisionDesktop(int ID, ModoForm modo)
            : this()
            {
            this.Modo = modo;
            ComisionLogic cl = new ComisionLogic();
            ComisionActual = cl.GetOne(ID);
            MapearDeDatos();
            }

        private void btnCancelar_Click( object sender, EventArgs e )
            {
            DialogResult DR = (MessageBox.Show("Seguro que desea cancelar el proceso?","Cancelar", MessageBoxButtons.YesNo));
            if (DR == DialogResult.Yes) this.Close();      
            }
    }
}
