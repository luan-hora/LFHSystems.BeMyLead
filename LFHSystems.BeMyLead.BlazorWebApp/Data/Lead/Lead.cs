using System.ComponentModel.DataAnnotations;

namespace LFHSystems.BeMyLead.BlazorWebApp.Data.Lead
{
    public class Lead
    {
        public Lead()
        {                
        }

        public Lead(string name, string email, string phoneNumber, bool wantsToReceiveAnnounces, bool privacyPolicy, DateTime creationDate, DateTime? lastUpdatedDate)
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
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please, set the client name")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please, set the e-mail")]
        [Display(Name="E-mail")]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please, set the phone number")]
        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }
        [Display(Name = "I want to receive announces")]
        public bool WantsToReceiveAnnounces { get; set; }
        [Compare("IsTrue", ErrorMessage = "Please agree to the Privacy Policy")]
        [Display(Name = "I accept the Privacy Policy and consent to the processing of my personal information in accordance with it.")]
        public bool PrivacyPolicy { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
