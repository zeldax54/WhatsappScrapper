using System.ComponentModel.DataAnnotations;

namespace WhatsAppScrapper.Models.DataModels
{
    public class Zone
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(3)]
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [MaxLength(40)]
        public string Name { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
    }
}
