using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrionInnovation.Domain;

namespace OrionInnovation.Persistence
{
    public class TextRepository : ITextRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public TextRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Text> GetById(int id)
        {
            return await _unitOfWork.Data<Text>()
                                    .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Add(Text text)
        {
            await _unitOfWork.Data<Text>()
                             .AddAsync(text);
            await _unitOfWork.Commit();
        }
    }
}