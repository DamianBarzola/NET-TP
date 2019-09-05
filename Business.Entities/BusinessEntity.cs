using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class BusinessEntity
    {
        public BusinessEntity() //esto va ?
        {
        this.State = States.New;
        }

        public enum States { Deleted, New, Modified, Unmodified }

        private int _ID;
        private States _State;

        // falta _habilitado

        public int ID { get => _ID; set => _ID = value; }
        public States State { get => _State; set => _State = value; }
        
    }
}

