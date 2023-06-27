using LFHSystems.BeMyLead.Business;
using LFHSystems.BeMyLead.Model;
using static System.Net.WebRequestMethods;

namespace LFHSystems.BeMyLead.BlazorWebApp.Data.Lead
{
    public class LeadService
    {
        private IConfiguration _configuration;
        private LeadBusiness leadBus;
        public LeadService(IConfiguration configuration)
        {
            this._configuration = configuration;
            this.leadBus = new LeadBusiness(_configuration);
        }
        
        public async Task InsertLead(Lead pObj)
        {
            try
            {   
                await leadBus.CreateNewLead(new LeadModel(pObj.Name, pObj.Email, pObj.PhoneNumber, pObj.WantsToReceiveAnnounces, pObj.PrivacyPolicy, pObj.CreationDate, null));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task UpdateLead(Lead pObj)
        {
            try
            {
                await leadBus.UpdateExistingLead(new LeadModel(pObj.Name, pObj.Email, pObj.PhoneNumber, pObj.WantsToReceiveAnnounces, pObj.PrivacyPolicy, pObj.CreationDate, DateTime.Now, pObj.ID));
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
