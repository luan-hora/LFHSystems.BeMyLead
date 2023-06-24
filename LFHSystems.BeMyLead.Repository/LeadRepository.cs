using LFHSystems.BeMyLead.Interface.Interfaces;
using LFHSystems.BeMyLead.Model;
using LFHSystems.BeMyLead.Repository.Contexts;

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
            throw new NotImplementedException();
        }

        public IEnumerable<LeadModel> GetAll()
        {
            return _ctx.Lead;
        }

        public LeadModel GetByParameter(LeadModel pObj)
        {
            throw new NotImplementedException();
        }

        public void Insert(ref LeadModel pObj)
        {
            _ctx.Lead.Add(pObj);
            _ctx.SaveChanges();
        }

        public void Update(LeadModel pObj)
        {
            throw new NotImplementedException();
        }
    }
}