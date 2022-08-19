using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Domain.Model.Settings.Azure;
using System.IO;
using System.Threading.Tasks;

namespace SwanSong.Azure.Storage
{
    public class AzureStorageBlobHelper : Base, IAzureStorageBlobHelper
    {
        public AzureStorageBlobHelper(IOptions<AzureSettings> azureSettings) : base(azureSettings)
        { }

        public async Task SaveBlobToAzureStorageContainerAsync(IFormFile file, string containerName, string fileName)
        {
            Stream fileStream = new MemoryStream();
            fileStream = file.OpenReadStream();
            var blobClient = new BlobContainerClient(GetStorageConnection(), containerName);
            var blob = blobClient.GetBlobClient(fileName);
            await blob.UploadAsync(fileStream);
            return;
        }

        public async Task DeleteBlobInAzureStorageContainerAsync(string fileName, string containerName)
        {
            if (fileName == null) return;

            BlobServiceClient blobServiceClient = new BlobServiceClient(GetStorageConnection()); 
            BlobContainerClient container = blobServiceClient.GetBlobContainerClient(containerName);
            await container.DeleteBlobIfExistsAsync(fileName);

            return;
        }
    }
}