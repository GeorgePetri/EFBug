using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfBug.Data
{
    [Table("Entity")]
    public class BaseEntity
    {
        [Key]
        public Guid Guid { get; set; }
        
        public string Value { get; set; }
    }
}