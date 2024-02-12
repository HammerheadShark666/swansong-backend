using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace SwanSong.Azure.Storage.Interfaces;

public interface IAzureStorageBlobHelper
{
    Task SaveBlobToAzureStorageContainerAsync(IFormFile file, string containerName, string fileName);
    Task DeleteBlobInAzureStorageContainerAsync(string fileName, string containerName);
}