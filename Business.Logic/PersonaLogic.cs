using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;
using System.Data;

namespace Business.Logic
{
    public class PersonaLogic : BusinessLogic
    {
        private PersonaAdapter PersonaA;
        public PersonaAdapter Pers { get => PersonaA; set => PersonaA = value; }

        public PersonaLogic()
        {
            Pers = new PersonaAdapter();
        }

        public List<Persona> GetAll()
        {
            return Pers.GetAll();
        }

        public Persona GetOne(int ID)
        {
            return Pers.GetOne(ID);
        }
       
        public void Delete(Persona a)
        {
            Pers.Delete(a);
        }

        public void Save(Persona pe)
        {
            Pers.Save(pe);
        }

        

    }
}
