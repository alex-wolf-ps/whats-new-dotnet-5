using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;

        public ContactController(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpPost()]
        public void Post(Contact contact)
        {
            // Todo: Save contact info to the database

            // Write uploaded files to images directory
            foreach(var file in contact.AttachedFiles)
            {
                var path = $"{webHostEnvironment.ContentRootPath}\\images\\{file.FileName}";
                var fs = System.IO.File.Create(path);
                fs.Write(file.FileContent, 0, file.FileContent.Length);
                fs.Close();
            }
        }
    }
}
