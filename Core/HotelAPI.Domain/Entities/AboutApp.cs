using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAPI.Domain.Entities
{
    [Table("AboutApps", Schema = "Hotel")]
    public class AboutApp : BaseEntity
    {
        public string AppName { get; set; }
        public string Site { get; set; }
        public string AppVersion { get; set; }
        public string Content { get; set; }
    }
}
