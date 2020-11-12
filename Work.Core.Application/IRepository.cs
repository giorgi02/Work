using System;
using System.Collections.Generic;
using System.Text;

namespace Work.Core.Application
{
    public interface IRepository<T>
    {
        #region Create
        void Add(T entity);
        #endregion

        #region reade
        T Get(int id);
        IEnumerable<T> Get();
        #endregion

        #region Update
        void Update(int id, T entity);
        #endregion

        #region Delete
        void Delete(int id);
        #endregion
    }
}
