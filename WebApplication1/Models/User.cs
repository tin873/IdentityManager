using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string Name { get; set; }
    }
}
