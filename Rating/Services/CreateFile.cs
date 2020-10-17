using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Rating.Services
{
    public class CreateFile
    {
        public async Task Create(string path, string fileName, IFormFile file)
        {
            await using var stream = new FileStream(Path.Combine(path, fileName), FileMode.Create);
            await file.CopyToAsync(stream);
        }
    }
}