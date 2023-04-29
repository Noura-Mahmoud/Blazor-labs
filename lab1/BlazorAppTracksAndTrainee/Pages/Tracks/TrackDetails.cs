using Microsoft.AspNetCore.Components;
using SharedLibrary;

namespace BlazorAppTracksAndTrainee.Pages.Tracks
{
    public partial class TrackDetails
    {
        [Parameter]
        public int TrackId { get; set; }

        public Track? Track { get; set; } = new Track();
        protected override Task OnInitializedAsync()
        {
            Track = MockData.Tracks.FirstOrDefault(t => t.ID == TrackId);
            return base.OnInitializedAsync();
        }
    }
}
