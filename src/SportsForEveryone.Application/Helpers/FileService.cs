using Microsoft.AspNetCore.Http;
using SportsForEveryone.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsForEveryone.Application.Helpers
{
    public class FileService : IFileService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public FileService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string SaveFile(string container, IFormFile file)
        {
            var extension  = Path.GetExtension(file.FileName);
            var fileName = $"{Guid.NewGuid()}{extension}";
            string folder = Path.Combine(container);

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            string route = Path.Combine(folder, fileName);
            using (var ms = new MemoryStream())
            {
                file.CopyTo(ms);
                var content = ms.ToArray();
                System.IO.File.WriteAllBytes(route, content);
            }

            //var url = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}";
            var routeForDB = Path.Combine(/*url,*/ container, fileName).Replace("\\", "/");
            return routeForDB;
        }
    }
}
