using SharedLibrary;

namespace BlazorApp_customComponent_JSInterop_Identity.Services
{
    public interface ITraineeService
    {
        Task<IEnumerable<Trainee>> GetAllTrainees();
        Task<Trainee> GetTraineeById(int traineeId);
        Task AddTrainee(Trainee trainee);
        Task UpdateTrainee(Trainee trainee);
        Task DeleteTrainee(int traineeId);
    }
}
