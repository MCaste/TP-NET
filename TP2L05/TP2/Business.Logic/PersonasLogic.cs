using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    class PersonasLogic : BusinessLogic
    {
        private PersonaAdapter _PersonaData;

        public PersonaAdapter PersonaData
            {               
             get{ return _PersonaData; }
            }

        public PersonasLogic()
            {
            _PersonaData = new PersonaAdapter();
            }


        public List<Personas> GetAll()
        {
            return PersonaData.GetAll();
        }

        public Personas GetOne(int ID)    
        {
            return PersonaData.GetOne(ID);
        }

        public void Delete( int ID)
        {
            PersonaData.Delete(ID); 
        }

        public void Save(Personas persona)
        {
            PersonaData.Save(persona);   
        }
    }
}
