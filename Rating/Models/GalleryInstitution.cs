using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Rating.Models
{
    public class GalleryInstitution
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public DateTime CreateDate { get; } = DateTime.Now;
        public string PhotoPath { get; set; }
        public int InstitutionsId { get; set; }
        public string UserId { get; set; }
        
        [NotMapped]
        public Institution Institution { get; set; }
        [NotMapped]
        public IdentityUser User { get; set; }
    }
}