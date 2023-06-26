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

        public async Task<Lead[]> GetExistingLeads()
        {
            throw new NotImplementedException();
            //var pageRet = new List<Lead>();
            ////List<LeadModel> ret = leadBus.GetExistingLeads();
            //List<LeadModel> ret = await Http.get GetFromJsonAsync<List<Lead>>("api/User");
            //foreach (var cli in ret)
            //{
            //    pageRet.Add(new Lead()
            //    {
            //        ID = cli.ID,
            //        Name = cli.Name,
            //        Email = cli.Email,
            //        PhoneNumber = cli.PhoneNumber,
            //        WantsToReceiveAnnounces = cli.WantsToReceiveAnnounces,
            //        PrivacyPolicy = cli.PrivacyPolicy,
            //        CreationDate = cli.CreationDate,
            //        LastUpdatedDate = cli.LastUpdatedDate,
            //    });
            //}

            //return pageRet.ToArray();
        }

        //public async Task<Lead> GetExistingLeadById(int pLeadId)
        //{
        //    Lead ret;

        //    HttpClientJsonExtensions.GetFromJsonAsync<Lead>($"{_configuration.GetSection("ApiAddresses:WebApiBeMyLead").Value}/Lead/GetExistingLeads");

        //    return ret;
        //}

        public async Task InsertLead(Lead pObj)
        {
            try
            {   
                leadBus.CreateNewLead(new LeadModel(pObj.Name, pObj.Email, pObj.PhoneNumber, pObj.WantsToReceiveAnnounces, pObj.PrivacyPolicy, pObj.CreationDate, null));
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
                leadBus.UpdateExistingLead(new LeadModel(pObj.Name, pObj.Email, pObj.PhoneNumber, pObj.WantsToReceiveAnnounces, pObj.PrivacyPolicy, pObj.CreationDate, DateTime.Now, pObj.ID));
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
