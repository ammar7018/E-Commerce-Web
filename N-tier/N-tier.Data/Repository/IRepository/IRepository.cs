using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace N_tier.Data.Repository.IRepository
{
    public interface IRepository <T> where T : class
    {
        IEnumerable<T> GetAll(string?includeProp=null);
        T Get(Expression<Func<T,bool>>filter, string includeProp = null);

        void Add(T obj);
        void Remove(T obj);
        void RemoveRange(IEnumerable<T> obj);
    }
}
