using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace SqliteGenerationAPI.Services
{
    public class BlobStorageService : IBlobStorageService
    {
        private readonly CloudBlobClient _blobClient;
        public BlobStorageService(IConfiguration configuration)
        {
            var storageAccount = CloudStorageAccount.Parse(configuration.GetConnectionString("BlobStorage"));
            _blobClient = storageAccount.CreateCloudBlobClient();
        }

        public async Task<(bool exists, string url)> BlobExistsAsync(string containerName, string blobName)
        {
            var container = _blobClient.GetContainerReference(containerName);
            
            var blockBlob = container.GetBlockBlobReference(blobName);

            var exists = await blockBlob.ExistsAsync();

            string url = blockBlob.SnapshotQualifiedUri.AbsoluteUri;

            return (exists, exists ? url : string.Empty);
        }


        public async Task<string> UploadBlobAsync(string containerName, string blobName, string contentType, Stream source)
        {
            // Get a reference to the container
            var container = _blobClient.GetContainerReference(containerName);
            await container.CreateIfNotExistsAsync();

            // Get a reference to the blob - blobName can contain directory names separated by '/'
            var blockBlob = container.GetBlockBlobReference(blobName);

            // Upload blob
            await blockBlob.UploadFromStreamAsync(source);

            // Set the content type
            blockBlob.Properties.ContentType = contentType;
            await blockBlob.SetPropertiesAsync();

            return blockBlob.SnapshotQualifiedUri.AbsoluteUri;
        }
    }
}
