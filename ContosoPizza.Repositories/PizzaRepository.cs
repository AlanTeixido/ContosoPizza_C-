using ContosoPizza.Domain.Entities;
using System;

namespace ContosoPizza.Repositories
{
    // Aquesta classe hereta de Repository<Pizza> i implementa GetEntityId per a gestionar l'ID de cada pizza
    public class PizzaRepository : Repository<Pizza>
    {
        // Mètode necessari per la classe base Repository per obtenir l'ID de cada entitat Pizza
        protected override Guid GetEntityId(Pizza entity)
        {
            // Retornem el camp Id de l'objecte Pizza per identificar-lo
            return entity.Id;
        }
    }
}
