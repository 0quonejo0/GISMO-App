using GISMO.Data;
using GISMO.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace GISMO.Pages.Clients
{
    public class AddClientModel : PageModel
    {
        private readonly AppDbContext _dbcontext;
        [BindProperty]
        [Required(ErrorMessage = "Client Name required")]
        public string ClientName { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "Type of Client is required")]
        public string ClientAddress { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "Contacts required")]
        public string ClientContacts { get; set; }
        [BindProperty]
        public string ClientAppLic { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "Client type required")]
        public string ClientType { get; set; }

        public void OnGet()
        {
        }
        public async void OnPost()
        {
            Client client = new Client();
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
