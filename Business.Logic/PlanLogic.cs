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
    public class PlanLogic : BusinessLogic
    {

        private PlanAdapter plan;

        public PlanAdapter PlanA
        {
            get { return plan; }
            set { plan = value; }
        }

        public PlanLogic()
        {
            PlanA = new PlanAdapter();
        }

        public  List<Plan> GetAll()
        {
            return PlanA.GetAll();

        }

        public Plan GetOne(int id)
        {
            return PlanA.GetOne(id);
        }

        public void Delete(Plan plan)
        {
            PlanA.Delete(plan);
        }

        public void Save(Plan plan)
        {
            PlanA.Save(plan);
        }

        
    }
}
