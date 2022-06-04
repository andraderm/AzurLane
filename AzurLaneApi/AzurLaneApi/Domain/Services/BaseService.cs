using AzurLaneApi.Domain.Data;
using AzurLaneApi.Domain.Entities;
using AzurLaneApi.Domain.Interfaces;
using MongoDB.Driver;
using MongoDB.Bson;

namespace AzurLaneApi.Domain.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        protected readonly AppDbContext _context;

        public BaseService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TEntity>> GetAll()
        {
            List<TEntity> entites = await _context.Database.GetCollection<TEntity>(typeof(TEntity).Name)
                .Find(new BsonDocument())
                .ToListAsync();

            return entites;
        }

        public async Task<TEntity> GetById(string id)
        {
            FilterDefinitionBuilder<TEntity> constructor = Builders<TEntity>.Filter;
            FilterDefinition<TEntity> condition = constructor.Eq(x => x.Id, id);

            TEntity entity = await _context.Database.GetCollection<TEntity>(typeof(TEntity).Name)
                .Find(condition)
                .SingleOrDefaultAsync();

            return entity;
        }

        public async Task Insert(TEntity entity)
        {
            entity.PrepareToInsert();

            await _context.Database.GetCollection<TEntity>(typeof(TEntity).Name).InsertOneAsync(entity); 
        }

        public async Task Update(TEntity entity)
        {
            entity.PrepareToUpdate();

            FilterDefinitionBuilder<TEntity> constructor = Builders<TEntity>.Filter;
            FilterDefinition<TEntity> condition = constructor.Eq(x => x.Id, entity.Id);

            await _context.Database.GetCollection<TEntity>(typeof(TEntity).Name).ReplaceOneAsync(condition, entity);
        }
    }
}
