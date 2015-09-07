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
    public class EspecialidadAdapter : Adapter
    {
        #region DatosEnMemoria

        private static List<Especialidad> _Especialidades;

        private static List<Especialidad> Especialidades
        {
            get
            {
                if (_Especialidades == null)
                {
                    _Especialidades = new List<Especialidad>();

                    Especialidad esp = new Especialidad();

                    esp.ID = 1;

                    esp.Descripcion = "ISI";

                    esp.State = BusinessEntity.States.Unmodified;
                    
                    _Especialidades.Add(esp);


                    esp = new Especialidad();

                    esp.ID = 2;

                    esp.Descripcion = "IM";

                    esp.State = BusinessEntity.States.Unmodified;

                    _Especialidades.Add(esp);


                    esp = new Especialidad();

                    esp.ID = 3;

                    esp.Descripcion = "IQ";

                    esp.State = BusinessEntity.States.Unmodified;

                    _Especialidades.Add(esp);


                    esp = new Especialidad();

                    esp.ID = 4;

                    esp.Descripcion = "IE";

                    esp.State = BusinessEntity.States.Unmodified;

                    _Especialidades.Add(esp);

                    
                    esp = new Especialidad();

                    esp.ID = 5;

                    esp.Descripcion = "IC";

                    esp.State = BusinessEntity.States.Unmodified;

                    _Especialidades.Add(esp);

                }
                return _Especialidades;
            }
        }
        #endregion

        public List<Especialidad> GetAll()
        {

            List<Especialidad> especialidades = new List<Especialidad>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdEspecialidades = new SqlCommand("select * from especialidades", sqlConn);

                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();

                while (drEspecialidades.Read())
                {
                    Especialidad esp = new Especialidad();

                    esp.ID = (int)drEspecialidades["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidades["descripcion"];

                    especialidades.Add(esp);
                }
                drEspecialidades.Close();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de especialidades", Ex);

                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }

            return especialidades;

        }


        public Especialidad GetOne(int ID)
        {

            Especialidad esp = new Especialidad();

            try
            {
                this.OpenConnection();

                SqlCommand cmdEspecialidades = new SqlCommand("SELECT * from especialidades where id_especialidad=@id", sqlConn);

                cmdEspecialidades.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();

                if (drEspecialidades.Read())
                {
                    esp.ID = (int)drEspecialidades["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidades["descripcion"];
                }

                drEspecialidades.Close();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de especialidades", Ex);

                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }

            return esp;
        }


        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("delete especialidades where id_especialidad=@id", sqlConn);

                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                cmdDelete.ExecuteNonQuery();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejeada = new Exception("Error al eliminar una especialidad", Ex);

                throw ExcepcionManejeada;
            }
            finally
            {
                this.CloseConnection();
            }
        }


        protected void Update(Especialidad especialidad)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE especialidades SET descripcion=@descripcion" +"WHERE id_especialidad=@id", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = especialidad.ID;
                cmdSave.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = especialidad.Descripcion;

                cmdSave.ExecuteNonQuery();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejeada = new Exception("Error al modificar la especialidad", Ex);

                throw ExcepcionManejeada;
            }

            finally
            {
                this.CloseConnection();
            }
        }


        protected void Insert(Especialidad especialidad)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(
                    "insert into especialidades (descripcion)" +"values (@descripcion)" +"select @@identity", sqlConn);

                cmdSave.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = especialidad.Descripcion;
                
                especialidad.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejeada = new Exception("Error al crear la especialidad", Ex);

                throw ExcepcionManejeada;
            }

            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Especialidad especialidad)
        {
            if (especialidad.State == BusinessEntity.States.Deleted)
            {
                this.Delete(especialidad.ID);
            }
            else if (especialidad.State == BusinessEntity.States.New)
            {
                this.Insert(especialidad);
            }
            else if (especialidad.State == BusinessEntity.States.Modified)
            {
                this.Update(especialidad);
            }
            especialidad.State = BusinessEntity.States.Unmodified;
        }
    }
}
