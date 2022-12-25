using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GISMO.Data.Entities;
using GISMO.Data;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace GISMO.Pages
{
    public class NewClientModel : PageModel
    {
        private readonly AppDbContext _dbcontext;
        [BindProperty]
        [Required(ErrorMessage ="Client Name required")]
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
        
        public NewClientModel(AppDbContext dbcontext)
        
        {
            _dbcontext = dbcontext;
        }
        
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
