using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWorldHub.Core.Entities.User
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public Address? Address { get; set; }

        public List<Product>? Products { get; set; }
    }
}
