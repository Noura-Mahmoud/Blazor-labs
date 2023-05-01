using SharedLibrary;
using System.Net.Http.Json;

namespace BlazorApp_customComponent_JSInterop_Identity.Services
{
    public class TrackService : ITrackService
    {

        public TrackService(HttpClient HttpClient)
        {
            this.HttpClient = HttpClient;
        }

        public HttpClient HttpClient { get; }

        public async Task AddTrack(Track track)
        {
            await HttpClient.PostAsJsonAsync("/api/Tracks/", track);
        }

        public async Task DeleteTrack(int trackId)
        {
            await HttpClient.DeleteAsync("/api/Tracks/" + trackId);
        }

        public async Task<IEnumerable<Track>> GetAllTracks()
        {
            return await HttpClient.GetFromJsonAsync<IEnumerable<Track>>("/api/Tracks");
        }

        public async Task<Track> GetTrackById(int trackId)
        {
            return await HttpClient.GetFromJsonAsync<Track>("/api/Tracks/" + trackId);
        }

        public async Task UpdateTrack(Track track)
        {
            await HttpClient.PutAsJsonAsync("/api/Tracks/" + track.ID, track);
        }
    }
}
