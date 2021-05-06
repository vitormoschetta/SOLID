using System.Collections.Generic;

namespace Aplicando.Contracts
{
    public interface IRepository<T>
    {
        void Save(T item);
        List<T> GetAll();        
    }
}