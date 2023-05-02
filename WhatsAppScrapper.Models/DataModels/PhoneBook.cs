using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppScrapper.Models.DataModels
{
    public class PhoneBook
    {
        [Key]
        public int Id { get; set; }        
        public string Name { get; set; } =  String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Phone { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public Zone? Zone { get; set; } 
        public Country? Country { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime UTCCreationDate { get; set; } = DateTime.UtcNow;
        public string UserId { get; set; } = string.Empty;

    }
}
