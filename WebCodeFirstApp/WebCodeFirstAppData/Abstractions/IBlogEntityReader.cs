using System.Linq;
using WebCodeFirstAppData.Entities;

namespace WebCodeFirstAppData.Abstractions
{
    public interface IBlogEntityReader
    {
        IQueryable<BlogEntity> Read();
    }
}