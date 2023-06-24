using LFHSystems.BeMyLead.Business.Base;
using LFHSystems.BeMyLead.Model;
using Microsoft.Extensions.Configuration;
using System.Text;
using LFHSystems.BeMyLead.Utils.Extensions;
using LFHSystems.BeMyLead.Utils.API;

namespace LFHSystems.BeMyLead.Business
{
    public class LeadBusiness : BaseBusiness<LeadModel>
    {
        IConfiguration _configuration;
        public LeadBusiness(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public LeadModel CreateNewLead(LeadModel pObj)
        {
            try
            {
                pObj.CreationDate = DateTime.Now;
                StringContent content = new StringContent(pObj.ToJson(), Encoding.UTF8, "application/json");
                string response = APIConsume.ApiPostAsync($"{_configuration.GetSection("ApiAddresses:WebApiBeMyLead").Value}/Lead/Insert", content).Result;

                return pObj;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<LeadModel> GetExistingLeads()
        {
            List<LeadModel> ret;
            try
            {   
                string response = APIConsume.ApiGetAsync($"{_configuration.GetSection("ApiAddresses:WebApiBeMyLead").Value}/Lead/GetExistingLeads").Result;
                ret = Newtonsoft.Json.JsonConvert.DeserializeObject<List<LeadModel>>(response) ?? new List<LeadModel>();

                return ret;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public override bool ValidateModel(LeadModel pObj)
        {
            throw new NotImplementedException();
        }
    }
}