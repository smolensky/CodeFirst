using System.Linq;
using WebCodeFirstAppData.Entities;

namespace WebCodeFirstAppData.Abstractions
{
    public interface IPostEntityReader
    {
        IQueryable<BlogEntity> Read();
    }
}