using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfBug.Data
{
    [Table("Entity")]
    public class ChildEntityTwo : BaseEntity
    {
        public string ValueTwo { get; set; }
        
        [ForeignKey(nameof(OtherEntityId))]
        public OtherEntity OtherEntity { get; set; }
        
        [Column(nameof(OtherEntityId))]
        public Guid? OtherEntityId { get; set; }
    }
}