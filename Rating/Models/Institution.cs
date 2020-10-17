using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Rating.Models
{
    public class Institution
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Это поле необходимо заполнить.")]
        [Remote("CheckInstitutionName","Validation",ErrorMessage = "Заведения с данным название уже добавлен .")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Это поле необходимо заполнить.")]
        public string Description { get; set; }
        
        public double Rating { get; set; }
        public string PhotoPath { get; set; }
        public string Author { get; set; }
        public string UserId { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Это поле необходимо заполнить.")]
        public IFormFile File { get; set; }
        [NotMapped]
        public IdentityUser User { get; set; }

        [NotMapped]
        public List<GalleryInstitution> Gallery { get; set; }
        
    }
}