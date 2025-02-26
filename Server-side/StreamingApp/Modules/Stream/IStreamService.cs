using StreamingApp.Models.Entities;
using StreamingApp.Models.DTOs;
using Stream = StreamingApp.Models.Entities.Stream;

namespace StreamingApp.Services
{
    public interface IStreamService
{
        Task<Stream?> GetStreamByIdAsync(int id);
        Task<IEnumerable<Models.Entities.Stream>> GetAllStreamsAsync();
        Task<bool> DeleteStreamAsync(int id);
        Task<(bool Succeeded, string[] Errors, Models.Entities.Stream? Stream)> CreateStreamAsync(Stream stream);
        Task<(bool Succeeded, string[] Errors)> UpdateStreamAsync(Stream stream);
        Task<(bool Succeeded, string[] Errors)> UpdateImageStreamAsync(int id, StreamUpdateImageDTO model);
    }
}