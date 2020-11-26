using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace WiredBrainCoffee.Models
{
    public class Contact
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }

        public ContactReason Reason { get; set; }

        public List<UploadedFile> AttachedFiles { get; set; } = new List<UploadedFile>();
    }
}
