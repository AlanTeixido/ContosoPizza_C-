using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoPizza.Repositories
{
    // Definimos una clase abstracta Repository que implementa la interfaz IRepository
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        // Creamos una lista en memoria para almacenar las entidades como una "base de datos" temporal
        protected readonly List<T> _entities = new();

        // Método para obtener todas las entidades almacenadas
        public virtual Task<IEnumerable<T>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<T>>(_entities);
        }

        // Método para obtener una entidad por su ID
        public virtual Task<T?> GetByIdAsync(Guid id)
        {
            var entity = _entities.FirstOrDefault(e => GetEntityId(e).Equals(id));
            return Task.FromResult(entity);
        }

        // Método para añadir una nueva entidad a la lista
        public virtual Task AddAsync(T entity)
        {
            _entities.Add(entity);
            return Task.CompletedTask;
        }

        // Método para actualizar una entidad existente en la lista
        public virtual Task UpdateAsync(T entity)
        {
            var existingEntity = _entities.FirstOrDefault(e => GetEntityId(e).Equals(GetEntityId(entity)));
            if (existingEntity != null)
            {
                _entities.Remove(existingEntity);
                _entities.Add(entity);
            }
            return Task.CompletedTask;
        }

        // Método para eliminar una entidad por su ID
        public virtual Task DeleteAsync(Guid id)
        {
            var entity = _entities.FirstOrDefault(e => GetEntityId(e).Equals(id));
            if (entity != null)
            {
                _entities.Remove(entity);
            }
            return Task.CompletedTask;
        }

        // Método abstracto para obtener el ID de una entidad. Las clases hijas deben implementarlo
        protected abstract Guid GetEntityId(T entity);
    }
}
