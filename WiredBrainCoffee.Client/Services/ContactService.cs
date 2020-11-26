using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.Services
{
    public class ContactService : IContactService
    {
        private readonly HttpClient http;

        public ContactService(HttpClient http)
        {
            this.http = http;
        }

        public async Task PostContact(Contact contact)
        {
            await http.PostAsJsonAsync("contact", contact);
        }

        public async Task PostContact(Contact contact, 
            IReadOnlyList<IBrowserFile> attachedFiles)
        {
            foreach(var file in attachedFiles)
            {
                var buffer = new byte[file.Size];
                await file.OpenReadStream().ReadAsync(buffer);

                contact.AttachedFiles.Add(new UploadedFile()
                {
                    FileName = file.Name,
                    FileContent = buffer
                });
            }

            await http.PostAsJsonAsync("contact", contact);
        }
    }
}