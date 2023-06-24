using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFHSystems.BeMyLead.Business.Base
{
    public abstract class BaseBusiness<T>
    {
        public BaseBusiness()
        {                
        }

        public abstract bool ValidateModel(T pObj);
    }
}
