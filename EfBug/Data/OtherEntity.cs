using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfBug.Data
{
    [Table(nameof(OtherEntity))]
    public class OtherEntity
    {
        [Key]
        public Guid Guid { get; set; }
        
        public int SomeData { get; set; }
    }
}