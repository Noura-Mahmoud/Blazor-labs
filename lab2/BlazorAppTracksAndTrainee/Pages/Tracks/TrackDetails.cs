using BlazorAppTracksAndTrainee.Services;
using Microsoft.AspNetCore.Components;
using SharedLibrary;

namespace BlazorAppTracksAndTrainee.Pages.Tracks
{
    public partial class TrackDetails
    {
        [Inject]
        public ITrackService trackServices { get; set; }
        [Parameter]
        public int TrackId { get; set; }

        public Track? Track { get; set; } = new Track();
        protected async override Task OnInitializedAsync()
        {
            Track = await trackServices.GetTrackById(TrackId);
            //await base.OnInitializedAsync();
        }
    }
}
