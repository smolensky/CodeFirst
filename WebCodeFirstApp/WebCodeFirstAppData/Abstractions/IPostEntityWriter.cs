using WebCodeFirstAppData.Entities;

namespace WebCodeFirstAppData.Abstractions
{
    public interface IPostEntityWriter
    {
        PostEntity Create(PostEntity blogEntity);
        
    }
}