namespace HabitGuiderMobileApp.Interfaces.Repository
{
    public interface IGenericRepository
    {
        Task<List<T>> GetAsync<T>(Uri uri);
        Task<T> GetByIdAsync<T>(Uri uri);
    }
}
