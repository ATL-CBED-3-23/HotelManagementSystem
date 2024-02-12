using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAPI.Domain.Entities
{
    [Table("ApplicationErrors", Schema = "Hotel")]
    public class ApplicationError : BaseEntity
    {
        public string ErrorMessage { get; set; }
        
    }
}
