using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCodeFirstAppData.Entities
{
    public class PostEntity
    {
        [Key]
        public int PostId { get; set; }
        [StringLength(20)]
        public string Title { get; set; }
        [StringLength(200)]
        public string Content { get; set; }

        public int BlogId { get; set; }

        [ForeignKey("BlogId")]
        public virtual BlogEntity Blog { get; set; }
    }
}