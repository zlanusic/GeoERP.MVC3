using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace GeoERP.Repository.Interface
{
    /// <summary>
    /// Repository Pattern služi za pristup podacima(Data Access).
    /// Enkapsulira pristup podacima.
    /// Podaci žive unutar kolekcije koja se nalazi u memoriji(in-memory collection).
    /// Generički interface.
    /// Sadrži generička ograničenja -> "where" dio.
    /// </summary>
    /// <typeparam name="T">Bilo koji tip objekta (any entity type object). T mora bit referentnog tip(class) i mora implementirati IEntity</typeparam>
    public interface IRepository<T> //where T : class, IEntity
    {
        // --API's

        IEnumerable<T> FindAll();

        /// <summary>
        /// Nalazi subset entity-a.
        /// </summary>
        /// <param name="predicateExpression">Predicate Expression</param>
        /// <returns>Vraca općeniti tip entity-a</returns>
        IEnumerable<T> FindSingle(Expression<Func<T, bool>> predicateExpression);

        /// <summary>
        /// Nalazi individualni record.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Business object entity.</returns>
        T FindById(int id);

        /// <summary>
        /// Ukupni broj recorda.
        /// </summary>
        /// <returns>Broj recorda iz baze.</returns>
        int GetCount();

        /// <summary>
        /// Insert-a novi record.
        /// </summary>
        /// <param name="newEntity">Business object entity.</param>
        void Insert(T newEntity);

        /// <summary>
        /// Remove-a postojeci record.
        /// </summary>
        /// <param name="entity">Business object entity.</param>
        void Remove(T entity);
    
    }
}
