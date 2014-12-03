using WebCodeFirstAppData.Entities;

namespace WebCodeFirstAppData.Abstractions
{
    public interface IBlogEntityWriter
    {
        BlogEntity Create(BlogEntity blogEntity);
    }
}
