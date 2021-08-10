using System.Threading.Tasks;
using animalcontrol_webapi.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace animalcontrol_webapi.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
         public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Animal[]> GetAllAnimalsAsync(bool includeLearningTopic = false)
        {
            IQueryable<Animal> query = _context.Animals;

            if (includeLearningTopic)
            {
                query = query.Include(x => x.AnimalLearnings)
                    .ThenInclude(y => y.LearningTopic)
                    .ThenInclude(z => z.Owner);
            }

            query = query.AsNoTracking()
                .OrderBy(a => a.Id);

            return await query.ToArrayAsync();
        }        

        public async Task<Animal> GetAnimalAsyncById(int animalId, bool includeLearningTopic)
        {
            IQueryable<Animal> query = _context.Animals;

            if (includeLearningTopic)
            {
                query = query.Include(x => x.AnimalLearnings)
                    .ThenInclude(y => y.LearningTopic)
                    .ThenInclude(z => z.Owner);
            }

            query= query.AsNoTracking()
                .OrderBy(animal => animal.Id)
                .Where(animal => animal.Id == animalId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Animal[]> GetAnimalsAsyncByLearningTopicId(int learningTopicId, bool includeLearningTopic)
        {
            IQueryable<Animal> query = _context.Animals;

            if (includeLearningTopic)
            {
                query = query.Include(x => x.AnimalLearnings)
                    .ThenInclude(y => y.LearningTopic)
                    .ThenInclude(z => z.Owner);
            }

            query= query.AsNoTracking()
                .OrderBy(animal => animal.Id)
                .Where(animal => animal.AnimalLearnings.Any(w => w.LearningTopicId == learningTopicId));

            return await query.ToArrayAsync();
        }

        public async Task<Owner[]> GetAllOwnersAsync(bool includeLearningTopic = true)
        {
            IQueryable<Owner> query = _context.Owners;

            if (includeLearningTopic)
            {
                query = query.Include(x => x.LearningTopics);                    
            }

            query = query.AsNoTracking()
                .OrderBy(o => o.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Owner> GetOwnerAsyncById(int ownerId, bool includeLearningTopic = true)
        {
            IQueryable<Owner> query = _context.Owners;

            if (includeLearningTopic)
            {
                query = query.Include(x => x.LearningTopics);
            }

            query = query.AsNoTracking()
                .OrderBy(o => o.Id)
                .Where(x => x.Id == ownerId);

            return await query.FirstOrDefaultAsync();
        }        

    }
}