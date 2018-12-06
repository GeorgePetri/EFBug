using System.ComponentModel.DataAnnotations.Schema;

namespace EfBug.Data
{
    [Table("Entity")]
    public class ChildEntityThree : BaseEntity
    {
        public string ValueThree { get; set; }
    }
}