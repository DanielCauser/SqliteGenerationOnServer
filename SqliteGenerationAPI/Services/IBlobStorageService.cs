using System;
using System.IO;
using System.Threading.Tasks;

namespace SqliteGenerationAPI.Services
{
    public interface IBlobStorageService
    {
        Task<string> UploadBlobAsync(string containerName, string blobName, string contentType, Stream source);
        Task<(bool exists, string url)> BlobExistsAsync(string containerName, string blobName);
    }
}
