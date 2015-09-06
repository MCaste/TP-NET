using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class AlumnoInscripcionLogic : BusinessLogic   
        {
        private AlumnoInscripcionAdapter _AlumnoInscripcionData;

        public UsuarioAdapter AlumnoInscripcionData
            {
                
             get{
                 return _AlumnoInscripcionData;
                 }
            }

        public AlumnoInscripcionLogic()
            {
                _AlumnoInscripcionData = new AlumnoInscripcionAdapter();
            }


        public List<Usuario> GetAll()
        {
            return AlumnoInscripcionData.GetAll();
        }

        public Usuario GetOne(int ID) 
      
        {
            return AlumnoInscripcionData.GetOne(ID);
        }


        public void Delete( int ID)
        {
            AlumnoInscripcionData.Delete(ID); 
        }


        public void Save(AlumnoInscripciones AlumnoInscripciones)
        {
            AlumnoInscripcionData.Save(AlumnoInscripciones);   
        }

        }
    }

