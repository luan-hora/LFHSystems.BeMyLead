using LFHSystems.BeMyLead.Interface.Interfaces;
using LFHSystems.BeMyLead.Model;
using LFHSystems.BeMyLead.Repository.Contexts;
using Microsoft.EntityFrameworkCore;

namespace LFHSystems.BeMyLead.Repository
{
    public class LeadRepository : ICrud<LeadModel>
    {
        private readonly BeMyLeadDBContext _ctx;
        public LeadRepository(BeMyLeadDBContext ctx)
        {
            this._ctx = ctx;
        }

        public int Delete(LeadModel pObj)
        {
            int ret;
            try
            {
                LeadModel? lead = _ctx.Lead.Find(pObj.ID);
                if (lead != null)
                {
                    _ctx.Lead.Remove(lead);
                    ret = _ctx.SaveChanges();
                }
                else
                    throw new ArgumentNullException();
            }
            catch (Exception ex)
            {
                throw;
            }

            return ret;
        }

        public IEnumerable<LeadModel> GetAll()
        {
            return _ctx.Lead;
        }

        public LeadModel GetByParameter(LeadModel pObj)
        {
            return _ctx.Lead.FirstOrDefault(a => a.ID == pObj.ID) ?? new LeadModel();
        }

        public void Insert(ref LeadModel pObj)
        {
            _ctx.Lead.Add(pObj);
            _ctx.SaveChanges();
        }

        public void Update(LeadModel pObj)
        {
            //_ctx.Entry(pObj).State = EntityState.Modified;
            _ctx.Lead.Update(pObj);
            _ctx.SaveChanges();
        }
    }
}