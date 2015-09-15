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

        private Business.Entities.DocenteCurso _DocenteCursoActual;

        public Business.Entities.DocenteCurso DocenteCursoActual
        
            {
                get { return _DocenteCursoActual; }

                set { _DocenteCursoActual = value; }
            }

        public override void MapearDeDatos()
            {
            this.txtIDDictado.Text = this.DocenteCursoActual.ID.ToString();
            this.txtIDDocente.Text = this.DocenteCursoActual.IDDocente.ToString();
            this.txtIDCurso.Text = this.DocenteCursoActual.IDCurso.ToString();
            this.txtTiposCargo.Text = this.DocenteCursoActual.TiposCargo.ToString();

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
                Business.Entities.DocenteCurso dca = new Business.Entities.DocenteCurso();
                 
                DocenteCursoActual = dca;

                this.DocenteCursoActual.IDDocente = Convert.ToInt32(this.txtIDDocente.Text);
                this.DocenteCursoActual.IDCurso = Convert.ToInt32(this.txtIDCurso.Text);
                this.DocenteCursoActual.TiposCargo = Convert.ToInt32(this.txtTiposCargo.Text);                
                }
            else if (Modo == AplicationForm.ModoForm.Modificacion)
                {
                    this.DocenteCursoActual.ID = Convert.ToInt32(this.txtIDDictado.Text);
                    this.DocenteCursoActual.IDCurso = Convert.ToInt32(this.txtIDDocente.Text);
                    this.DocenteCursoActual.IDDocente = Convert.ToInt32(this.txtIDDocente.Text);
                    this.DocenteCursoActual.TiposCargo = Convert.ToInt32(this.txtTiposCargo.Text); 
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

            int ban1;

            ban1 =  0;

             if ((this.txtIDDocente.Text == null) || (this.txtIDCurso.Text == null) || (this.txtTiposCargo.Text == null))                   {
                    ban1 = 1;

                    Notificar("Error", "Todos los campos son obligatorios, por favor completelos a todos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            if (ban1 == 1) return false;
                
            else return true;
            }

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
