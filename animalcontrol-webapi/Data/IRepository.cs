using System.Threading.Tasks;
using animalcontrol_webapi.Models;

namespace animalcontrol_webapi.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        Task<Animal[]> GetAllAnimalsAsync(bool includeLearningTopic);
        Task<Animal[]> GetAnimalsAsyncByLearningTopicId(int learningTopicId, bool includeLearningTopic);
        Task<Animal> GetAnimalAsyncById(int animalId, bool includeLearningTopic);

        Task<Owner[]> GetAllOwnersAsync(bool includeLearningTopic);        
        Task<Owner> GetOwnerAsyncById(int ownerId, bool includeLearningTopic);

    }
}