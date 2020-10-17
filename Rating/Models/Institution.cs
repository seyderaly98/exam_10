using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Rating.Models
{
    public class Institution
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public string PhotoPath { get; set; }
        public string Author { get; set; }
        public string UserId { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }
        [NotMapped]
        public IdentityUser User { get; set; }
        
    }
}