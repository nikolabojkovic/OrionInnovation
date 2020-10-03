using System.Threading.Tasks;

namespace OrionInnovation.Domain
{
    public interface 
    ITextRepository
    {
        Task<Text> GetById(int id);
        Task Add(Text text);
    }
}