using Lr7.Interfaces;
using System.Text;

namespace Lr7.Services
{
    public class FileService : IFileService
    {
        public byte[] CreateFile(string firstName, string lastName)
        {
            string fileContent = $"Ім'я: {firstName}\nПрізвище: {lastName}";
            return Encoding.UTF8.GetBytes(fileContent);
        }
    }
}