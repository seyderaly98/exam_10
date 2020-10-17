using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Rating.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int Estimation { get; set; }
        public DateTime CreateDate { get; } = DateTime.Now;
        public int InstitutionsId { get; set; }
        public string UserId { get; set; }
        
        
        [NotMapped]
        public Institution Institution { get; set; }
        [NotMapped]
        public IdentityUser User { get; set; }
        
        
        
    }
}