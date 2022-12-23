using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GISMO.Data.Entities;
using GISMO.Data;
using System.ComponentModel.DataAnnotations;

namespace GISMO.Pages
{
    public class NewClientModel : PageModel
    {
        private readonly AppDbContext _dbcontext;

        [BindProperty]
        [Required(ErrorMessage ="client name required")]
        public string ClientName { get; set; }
        public string ClientType { get; set; }
        public string ClientAddress { get; set; }
        public string ClientContacts { get; set; }
        public string ClientAppLic { get; set; }

        public NewClientModel(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void OnGet()
        {

        }

        public async void OnPost()
        {
            Client client = new();
            client.ClientName = ClientName;
            client.Type = ClientType;
            client.Address = ClientAddress;
            client.Contacts = ClientContacts;
            client.AppLicense = ClientAppLic;
            await _dbcontext.Clientele.AddAsync(client);
            _dbcontext.SaveChanges();
        }
    }
}
