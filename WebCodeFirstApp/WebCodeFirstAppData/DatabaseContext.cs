using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using WebCodeFirstAppData.Entities;

namespace WebCodeFirstAppData
{
    public class DatabaseContext : DbContext
    {
        public DbSet<BlogEntity> Blogs { get; set; }
        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<RandomEntity> Randoms { get; set; }
    }

    public class RandomEntity
    {
        [Key]
        public int RandomId { get; set; }
    }
}