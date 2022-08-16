using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace SwanSong.Azure.Storage.Interfaces
{
    public interface IAzureStorageHelper
    {
        Task SaveFileToAzureStorageContainerAsync(IFormFile file, string containerName, string fileName);
        Task DeleteFileInAzureStorageContainerAsync(string fileName, string containerName);
    }
}
