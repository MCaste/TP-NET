using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;


namespace Business.Logic
    {
    public class UsuarioLogic : BusinessLogic 
        {

        UsuarioAdapter UA = new UsuarioAdapter();

        private UsuarioAdapter _UsuarioData;

        public UsuarioAdapter UsuarioData
                {
                
                get{
                    return _UsuarioData;
                    }
                }
                
        public UsuarioLogic()
            {

            _UsuarioData = new UsuarioAdapter();

            }


        public List<Usuario> GetAll()
        {
        return UA.GetAll();
        }

        public Business.Entities.Usuario GetOne(int ID) 
      
        {
            return UA.GetOne(ID);
        }


        public void Delete( int ID)
        {
        UA.Delete(ID); 
        }


        public void Save( Usuario Usuario)
        {
        UA.Save(Usuario);   
        }

        }
    }
