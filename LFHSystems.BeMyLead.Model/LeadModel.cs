using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFHSystems.BeMyLead.Model
{
    public class LeadModel
    {       
        public LeadModel(string name, string email, string phoneNumber, bool wantsToReceiveAnnounces, bool privacyPolicy, DateTime creationDate, DateTime? lastUpdatedDate)
        {
            this.Name = name;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.WantsToReceiveAnnounces = wantsToReceiveAnnounces;
            this.PrivacyPolicy = privacyPolicy;
            this.CreationDate = creationDate;
            this.LastUpdatedDate = lastUpdatedDate;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool WantsToReceiveAnnounces { get; set; }
        public bool PrivacyPolicy { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
