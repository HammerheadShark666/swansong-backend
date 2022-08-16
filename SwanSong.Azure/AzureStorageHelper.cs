using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Domain.Model.Settings.Azure;
using System.IO;
using System.Threading.Tasks;

namespace SwanSong.Azure.Storage
{
    public class AzureStorageHelper : Base, IAzureStorageHelper
    {
        public AzureStorageHelper(IOptions<AzureSettings> azureSettings) : base(azureSettings)
        { }

        public async Task SaveFileToAzureStorageContainerAsync(IFormFile file, string containerName, string fileName)
        {
            Stream myBlob = new MemoryStream();
            myBlob = file.OpenReadStream();
            var blobClient = new BlobContainerClient(GetStorageConnection(), containerName);
            var blob = blobClient.GetBlobClient(fileName);
            await blob.UploadAsync(myBlob);
            return;
        }

        public async Task DeleteFileInAzureStorageContainerAsync(string fileName, string containerName)
        {
            if (fileName == null) return;

            BlobServiceClient blobServiceClient = new BlobServiceClient(GetStorageConnection()); 
            BlobContainerClient container = blobServiceClient.GetBlobContainerClient(containerName);
            await container.DeleteBlobIfExistsAsync(fileName);

            return;
        }
    }
}