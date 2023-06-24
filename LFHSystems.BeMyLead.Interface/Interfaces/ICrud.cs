using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFHSystems.BeMyLead.Interface.Interfaces
{
    public interface ICrud<T>
    {
        void Insert(ref T pObj);
        void Update(T pObj);
        int Delete(T pObj);
        IEnumerable<T> GetAll();
        T GetByParameter(T pObj);
    }
}
