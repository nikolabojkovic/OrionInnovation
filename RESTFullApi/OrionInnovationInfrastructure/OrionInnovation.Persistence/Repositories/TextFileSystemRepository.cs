using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using OrionInnovation.Domain;

namespace OrionInnovation.Persistence
{
    public class TextFileSystemRepository : ITextRepository
    {
        public TextFileSystemRepository()
        {
        }

        public async Task<Text> GetById(int id)
        {
            var fileName = $"Data/FileSystem/TextFiles/Text-id-{id}.txt";
            var rootDir  = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var filePath = Path.Combine(rootDir, fileName);

             if (!File.Exists(filePath))
                throw new DirectoryNotFoundException();

            var fileInfo = new FileInfo(filePath);
            var content = await File.ReadAllTextAsync(filePath);
            var text = Text.Create(content, fileInfo.CreationTime);

            return text;
        }

        public Task Add(Text text)
        {
            return Task.CompletedTask;
        }
    }
}