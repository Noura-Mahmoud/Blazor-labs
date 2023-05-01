using SharedLibrary;
using System.Net.Http.Json;

namespace BlazorApp_customComponent_JSInterop_Identity.Services
{
    public class TraineeService : ITraineeService
    {
        private readonly HttpClient httpClient;

        public TraineeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task AddTrainee(Trainee trainee)
        {
            await httpClient.PostAsJsonAsync("/api/Trainees/", trainee);
        }

        public async Task DeleteTrainee(int traineeId)
        {
            await httpClient.DeleteAsync("/api/Trainees/"+traineeId);
        }

        public async Task<IEnumerable<Trainee>> GetAllTrainees()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Trainee>>("/api/Trainees");
        }

        public async Task<Trainee> GetTraineeById(int traineeId)
        {
            return await httpClient.GetFromJsonAsync<Trainee>("/api/Trainees/"+traineeId);
        }

        public async Task UpdateTrainee(Trainee trainee)
        {
            await httpClient.PutAsJsonAsync("/api/Trainees/" + trainee.ID, trainee);
        }
    }
}
