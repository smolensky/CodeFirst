using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebCodeFirstAppData.Entities
{
    public class BlogEntity
    {
        [Key]
        public int BlogId { get; set; }
        [StringLength(20)]
        public string Name { get; set; }

        public virtual List<PostEntity> Posts { get; set; } 
    }
}