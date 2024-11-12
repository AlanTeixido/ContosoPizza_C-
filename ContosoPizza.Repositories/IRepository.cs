using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContosoPizza.Repositories
{
    // Aquesta interfície defineix les operacions bàsiques d'un repositori genèric
    public interface IRepository<T>
    {
        // Mètode per obtenir tots els elements del tipus T de manera asíncrona
        Task<IEnumerable<T>> GetAllAsync();

        // Mètode per obtenir un element pel seu "id", permet que el retorn sigui null (per això T?)
        Task<T?> GetByIdAsync(Guid id);  // T? permet que el resultat sigui null si no es troba

        // Mètode per afegir un nou element al repositori de manera asíncrona
        Task AddAsync(T entity);

        // Mètode per actualitzar un element existent de manera asíncrona
        Task UpdateAsync(T entity);

        // Mètode per eliminar un element pel seu "id" de manera asíncrona
        Task DeleteAsync(Guid id);
    }
}
