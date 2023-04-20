using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppScrapper.Models.DataModels
{
    public class RegisterNumber
    {
        [Key]
        public int Id { get; set; } 
        public string UserId { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public string SettingsDir { get; set; } = string.Empty;
        public DateTime RegisterUTCTime { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;
    }
}
