using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;


namespace Data.Database
{
    public class PlanAdapter : Adapter
    {
               #region DatosEnMemoria
        // Esta región solo se usa en esta etapa donde los datos se mantienen en memoria.
        // Al modificar este proyecto para que acceda a la base de datos esta será eliminada
        private static List<Usuario> _Usuarios;

        private static List<Usuario> Usuarios
        {
            get
            {
                if (_Usuarios == null)
                {
                    _Usuarios = new List<Business.Entities.Usuario>();
                    Business.Entities.Usuario usr;
                    usr = new Business.Entities.Usuario();
                    usr.ID = 1;
                    usr.State = Business.Entities.BusinessEntity.States.Unmodified;
                    usr.Nombre = "Casimiro";
                    usr.Apellido = "Cegado";
                    usr.NombreUsuario = "casicegado";
                    usr.Clave = "miro";
                    usr.Email = "casimirocegado@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                    usr = new Business.Entities.Usuario();
                    usr.ID = 2;
                    usr.State = Business.Entities.BusinessEntity.States.Unmodified;
                    usr.Nombre = "Armando Esteban";
                    usr.Apellido = "Quito";
                    usr.NombreUsuario = "aequito";
                    usr.Clave = "carpintero";
                    usr.Email = "armandoquito@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                    usr = new Business.Entities.Usuario();
                    usr.ID = 3;
                    usr.State = Business.Entities.BusinessEntity.States.Unmodified;
                    usr.Nombre = "Alan";
                    usr.Apellido = "Brado";
                    usr.NombreUsuario = "alanbrado";
                    usr.Clave = "abrete sesamo";
                    usr.Email = "alanbrado@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                }
                return _Usuarios;
            }
        }
        #endregion

        public List<Plan> GetAll()
        {
            List<Plan> planes = new List<Plan>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdPlanes = new SqlCommand("select * from planes", sqlConn);
                
                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();

                while (drPlanes.Read())
                {
                    Plan p = new Plan();

                    p.ID = (int)drPlanes["id_plan"];
                    p.Descripcion = (string)drPlanes["descripcion"];
                    p.IDEspecialidad = (int)drPlanes["id_especialidad"];

                    planes.Add(p);
                }
                drPlanes.Close();

            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de planes", Ex);

                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }

            return planes;

        }


        public Plan GetOne(int ID)
        {

            Plan p = new Plan();

            try
            {
                this.OpenConnection();

                SqlCommand cmdPlanes = new SqlCommand("SELECT * from planes where id_plan=@id", sqlConn);

                cmdPlanes.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();

                if (drPlanes.Read())
                {
                    p.ID = (int)drPlanes["id_plan"];
                    p.IDEspecialidad = (int)drPlanes["id_especialidad"];
                    p.Descripcion = (string)drPlanes["descripcion"];
                }

                drPlanes.Close();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos del planes", Ex);

                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }

            return p;
        }


        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                
                SqlCommand cmdDelete = new SqlCommand("delete planes where id_plano=@id", sqlConn);
                
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                
                cmdDelete.ExecuteNonQuery();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejeada = new Exception("Error al eliminar plan", Ex);
                
                throw ExcepcionManejeada;
            }
            finally
            {
                this.CloseConnection();
            }
        }


        protected void Update(Plan plan)
        {
            try
            {
                this.OpenConnection();
        
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE planes SET id_especialidad=@id_especialidad, descripcion=@descripcion,"
                    + "WHERE id_plan=@id", sqlConn);
              

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = plan.ID;
                cmdSave.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdSave.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = plan.IDEspecialidad;

                cmdSave.ExecuteNonQuery();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejeada = new Exception("Error al modificar plan", Ex);
                
                throw ExcepcionManejeada;
            }

            finally
            {
                this.CloseConnection();
            }
        }


        protected void Insert(Plan plan)
        {
            try
            {
                this.OpenConnection();
        
                SqlCommand cmdSave = new SqlCommand(
                    "insert into planes (descripcion,id_especialidad)" +
                    "values (@descripcion, @id_especialidad)" +
                    "select @@identity", sqlConn);
                
                cmdSave.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdSave.Parameters.Add("@Id_especialidad", SqlDbType.Int).Value = plan.IDEspecialidad;

                plan.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejeada = new Exception("Error al crear plan", Ex);
                
                throw ExcepcionManejeada;
            }

            finally
            {
                this.CloseConnection();
            }
        }


        public void Save(Plan plan)
        {
            if (plan.State == BusinessEntity.States.Deleted)
            {
                this.Delete(plan.ID);
            }
            else if (plan.State == BusinessEntity.States.New)
            {
                this.Insert(plan);
            }
            else if (plan.State == BusinessEntity.States.Modified)
            {
                this.Update(plan);
            }    
            plan.State = BusinessEntity.States.Unmodified;
        }
    }
}

