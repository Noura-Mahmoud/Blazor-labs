using SharedLibrary;

namespace BlazorApp_customComponent_JSInterop_Identity.Services
{
    public interface ITrackService
    {
        Task<IEnumerable<Track>> GetAllTracks();
        Task<Track> GetTrackById(int trackId);
        Task AddTrack(Track track);
        Task UpdateTrack(Track track);
        Task DeleteTrack(int trackId);
    }
}
